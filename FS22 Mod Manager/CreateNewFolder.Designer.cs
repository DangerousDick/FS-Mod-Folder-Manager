﻿namespace FS22_Mod_Manager
{
    partial class CreateNewFolder
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewFolder));
            pnlCreateNewFolder = new Panel();
            btnClose = new Button();
            lblSelectedFileCount = new Label();
            lblModFileCount = new Label();
            lblFoldeerCount = new Label();
            btnCreateFolder = new Button();
            btnChangeFolder = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lstSelectedModFiles = new ListBox();
            lstModFiles = new ListBox();
            mnuCtxListModFiles = new ContextMenuStrip(components);
            mnuSelectAllMods = new ToolStripMenuItem();
            lstFolders = new ListBox();
            pnlCreateNewFolder.SuspendLayout();
            mnuCtxListModFiles.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCreateNewFolder
            // 
            pnlCreateNewFolder.Controls.Add(btnClose);
            pnlCreateNewFolder.Controls.Add(lblSelectedFileCount);
            pnlCreateNewFolder.Controls.Add(lblModFileCount);
            pnlCreateNewFolder.Controls.Add(lblFoldeerCount);
            pnlCreateNewFolder.Controls.Add(btnCreateFolder);
            pnlCreateNewFolder.Controls.Add(btnChangeFolder);
            pnlCreateNewFolder.Controls.Add(label3);
            pnlCreateNewFolder.Controls.Add(label2);
            pnlCreateNewFolder.Controls.Add(label1);
            pnlCreateNewFolder.Controls.Add(lstSelectedModFiles);
            pnlCreateNewFolder.Controls.Add(lstModFiles);
            pnlCreateNewFolder.Controls.Add(lstFolders);
            pnlCreateNewFolder.Location = new Point(12, 12);
            pnlCreateNewFolder.Name = "pnlCreateNewFolder";
            pnlCreateNewFolder.Size = new Size(776, 493);
            pnlCreateNewFolder.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(694, 462);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 12;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // lblSelectedFileCount
            // 
            lblSelectedFileCount.AutoSize = true;
            lblSelectedFileCount.Location = new Point(461, 415);
            lblSelectedFileCount.Name = "lblSelectedFileCount";
            lblSelectedFileCount.Size = new Size(80, 15);
            lblSelectedFileCount.TabIndex = 11;
            lblSelectedFileCount.Text = "Selected Files:";
            // 
            // lblModFileCount
            // 
            lblModFileCount.AutoSize = true;
            lblModFileCount.Location = new Point(243, 415);
            lblModFileCount.Name = "lblModFileCount";
            lblModFileCount.Size = new Size(64, 15);
            lblModFileCount.TabIndex = 10;
            lblModFileCount.Text = "Mod Files: ";
            // 
            // lblFoldeerCount
            // 
            lblFoldeerCount.AutoSize = true;
            lblFoldeerCount.Location = new Point(20, 415);
            lblFoldeerCount.Name = "lblFoldeerCount";
            lblFoldeerCount.Size = new Size(51, 15);
            lblFoldeerCount.TabIndex = 9;
            lblFoldeerCount.Text = "Folders: ";
            // 
            // btnCreateFolder
            // 
            btnCreateFolder.Location = new Point(461, 433);
            btnCreateFolder.Name = "btnCreateFolder";
            btnCreateFolder.Size = new Size(308, 23);
            btnCreateFolder.TabIndex = 7;
            btnCreateFolder.Text = "Create Mods Folder";
            btnCreateFolder.UseVisualStyleBackColor = true;
            btnCreateFolder.Click += btnCreateFolder_Click;
            // 
            // btnChangeFolder
            // 
            btnChangeFolder.Location = new Point(20, 433);
            btnChangeFolder.Name = "btnChangeFolder";
            btnChangeFolder.Size = new Size(217, 23);
            btnChangeFolder.TabIndex = 6;
            btnChangeFolder.Text = "Select Favourites Folder";
            btnChangeFolder.UseVisualStyleBackColor = true;
            btnChangeFolder.Click += btnChangeFolder_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(461, 15);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 5;
            label3.Text = "Selected Mod Files";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 15);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "Mod Files";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 3;
            label1.Text = "Favourites Folder";
            // 
            // lstSelectedModFiles
            // 
            lstSelectedModFiles.FormattingEnabled = true;
            lstSelectedModFiles.HorizontalScrollbar = true;
            lstSelectedModFiles.ItemHeight = 15;
            lstSelectedModFiles.Location = new Point(461, 33);
            lstSelectedModFiles.Name = "lstSelectedModFiles";
            lstSelectedModFiles.Size = new Size(308, 379);
            lstSelectedModFiles.TabIndex = 2;
            lstSelectedModFiles.DoubleClick += lstSelectedModFiles_DoubleClick;
            // 
            // lstModFiles
            // 
            lstModFiles.ContextMenuStrip = mnuCtxListModFiles;
            lstModFiles.FormattingEnabled = true;
            lstModFiles.ItemHeight = 15;
            lstModFiles.Location = new Point(243, 33);
            lstModFiles.Name = "lstModFiles";
            lstModFiles.Size = new Size(212, 379);
            lstModFiles.TabIndex = 1;
            lstModFiles.DoubleClick += lstModFiles_DoubleClick;
            // 
            // mnuCtxListModFiles
            // 
            mnuCtxListModFiles.Items.AddRange(new ToolStripItem[] { mnuSelectAllMods });
            mnuCtxListModFiles.Name = "mnuCtxListModFiles";
            mnuCtxListModFiles.Size = new Size(156, 26);
            // 
            // mnuSelectAllMods
            // 
            mnuSelectAllMods.Name = "mnuSelectAllMods";
            mnuSelectAllMods.Size = new Size(155, 22);
            mnuSelectAllMods.Text = "Select All Mods";
            mnuSelectAllMods.Click += mnuSelectAllMods_Click;
            // 
            // lstFolders
            // 
            lstFolders.FormattingEnabled = true;
            lstFolders.ItemHeight = 15;
            lstFolders.Location = new Point(20, 33);
            lstFolders.Name = "lstFolders";
            lstFolders.Size = new Size(217, 379);
            lstFolders.TabIndex = 0;
            lstFolders.SelectedIndexChanged += lstFolders_SelectedIndexChanged;
            // 
            // CreateNewFolder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 515);
            Controls.Add(pnlCreateNewFolder);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateNewFolder";
            Text = "Create New Mods Folder";
            Load += CreateNewFolder_Load;
            pnlCreateNewFolder.ResumeLayout(false);
            pnlCreateNewFolder.PerformLayout();
            mnuCtxListModFiles.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCreateNewFolder;
        private Label label1;
        private ListBox lstSelectedModFiles;
        private ListBox lstModFiles;
        private ListBox lstFolders;
        private Label label3;
        private Label label2;
        private Button btnCreateFolder;
        private Button btnChangeFolder;
        private ContextMenuStrip mnuCtxListModFiles;
        private ToolStripMenuItem mnuSelectAllMods;
        private Label lblSelectedFileCount;
        private Label lblModFileCount;
        private Label lblFoldeerCount;
        private Button btnClose;
    }
}