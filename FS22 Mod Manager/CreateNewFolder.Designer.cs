namespace FS22_Mod_Manager
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
            btnCreateListFromFolder = new Button();
            btnSavedListsBrowse = new Button();
            txtSavedListsPath = new TextBox();
            label5 = new Label();
            btnLoadList = new Button();
            btnSaveList = new Button();
            txtCurrentFavouritesFolder = new TextBox();
            label4 = new Label();
            btnBrowse = new Button();
            txtDefaultFavouritesFolder = new TextBox();
            chkOnlyShowZips = new CheckBox();
            lblCurrentFavouritesFolder = new Label();
            chkIncludeParentDir = new CheckBox();
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
            mnuCtxSelectedFiles = new ContextMenuStrip(components);
            mnuCtxRemoveAll = new ToolStripMenuItem();
            lstModFiles = new ListBox();
            mnuCtxListModFiles = new ContextMenuStrip(components);
            mnuSelectAllMods = new ToolStripMenuItem();
            lstFolders = new ListBox();
            stsCreateModsFolderDialog = new StatusStrip();
            stsCreateModsFolderStatus = new ToolStripStatusLabel();
            pnlCreateNewFolder.SuspendLayout();
            mnuCtxSelectedFiles.SuspendLayout();
            mnuCtxListModFiles.SuspendLayout();
            stsCreateModsFolderDialog.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCreateNewFolder
            // 
            pnlCreateNewFolder.Controls.Add(btnCreateListFromFolder);
            pnlCreateNewFolder.Controls.Add(btnSavedListsBrowse);
            pnlCreateNewFolder.Controls.Add(txtSavedListsPath);
            pnlCreateNewFolder.Controls.Add(label5);
            pnlCreateNewFolder.Controls.Add(btnLoadList);
            pnlCreateNewFolder.Controls.Add(btnSaveList);
            pnlCreateNewFolder.Controls.Add(txtCurrentFavouritesFolder);
            pnlCreateNewFolder.Controls.Add(label4);
            pnlCreateNewFolder.Controls.Add(btnBrowse);
            pnlCreateNewFolder.Controls.Add(txtDefaultFavouritesFolder);
            pnlCreateNewFolder.Controls.Add(chkOnlyShowZips);
            pnlCreateNewFolder.Controls.Add(lblCurrentFavouritesFolder);
            pnlCreateNewFolder.Controls.Add(chkIncludeParentDir);
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
            pnlCreateNewFolder.Location = new Point(6, 5);
            pnlCreateNewFolder.Name = "pnlCreateNewFolder";
            pnlCreateNewFolder.Size = new Size(976, 570);
            pnlCreateNewFolder.TabIndex = 0;
            // 
            // btnCreateListFromFolder
            // 
            btnCreateListFromFolder.Location = new Point(630, 421);
            btnCreateListFromFolder.Margin = new Padding(2);
            btnCreateListFromFolder.Name = "btnCreateListFromFolder";
            btnCreateListFromFolder.Size = new Size(181, 23);
            btnCreateListFromFolder.TabIndex = 25;
            btnCreateListFromFolder.Text = "Create List From Folder";
            btnCreateListFromFolder.UseVisualStyleBackColor = true;
            btnCreateListFromFolder.Click += btnCreateListFromFolder_Click;
            // 
            // btnSavedListsBrowse
            // 
            btnSavedListsBrowse.Location = new Point(909, 511);
            btnSavedListsBrowse.Name = "btnSavedListsBrowse";
            btnSavedListsBrowse.Size = new Size(62, 25);
            btnSavedListsBrowse.TabIndex = 24;
            btnSavedListsBrowse.Text = "Browse";
            btnSavedListsBrowse.UseVisualStyleBackColor = true;
            btnSavedListsBrowse.Click += btnSavedListsBrowse_Click;
            // 
            // txtSavedListsPath
            // 
            txtSavedListsPath.BackColor = SystemColors.Info;
            txtSavedListsPath.Location = new Point(111, 512);
            txtSavedListsPath.Name = "txtSavedListsPath";
            txtSavedListsPath.Size = new Size(792, 23);
            txtSavedListsPath.TabIndex = 23;
            txtSavedListsPath.Text = "Saved Lists Path";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 514);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 22;
            label5.Text = "Saved Lists Path";
            // 
            // btnLoadList
            // 
            btnLoadList.Location = new Point(901, 421);
            btnLoadList.Name = "btnLoadList";
            btnLoadList.Size = new Size(71, 23);
            btnLoadList.TabIndex = 21;
            btnLoadList.Text = "Load List";
            btnLoadList.UseVisualStyleBackColor = true;
            btnLoadList.Click += btnLoadList_Click;
            // 
            // btnSaveList
            // 
            btnSaveList.Location = new Point(823, 421);
            btnSaveList.Name = "btnSaveList";
            btnSaveList.Size = new Size(66, 23);
            btnSaveList.TabIndex = 20;
            btnSaveList.Text = "Save List";
            btnSaveList.UseVisualStyleBackColor = true;
            btnSaveList.Click += btnSaveList_Click;
            // 
            // txtCurrentFavouritesFolder
            // 
            txtCurrentFavouritesFolder.BackColor = SystemColors.Info;
            txtCurrentFavouritesFolder.Location = new Point(111, 456);
            txtCurrentFavouritesFolder.Name = "txtCurrentFavouritesFolder";
            txtCurrentFavouritesFolder.ReadOnly = true;
            txtCurrentFavouritesFolder.Size = new Size(792, 23);
            txtCurrentFavouritesFolder.TabIndex = 19;
            txtCurrentFavouritesFolder.Text = "Current Favourites Folder";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 487);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 18;
            label4.Text = "Default Favourites";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(909, 483);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(62, 25);
            btnBrowse.TabIndex = 17;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnDefaultFavourtiesBrowse_Click;
            // 
            // txtDefaultFavouritesFolder
            // 
            txtDefaultFavouritesFolder.BackColor = SystemColors.Info;
            txtDefaultFavouritesFolder.Location = new Point(111, 485);
            txtDefaultFavouritesFolder.Name = "txtDefaultFavouritesFolder";
            txtDefaultFavouritesFolder.ReadOnly = true;
            txtDefaultFavouritesFolder.Size = new Size(792, 23);
            txtDefaultFavouritesFolder.TabIndex = 16;
            txtDefaultFavouritesFolder.Text = "Default Favourites Folder";
            // 
            // chkOnlyShowZips
            // 
            chkOnlyShowZips.AutoSize = true;
            chkOnlyShowZips.Checked = true;
            chkOnlyShowZips.CheckState = CheckState.Checked;
            chkOnlyShowZips.Location = new Point(226, 424);
            chkOnlyShowZips.Name = "chkOnlyShowZips";
            chkOnlyShowZips.Size = new Size(120, 19);
            chkOnlyShowZips.TabIndex = 15;
            chkOnlyShowZips.Text = "OnlyShowZIpFiles";
            chkOnlyShowZips.UseVisualStyleBackColor = true;
            chkOnlyShowZips.CheckedChanged += chkOnlyShowZips_CheckedChanged;
            // 
            // lblCurrentFavouritesFolder
            // 
            lblCurrentFavouritesFolder.BackColor = SystemColors.Control;
            lblCurrentFavouritesFolder.Location = new Point(13, 457);
            lblCurrentFavouritesFolder.Name = "lblCurrentFavouritesFolder";
            lblCurrentFavouritesFolder.Size = new Size(111, 20);
            lblCurrentFavouritesFolder.TabIndex = 14;
            lblCurrentFavouritesFolder.Text = "Current Favourites Folder";
            // 
            // chkIncludeParentDir
            // 
            chkIncludeParentDir.AutoSize = true;
            chkIncludeParentDir.Location = new Point(3, 420);
            chkIncludeParentDir.Name = "chkIncludeParentDir";
            chkIncludeParentDir.Size = new Size(164, 19);
            chkIncludeParentDir.TabIndex = 13;
            chkIncludeParentDir.Text = "Include Parent Folder Files";
            chkIncludeParentDir.UseVisualStyleBackColor = true;
            chkIncludeParentDir.CheckedChanged += chkIncludeParentDir_CheckedChanged;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(909, 542);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(62, 25);
            btnClose.TabIndex = 12;
            btnClose.Text = "Exit";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // lblSelectedFileCount
            // 
            lblSelectedFileCount.AutoSize = true;
            lblSelectedFileCount.Location = new Point(444, 402);
            lblSelectedFileCount.Name = "lblSelectedFileCount";
            lblSelectedFileCount.Size = new Size(90, 15);
            lblSelectedFileCount.TabIndex = 11;
            lblSelectedFileCount.Text = "Selected Count:";
            // 
            // lblModFileCount
            // 
            lblModFileCount.AutoSize = true;
            lblModFileCount.Location = new Point(226, 402);
            lblModFileCount.Name = "lblModFileCount";
            lblModFileCount.Size = new Size(61, 15);
            lblModFileCount.TabIndex = 10;
            lblModFileCount.Text = "FileCount:";
            // 
            // lblFoldeerCount
            // 
            lblFoldeerCount.AutoSize = true;
            lblFoldeerCount.Location = new Point(3, 402);
            lblFoldeerCount.Name = "lblFoldeerCount";
            lblFoldeerCount.Size = new Size(82, 15);
            lblFoldeerCount.TabIndex = 9;
            lblFoldeerCount.Text = "Folder Count: ";
            // 
            // btnCreateFolder
            // 
            btnCreateFolder.Location = new Point(444, 420);
            btnCreateFolder.Name = "btnCreateFolder";
            btnCreateFolder.Size = new Size(180, 23);
            btnCreateFolder.TabIndex = 7;
            btnCreateFolder.Text = "Create Mods Folder";
            btnCreateFolder.UseVisualStyleBackColor = true;
            btnCreateFolder.Click += btnCreateFolder_Click;
            // 
            // btnChangeFolder
            // 
            btnChangeFolder.Location = new Point(909, 456);
            btnChangeFolder.Name = "btnChangeFolder";
            btnChangeFolder.Size = new Size(62, 25);
            btnChangeFolder.TabIndex = 6;
            btnChangeFolder.Text = "Browse";
            btnChangeFolder.UseVisualStyleBackColor = true;
            btnChangeFolder.Click += btnChangeFolder_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(444, 2);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 5;
            label3.Text = "Selected Mod Files";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 2);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "Mod Files";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 2);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 3;
            label1.Text = "Favourites Folders";
            // 
            // lstSelectedModFiles
            // 
            lstSelectedModFiles.ContextMenuStrip = mnuCtxSelectedFiles;
            lstSelectedModFiles.FormattingEnabled = true;
            lstSelectedModFiles.HorizontalScrollbar = true;
            lstSelectedModFiles.ItemHeight = 15;
            lstSelectedModFiles.Location = new Point(444, 20);
            lstSelectedModFiles.Name = "lstSelectedModFiles";
            lstSelectedModFiles.Size = new Size(529, 379);
            lstSelectedModFiles.TabIndex = 2;
            lstSelectedModFiles.DoubleClick += lstSelectedModFiles_DoubleClick;
            // 
            // mnuCtxSelectedFiles
            // 
            mnuCtxSelectedFiles.ImageScalingSize = new Size(24, 24);
            mnuCtxSelectedFiles.Items.AddRange(new ToolStripItem[] { mnuCtxRemoveAll });
            mnuCtxSelectedFiles.Name = "mnuCtxSelectedFiles";
            mnuCtxSelectedFiles.Size = new Size(135, 26);
            // 
            // mnuCtxRemoveAll
            // 
            mnuCtxRemoveAll.Name = "mnuCtxRemoveAll";
            mnuCtxRemoveAll.Size = new Size(134, 22);
            mnuCtxRemoveAll.Text = "Remove All";
            mnuCtxRemoveAll.Click += mnuRemoveAll_Click;
            // 
            // lstModFiles
            // 
            lstModFiles.ContextMenuStrip = mnuCtxListModFiles;
            lstModFiles.FormattingEnabled = true;
            lstModFiles.ItemHeight = 15;
            lstModFiles.Location = new Point(226, 20);
            lstModFiles.Name = "lstModFiles";
            lstModFiles.Size = new Size(212, 379);
            lstModFiles.TabIndex = 1;
            lstModFiles.DoubleClick += lstModFiles_DoubleClick;
            // 
            // mnuCtxListModFiles
            // 
            mnuCtxListModFiles.ImageScalingSize = new Size(24, 24);
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
            lstFolders.Location = new Point(3, 20);
            lstFolders.Name = "lstFolders";
            lstFolders.Size = new Size(217, 379);
            lstFolders.TabIndex = 0;
            lstFolders.SelectedIndexChanged += lstFolders_SelectedIndexChanged;
            // 
            // stsCreateModsFolderDialog
            // 
            stsCreateModsFolderDialog.Items.AddRange(new ToolStripItem[] { stsCreateModsFolderStatus });
            stsCreateModsFolderDialog.Location = new Point(0, 576);
            stsCreateModsFolderDialog.Name = "stsCreateModsFolderDialog";
            stsCreateModsFolderDialog.Size = new Size(985, 22);
            stsCreateModsFolderDialog.TabIndex = 2;
            stsCreateModsFolderDialog.Text = "statusStrip1";
            // 
            // stsCreateModsFolderStatus
            // 
            stsCreateModsFolderStatus.Name = "stsCreateModsFolderStatus";
            stsCreateModsFolderStatus.Size = new Size(118, 17);
            stsCreateModsFolderStatus.Text = "toolStripStatusLabel1";
            // 
            // CreateNewFolder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(985, 598);
            Controls.Add(stsCreateModsFolderDialog);
            Controls.Add(pnlCreateNewFolder);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateNewFolder";
            Text = "Create New Mods Folder";
            Load += CreateNewFolder_Load;
            pnlCreateNewFolder.ResumeLayout(false);
            pnlCreateNewFolder.PerformLayout();
            mnuCtxSelectedFiles.ResumeLayout(false);
            mnuCtxListModFiles.ResumeLayout(false);
            stsCreateModsFolderDialog.ResumeLayout(false);
            stsCreateModsFolderDialog.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnClose;
        private CheckBox chkIncludeParentDir;
        private Label lblCurrentFavouritesFolder;
        private CheckBox chkOnlyShowZips;
        private ContextMenuStrip mnuCtxSelectedFiles;
        private ToolStripMenuItem mnuCtxRemoveAll;
        private Label label4;
        private Button btnBrowse;
        private TextBox txtDefaultFavouritesFolder;
        private TextBox txtCurrentFavouritesFolder;
        private Button btnLoadList;
        private Button btnSaveList;
        private Button btnSavedListsBrowse;
        private TextBox txtSavedListsPath;
        private Label label5;
        private Button btnCreateListFromFolder;
        private Label lblSelectedFileCount;
        private Label lblModFileCount;
        private Label lblFoldeerCount;
        private StatusStrip stsCreateModsFolderDialog;
        private ToolStripStatusLabel stsCreateModsFolderStatus;
    }
}