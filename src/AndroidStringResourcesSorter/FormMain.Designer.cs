namespace AndroidStringResourcesSorter
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._labelResourcesFolder = new System.Windows.Forms.Label();
            this._textBoxResourcesFolder = new System.Windows.Forms.TextBox();
            this._buttonBrowse = new System.Windows.Forms.Button();
            this._textBoxSourceContent = new System.Windows.Forms.TextBox();
            this._textBoxSortedContent = new System.Windows.Forms.TextBox();
            this._splitContainerContent = new System.Windows.Forms.SplitContainer();
            this._buttonSave = new System.Windows.Forms.Button();
            this._labelResults = new System.Windows.Forms.Label();
            this._listBoxStringResourceFiles = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerContent)).BeginInit();
            this._splitContainerContent.Panel1.SuspendLayout();
            this._splitContainerContent.Panel2.SuspendLayout();
            this._splitContainerContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // _labelResourcesFolder
            // 
            this._labelResourcesFolder.AutoSize = true;
            this._labelResourcesFolder.Location = new System.Drawing.Point(12, 17);
            this._labelResourcesFolder.Name = "_labelResourcesFolder";
            this._labelResourcesFolder.Size = new System.Drawing.Size(90, 13);
            this._labelResourcesFolder.TabIndex = 0;
            this._labelResourcesFolder.Text = "Resources folder:";
            // 
            // _textBoxResourcesFolder
            // 
            this._textBoxResourcesFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxResourcesFolder.Location = new System.Drawing.Point(108, 14);
            this._textBoxResourcesFolder.Name = "_textBoxResourcesFolder";
            this._textBoxResourcesFolder.ReadOnly = true;
            this._textBoxResourcesFolder.Size = new System.Drawing.Size(599, 20);
            this._textBoxResourcesFolder.TabIndex = 1;
            this._textBoxResourcesFolder.TabStop = false;
            // 
            // _buttonBrowse
            // 
            this._buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonBrowse.Location = new System.Drawing.Point(713, 12);
            this._buttonBrowse.Name = "_buttonBrowse";
            this._buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this._buttonBrowse.TabIndex = 2;
            this._buttonBrowse.Text = "&Browse";
            this._buttonBrowse.UseVisualStyleBackColor = true;
            this._buttonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // _textBoxSourceContent
            // 
            this._textBoxSourceContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textBoxSourceContent.Location = new System.Drawing.Point(0, 0);
            this._textBoxSourceContent.Multiline = true;
            this._textBoxSourceContent.Name = "_textBoxSourceContent";
            this._textBoxSourceContent.ReadOnly = true;
            this._textBoxSourceContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._textBoxSourceContent.Size = new System.Drawing.Size(386, 278);
            this._textBoxSourceContent.TabIndex = 0;
            this._textBoxSourceContent.TabStop = false;
            this._textBoxSourceContent.WordWrap = false;
            // 
            // _textBoxSortedContent
            // 
            this._textBoxSortedContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textBoxSortedContent.Location = new System.Drawing.Point(0, 0);
            this._textBoxSortedContent.Multiline = true;
            this._textBoxSortedContent.Name = "_textBoxSortedContent";
            this._textBoxSortedContent.ReadOnly = true;
            this._textBoxSortedContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._textBoxSortedContent.Size = new System.Drawing.Size(385, 278);
            this._textBoxSortedContent.TabIndex = 0;
            this._textBoxSortedContent.TabStop = false;
            this._textBoxSortedContent.WordWrap = false;
            // 
            // _splitContainerContent
            // 
            this._splitContainerContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._splitContainerContent.Location = new System.Drawing.Point(12, 128);
            this._splitContainerContent.Name = "_splitContainerContent";
            // 
            // _splitContainerContent.Panel1
            // 
            this._splitContainerContent.Panel1.Controls.Add(this._textBoxSourceContent);
            // 
            // _splitContainerContent.Panel2
            // 
            this._splitContainerContent.Panel2.Controls.Add(this._textBoxSortedContent);
            this._splitContainerContent.Size = new System.Drawing.Size(776, 278);
            this._splitContainerContent.SplitterDistance = 386;
            this._splitContainerContent.SplitterWidth = 5;
            this._splitContainerContent.TabIndex = 4;
            this._splitContainerContent.TabStop = false;
            // 
            // _buttonSave
            // 
            this._buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonSave.Location = new System.Drawing.Point(713, 415);
            this._buttonSave.Name = "_buttonSave";
            this._buttonSave.Size = new System.Drawing.Size(75, 23);
            this._buttonSave.TabIndex = 6;
            this._buttonSave.Text = "&Save";
            this._buttonSave.UseVisualStyleBackColor = true;
            this._buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // _labelResults
            // 
            this._labelResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._labelResults.Location = new System.Drawing.Point(12, 420);
            this._labelResults.Name = "_labelResults";
            this._labelResults.Size = new System.Drawing.Size(695, 13);
            this._labelResults.TabIndex = 5;
            // 
            // _listBoxStringResourceFiles
            // 
            this._listBoxStringResourceFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._listBoxStringResourceFiles.FormattingEnabled = true;
            this._listBoxStringResourceFiles.Location = new System.Drawing.Point(12, 40);
            this._listBoxStringResourceFiles.Name = "_listBoxStringResourceFiles";
            this._listBoxStringResourceFiles.Size = new System.Drawing.Size(776, 82);
            this._listBoxStringResourceFiles.TabIndex = 3;
            this._listBoxStringResourceFiles.SelectedIndexChanged += new System.EventHandler(this.ListBoxStringResourceFiles_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._listBoxStringResourceFiles);
            this.Controls.Add(this._labelResults);
            this.Controls.Add(this._buttonSave);
            this.Controls.Add(this._splitContainerContent);
            this.Controls.Add(this._buttonBrowse);
            this.Controls.Add(this._textBoxResourcesFolder);
            this.Controls.Add(this._labelResourcesFolder);
            this.Name = "FormMain";
            this.Text = "String Resources Sorter";
            this._splitContainerContent.Panel1.ResumeLayout(false);
            this._splitContainerContent.Panel1.PerformLayout();
            this._splitContainerContent.Panel2.ResumeLayout(false);
            this._splitContainerContent.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerContent)).EndInit();
            this._splitContainerContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelResourcesFolder;
        private System.Windows.Forms.TextBox _textBoxResourcesFolder;
        private System.Windows.Forms.Button _buttonBrowse;
        private System.Windows.Forms.TextBox _textBoxSourceContent;
        private System.Windows.Forms.TextBox _textBoxSortedContent;
        private System.Windows.Forms.SplitContainer _splitContainerContent;
        private System.Windows.Forms.Button _buttonSave;
        private System.Windows.Forms.Label _labelResults;
        private System.Windows.Forms.ListBox _listBoxStringResourceFiles;
    }
}

