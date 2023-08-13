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
            pnlCreateNewFolder.SuspendLayout();
            mnuCtxSelectedFiles.SuspendLayout();
            mnuCtxListModFiles.SuspendLayout();
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
            pnlCreateNewFolder.Location = new Point(17, 20);
            pnlCreateNewFolder.Margin = new Padding(4, 5, 4, 5);
            pnlCreateNewFolder.Name = "pnlCreateNewFolder";
            pnlCreateNewFolder.Size = new Size(1109, 971);
            pnlCreateNewFolder.TabIndex = 0;
            // 
            // btnCreateListFromFolder
            // 
            btnCreateListFromFolder.Location = new Point(633, 742);
            btnCreateListFromFolder.Name = "btnCreateListFromFolder";
            btnCreateListFromFolder.Size = new Size(258, 38);
            btnCreateListFromFolder.TabIndex = 25;
            btnCreateListFromFolder.Text = "Create List From Folder";
            btnCreateListFromFolder.UseVisualStyleBackColor = true;
            btnCreateListFromFolder.Click += btnCreateListFromFolder_Click;
            // 
            // btnSavedListsBrowse
            // 
            btnSavedListsBrowse.Location = new Point(1013, 879);
            btnSavedListsBrowse.Margin = new Padding(4, 5, 4, 5);
            btnSavedListsBrowse.Name = "btnSavedListsBrowse";
            btnSavedListsBrowse.Size = new Size(89, 38);
            btnSavedListsBrowse.TabIndex = 24;
            btnSavedListsBrowse.Text = "Browse";
            btnSavedListsBrowse.UseVisualStyleBackColor = true;
            btnSavedListsBrowse.Click += btnSavedListsBrowse_Click;
            // 
            // txtSavedListsPath
            // 
            txtSavedListsPath.BackColor = SystemColors.Info;
            txtSavedListsPath.Location = new Point(158, 883);
            txtSavedListsPath.Margin = new Padding(4, 5, 4, 5);
            txtSavedListsPath.Name = "txtSavedListsPath";
            txtSavedListsPath.Size = new Size(847, 31);
            txtSavedListsPath.TabIndex = 23;
            txtSavedListsPath.Text = "Saved Lists Path";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 886);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(138, 25);
            label5.TabIndex = 22;
            label5.Text = "Saved Lists Path";
            // 
            // btnLoadList
            // 
            btnLoadList.Location = new Point(1001, 742);
            btnLoadList.Margin = new Padding(4, 5, 4, 5);
            btnLoadList.Name = "btnLoadList";
            btnLoadList.Size = new Size(101, 38);
            btnLoadList.TabIndex = 21;
            btnLoadList.Text = "Load List";
            btnLoadList.UseVisualStyleBackColor = true;
            btnLoadList.Click += btnLoadList_Click;
            // 
            // btnSaveList
            // 
            btnSaveList.Location = new Point(898, 742);
            btnSaveList.Margin = new Padding(4, 5, 4, 5);
            btnSaveList.Name = "btnSaveList";
            btnSaveList.Size = new Size(95, 38);
            btnSaveList.TabIndex = 20;
            btnSaveList.Text = "Save List";
            btnSaveList.UseVisualStyleBackColor = true;
            btnSaveList.Click += btnSaveList_Click;
            // 
            // txtCurrentFavouritesFolder
            // 
            txtCurrentFavouritesFolder.BackColor = SystemColors.Info;
            txtCurrentFavouritesFolder.Location = new Point(158, 799);
            txtCurrentFavouritesFolder.Margin = new Padding(4, 5, 4, 5);
            txtCurrentFavouritesFolder.Name = "txtCurrentFavouritesFolder";
            txtCurrentFavouritesFolder.ReadOnly = true;
            txtCurrentFavouritesFolder.Size = new Size(847, 31);
            txtCurrentFavouritesFolder.TabIndex = 19;
            txtCurrentFavouritesFolder.Text = "Current Favourites Folder";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 842);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(146, 25);
            label4.TabIndex = 18;
            label4.Text = "Default Favourite";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(1013, 835);
            btnBrowse.Margin = new Padding(4, 5, 4, 5);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(89, 38);
            btnBrowse.TabIndex = 17;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnDefaultFavourtiesBrowse_Click;
            // 
            // txtDefaultFavouritesFolder
            // 
            txtDefaultFavouritesFolder.BackColor = SystemColors.Info;
            txtDefaultFavouritesFolder.Location = new Point(158, 839);
            txtDefaultFavouritesFolder.Margin = new Padding(4, 5, 4, 5);
            txtDefaultFavouritesFolder.Name = "txtDefaultFavouritesFolder";
            txtDefaultFavouritesFolder.ReadOnly = true;
            txtDefaultFavouritesFolder.Size = new Size(847, 31);
            txtDefaultFavouritesFolder.TabIndex = 16;
            txtDefaultFavouritesFolder.Text = "Default Favourites Folder";
            // 
            // chkOnlyShowZips
            // 
            chkOnlyShowZips.AutoSize = true;
            chkOnlyShowZips.Checked = true;
            chkOnlyShowZips.CheckState = CheckState.Checked;
            chkOnlyShowZips.Location = new Point(323, 706);
            chkOnlyShowZips.Margin = new Padding(4, 5, 4, 5);
            chkOnlyShowZips.Name = "chkOnlyShowZips";
            chkOnlyShowZips.Size = new Size(179, 29);
            chkOnlyShowZips.TabIndex = 15;
            chkOnlyShowZips.Text = "OnlyShowZIpFiles";
            chkOnlyShowZips.UseVisualStyleBackColor = true;
            chkOnlyShowZips.CheckedChanged += chkOnlyShowZips_CheckedChanged;
            // 
            // lblCurrentFavouritesFolder
            // 
            lblCurrentFavouritesFolder.BackColor = SystemColors.Control;
            lblCurrentFavouritesFolder.Location = new Point(4, 798);
            lblCurrentFavouritesFolder.Margin = new Padding(4, 0, 4, 0);
            lblCurrentFavouritesFolder.Name = "lblCurrentFavouritesFolder";
            lblCurrentFavouritesFolder.Size = new Size(158, 33);
            lblCurrentFavouritesFolder.TabIndex = 14;
            lblCurrentFavouritesFolder.Text = "Current Favourites Folder";
            // 
            // chkIncludeParentDir
            // 
            chkIncludeParentDir.AutoSize = true;
            chkIncludeParentDir.Location = new Point(0, 700);
            chkIncludeParentDir.Margin = new Padding(4, 5, 4, 5);
            chkIncludeParentDir.Name = "chkIncludeParentDir";
            chkIncludeParentDir.Size = new Size(243, 29);
            chkIncludeParentDir.TabIndex = 13;
            chkIncludeParentDir.Text = "Include Parent Folder Files";
            chkIncludeParentDir.UseVisualStyleBackColor = true;
            chkIncludeParentDir.CheckedChanged += chkIncludeParentDir_CheckedChanged;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1013, 927);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(89, 38);
            btnClose.TabIndex = 12;
            btnClose.Text = "Exit";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // lblSelectedFileCount
            // 
            lblSelectedFileCount.AutoSize = true;
            lblSelectedFileCount.Location = new Point(634, 670);
            lblSelectedFileCount.Margin = new Padding(4, 0, 4, 0);
            lblSelectedFileCount.Name = "lblSelectedFileCount";
            lblSelectedFileCount.Size = new Size(121, 25);
            lblSelectedFileCount.TabIndex = 11;
            lblSelectedFileCount.Text = "Selected Files:";
            // 
            // lblModFileCount
            // 
            lblModFileCount.AutoSize = true;
            lblModFileCount.Location = new Point(323, 670);
            lblModFileCount.Margin = new Padding(4, 0, 4, 0);
            lblModFileCount.Name = "lblModFileCount";
            lblModFileCount.Size = new Size(98, 25);
            lblModFileCount.TabIndex = 10;
            lblModFileCount.Text = "Mod Files: ";
            // 
            // lblFoldeerCount
            // 
            lblFoldeerCount.AutoSize = true;
            lblFoldeerCount.Location = new Point(4, 670);
            lblFoldeerCount.Margin = new Padding(4, 0, 4, 0);
            lblFoldeerCount.Name = "lblFoldeerCount";
            lblFoldeerCount.Size = new Size(79, 25);
            lblFoldeerCount.TabIndex = 9;
            lblFoldeerCount.Text = "Folders: ";
            // 
            // btnCreateFolder
            // 
            btnCreateFolder.Location = new Point(634, 700);
            btnCreateFolder.Margin = new Padding(4, 5, 4, 5);
            btnCreateFolder.Name = "btnCreateFolder";
            btnCreateFolder.Size = new Size(471, 38);
            btnCreateFolder.TabIndex = 7;
            btnCreateFolder.Text = "Create Mods Folder";
            btnCreateFolder.UseVisualStyleBackColor = true;
            btnCreateFolder.Click += btnCreateFolder_Click;
            // 
            // btnChangeFolder
            // 
            btnChangeFolder.Location = new Point(1016, 795);
            btnChangeFolder.Margin = new Padding(4, 5, 4, 5);
            btnChangeFolder.Name = "btnChangeFolder";
            btnChangeFolder.Size = new Size(89, 38);
            btnChangeFolder.TabIndex = 6;
            btnChangeFolder.Text = "Browse";
            btnChangeFolder.UseVisualStyleBackColor = true;
            btnChangeFolder.Click += btnChangeFolder_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(634, 3);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(160, 25);
            label3.TabIndex = 5;
            label3.Text = "Selected Mod Files";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 3);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 4;
            label2.Text = "Mod Files";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 3);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 3;
            label1.Text = "Favourites Folder";
            // 
            // lstSelectedModFiles
            // 
            lstSelectedModFiles.ContextMenuStrip = mnuCtxSelectedFiles;
            lstSelectedModFiles.FormattingEnabled = true;
            lstSelectedModFiles.HorizontalScrollbar = true;
            lstSelectedModFiles.ItemHeight = 25;
            lstSelectedModFiles.Location = new Point(634, 33);
            lstSelectedModFiles.Margin = new Padding(4, 5, 4, 5);
            lstSelectedModFiles.Name = "lstSelectedModFiles";
            lstSelectedModFiles.Size = new Size(468, 629);
            lstSelectedModFiles.TabIndex = 2;
            lstSelectedModFiles.DoubleClick += lstSelectedModFiles_DoubleClick;
            // 
            // mnuCtxSelectedFiles
            // 
            mnuCtxSelectedFiles.ImageScalingSize = new Size(24, 24);
            mnuCtxSelectedFiles.Items.AddRange(new ToolStripItem[] { mnuCtxRemoveAll });
            mnuCtxSelectedFiles.Name = "mnuCtxSelectedFiles";
            mnuCtxSelectedFiles.Size = new Size(174, 36);
            // 
            // mnuCtxRemoveAll
            // 
            mnuCtxRemoveAll.Name = "mnuCtxRemoveAll";
            mnuCtxRemoveAll.Size = new Size(173, 32);
            mnuCtxRemoveAll.Text = "Remove All";
            mnuCtxRemoveAll.Click += mnuRemoveAll_Click;
            // 
            // lstModFiles
            // 
            lstModFiles.ContextMenuStrip = mnuCtxListModFiles;
            lstModFiles.FormattingEnabled = true;
            lstModFiles.ItemHeight = 25;
            lstModFiles.Location = new Point(323, 33);
            lstModFiles.Margin = new Padding(4, 5, 4, 5);
            lstModFiles.Name = "lstModFiles";
            lstModFiles.Size = new Size(301, 629);
            lstModFiles.TabIndex = 1;
            lstModFiles.DoubleClick += lstModFiles_DoubleClick;
            // 
            // mnuCtxListModFiles
            // 
            mnuCtxListModFiles.ImageScalingSize = new Size(24, 24);
            mnuCtxListModFiles.Items.AddRange(new ToolStripItem[] { mnuSelectAllMods });
            mnuCtxListModFiles.Name = "mnuCtxListModFiles";
            mnuCtxListModFiles.Size = new Size(207, 36);
            // 
            // mnuSelectAllMods
            // 
            mnuSelectAllMods.Name = "mnuSelectAllMods";
            mnuSelectAllMods.Size = new Size(206, 32);
            mnuSelectAllMods.Text = "Select All Mods";
            mnuSelectAllMods.Click += mnuSelectAllMods_Click;
            // 
            // lstFolders
            // 
            lstFolders.FormattingEnabled = true;
            lstFolders.ItemHeight = 25;
            lstFolders.Location = new Point(4, 33);
            lstFolders.Margin = new Padding(4, 5, 4, 5);
            lstFolders.Name = "lstFolders";
            lstFolders.Size = new Size(308, 629);
            lstFolders.TabIndex = 0;
            lstFolders.SelectedIndexChanged += lstFolders_SelectedIndexChanged;
            // 
            // CreateNewFolder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1143, 1003);
            Controls.Add(pnlCreateNewFolder);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "CreateNewFolder";
            Text = "Create New Mods Folder";
            Load += CreateNewFolder_Load;
            pnlCreateNewFolder.ResumeLayout(false);
            pnlCreateNewFolder.PerformLayout();
            mnuCtxSelectedFiles.ResumeLayout(false);
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
    }
}