using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace AndroidStringResourcesSorter
{
    public partial class FormMain : Form
    {
        private SortedDictionary<string, XmlNode> _stringArrayNodes;
        private SortedDictionary<string, XmlNode> _stringNodes;

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            _buttonSave.Enabled = false;

            // TODO: Should remeber / restore the last selected directory
            using (var dialog = new FolderBrowserDialog())
            {
                // NOTE: For testing purposes
                //dialog.SelectedPath = @"C:\src\personal\SmokingLog\common\src\main\res";
                dialog.ShowNewFolderButton = false;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ResetContent();

                    _labelResults.Text = string.Empty;
                    _listBoxStringResourceFiles.Items.Clear();
                    _textBoxResourcesFolder.Text = dialog.SelectedPath;

                    var directories = Directory.GetDirectories(_textBoxResourcesFolder.Text, "values*");
                    foreach (var directory in directories)
                    {
                        var files = Directory.GetFiles(directory, "strings.xml");
                        foreach (var file in files)
                        {
                            _listBoxStringResourceFiles.Items.Add(file);
                        }
                    }

                    if (_listBoxStringResourceFiles.Items.Count > 0)
                    {
                        _listBoxStringResourceFiles.SelectedIndex = 0;
                        _listBoxStringResourceFiles.Focus();
                    }
                }
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            _listBoxStringResourceFiles.Enabled = false;

            var filename = _listBoxStringResourceFiles.SelectedItem as string;

            if (!string.IsNullOrWhiteSpace(filename))
            {
                File.WriteAllText(filename, _textBoxSortedContent.Text);

                _buttonSave.Enabled = false;
                _labelResults.Text = "Successfully saved sorted file";
            }
            else
            {
                _labelResults.Text = "Invalid filename";
            }

            _listBoxStringResourceFiles.Enabled = true;
        }

        public FormMain()
        {
            InitializeComponent();
        }

        private void ListBoxStringResourceFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortStringResources(_listBoxStringResourceFiles.SelectedItem as string);
        }

        private void ResetContent()
        {
            _textBoxSortedContent.Text = string.Empty;
            _textBoxSourceContent.Text = string.Empty;

            _stringArrayNodes = new SortedDictionary<string, XmlNode>();
            _stringNodes = new SortedDictionary<string, XmlNode>();
        }

        private void SortStringResources(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return;
            }

            ResetContent();

            _listBoxStringResourceFiles.Enabled = false;

            var sourceContent = new StringBuilder();
            using (var reader = File.OpenText(fileName))
            {
                while (!reader.EndOfStream)
                {
                    var currentLine = reader.ReadLineAsync().Result;
                    if (!string.IsNullOrWhiteSpace(currentLine))
                    {
                        sourceContent.AppendLine(currentLine);
                    }
                }
            }

            _textBoxSourceContent.Text = sourceContent.ToString().Trim();

            var sourceXml = new XmlDocument();
            sourceXml.LoadXml(_textBoxSourceContent.Text);

            var resourcesElement = sourceXml.GetElementsByTagName("resources")[0];

            var stringArrays = resourcesElement.SelectNodes("string-array");
            if (stringArrays != null)
            {
                foreach (XmlNode node in stringArrays)
                {
                    if (node?.Attributes == null)
                    {
                        continue;
                    }

                    _stringArrayNodes.Add(node.Attributes["name"].Value, node);
                }
            }

            var strings = resourcesElement.SelectNodes("string");
            if (strings != null)
            {
                foreach (XmlNode node in strings)
                {
                    if (node?.Attributes == null)
                    {
                        continue;
                    }

                    _stringNodes.Add(node.Attributes["name"].Value, node);
                }
            }

            resourcesElement.RemoveAll();

            foreach (var element in _stringNodes.Values)
            {
                resourcesElement.AppendChild(element);
            }

            foreach (var element in _stringArrayNodes.Values)
            {
                resourcesElement.AppendChild(element);
            }

            var settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "    ",
                Encoding = Encoding.UTF8
            };

            using (var stringWriter = new StringWriter())
            using (var xmlTextWriter = XmlWriter.Create(stringWriter, settings))
            {
                sourceXml.WriteTo(xmlTextWriter);
                xmlTextWriter.Flush();

                _textBoxSortedContent.Text = stringWriter.GetStringBuilder().ToString();
            }

            _buttonSave.Enabled = true;
            _labelResults.Text = $"Source lines: {_textBoxSourceContent.Lines.Length} | Target lines: {_textBoxSortedContent.Lines.Length}";
            _listBoxStringResourceFiles.Enabled = true;
            _listBoxStringResourceFiles.Focus();
        }
    }
}
