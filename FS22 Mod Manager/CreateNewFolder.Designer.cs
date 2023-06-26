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
            pnlCreateNewFolder.Location = new Point(12, 12);
            pnlCreateNewFolder.Name = "pnlCreateNewFolder";
            pnlCreateNewFolder.Size = new Size(776, 558);
            pnlCreateNewFolder.TabIndex = 0;
            // 
            // btnLoadList
            // 
            btnLoadList.Location = new Point(668, 420);
            btnLoadList.Name = "btnLoadList";
            btnLoadList.Size = new Size(84, 23);
            btnLoadList.TabIndex = 21;
            btnLoadList.Text = "Load List";
            btnLoadList.UseVisualStyleBackColor = true;
            btnLoadList.Click += btnLoadList_Click;
            // 
            // btnSaveList
            // 
            btnSaveList.Location = new Point(578, 420);
            btnSaveList.Name = "btnSaveList";
            btnSaveList.Size = new Size(84, 23);
            btnSaveList.TabIndex = 20;
            btnSaveList.Text = "Save List";
            btnSaveList.UseVisualStyleBackColor = true;
            btnSaveList.Click += btnSaveList_Click;
            // 
            // txtCurrentFavouritesFolder
            // 
            txtCurrentFavouritesFolder.BackColor = SystemColors.InactiveCaption;
            txtCurrentFavouritesFolder.Location = new Point(153, 472);
            txtCurrentFavouritesFolder.Name = "txtCurrentFavouritesFolder";
            txtCurrentFavouritesFolder.ReadOnly = true;
            txtCurrentFavouritesFolder.Size = new Size(620, 23);
            txtCurrentFavouritesFolder.TabIndex = 19;
            txtCurrentFavouritesFolder.Text = "Current Favourites Folder";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 501);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 18;
            label4.Text = "Default Favourite";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(711, 499);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(62, 23);
            btnBrowse.TabIndex = 17;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnDefaultFavourtiesBrowse_Click;
            // 
            // txtDefaultFavouritesFolder
            // 
            txtDefaultFavouritesFolder.BackColor = SystemColors.Info;
            txtDefaultFavouritesFolder.Location = new Point(106, 498);
            txtDefaultFavouritesFolder.Name = "txtDefaultFavouritesFolder";
            txtDefaultFavouritesFolder.ReadOnly = true;
            txtDefaultFavouritesFolder.Size = new Size(599, 23);
            txtDefaultFavouritesFolder.TabIndex = 16;
            txtDefaultFavouritesFolder.Text = "Default Favourites Folder";
            // 
            // chkOnlyShowZips
            // 
            chkOnlyShowZips.AutoSize = true;
            chkOnlyShowZips.Checked = true;
            chkOnlyShowZips.CheckState = CheckState.Checked;
            chkOnlyShowZips.Location = new Point(226, 449);
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
            lblCurrentFavouritesFolder.Location = new Point(3, 472);
            lblCurrentFavouritesFolder.Name = "lblCurrentFavouritesFolder";
            lblCurrentFavouritesFolder.Size = new Size(144, 20);
            lblCurrentFavouritesFolder.TabIndex = 14;
            lblCurrentFavouritesFolder.Text = "Current Favourites Folder";
            // 
            // chkIncludeParentDir
            // 
            chkIncludeParentDir.AutoSize = true;
            chkIncludeParentDir.Location = new Point(3, 446);
            chkIncludeParentDir.Name = "chkIncludeParentDir";
            chkIncludeParentDir.Size = new Size(164, 19);
            chkIncludeParentDir.TabIndex = 13;
            chkIncludeParentDir.Text = "Include Parent Folder Files";
            chkIncludeParentDir.UseVisualStyleBackColor = true;
            chkIncludeParentDir.CheckedChanged += chkIncludeParentDir_CheckedChanged;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(711, 529);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(62, 23);
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
            lblSelectedFileCount.Size = new Size(80, 15);
            lblSelectedFileCount.TabIndex = 11;
            lblSelectedFileCount.Text = "Selected Files:";
            // 
            // lblModFileCount
            // 
            lblModFileCount.AutoSize = true;
            lblModFileCount.Location = new Point(226, 402);
            lblModFileCount.Name = "lblModFileCount";
            lblModFileCount.Size = new Size(64, 15);
            lblModFileCount.TabIndex = 10;
            lblModFileCount.Text = "Mod Files: ";
            // 
            // lblFoldeerCount
            // 
            lblFoldeerCount.AutoSize = true;
            lblFoldeerCount.Location = new Point(3, 402);
            lblFoldeerCount.Name = "lblFoldeerCount";
            lblFoldeerCount.Size = new Size(51, 15);
            lblFoldeerCount.TabIndex = 9;
            lblFoldeerCount.Text = "Folders: ";
            // 
            // btnCreateFolder
            // 
            btnCreateFolder.Location = new Point(444, 420);
            btnCreateFolder.Name = "btnCreateFolder";
            btnCreateFolder.Size = new Size(128, 23);
            btnCreateFolder.TabIndex = 7;
            btnCreateFolder.Text = "Create Mods Folder";
            btnCreateFolder.UseVisualStyleBackColor = true;
            btnCreateFolder.Click += btnCreateFolder_Click;
            // 
            // btnChangeFolder
            // 
            btnChangeFolder.Location = new Point(3, 420);
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
            label1.Size = new Size(97, 15);
            label1.TabIndex = 3;
            label1.Text = "Favourites Folder";
            // 
            // lstSelectedModFiles
            // 
            lstSelectedModFiles.ContextMenuStrip = mnuCtxSelectedFiles;
            lstSelectedModFiles.FormattingEnabled = true;
            lstSelectedModFiles.HorizontalScrollbar = true;
            lstSelectedModFiles.ItemHeight = 15;
            lstSelectedModFiles.Location = new Point(444, 20);
            lstSelectedModFiles.Name = "lstSelectedModFiles";
            lstSelectedModFiles.Size = new Size(329, 379);
            lstSelectedModFiles.TabIndex = 2;
            lstSelectedModFiles.DoubleClick += lstSelectedModFiles_DoubleClick;
            // 
            // mnuCtxSelectedFiles
            // 
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
            // CreateNewFolder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 573);
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
    }
}