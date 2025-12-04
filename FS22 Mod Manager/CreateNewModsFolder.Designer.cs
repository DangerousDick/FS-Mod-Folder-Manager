namespace FS_Mod_Manager
{
    partial class frmCreateModsFolder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateModsFolder));
            lblCopyFolder = new Label();
            txtCopyFolder = new TextBox();
            btnBrowse = new Button();
            lstModsList = new ListBox();
            lblModsList = new Label();
            lblNewFilder = new Label();
            txtNewFolder = new TextBox();
            btnNewFolder = new Button();
            btnCreateFolder = new Button();
            btnExit = new Button();
            statusStrip = new StatusStrip();
            statusBar = new ToolStripStatusLabel();
            lblFileCount = new Label();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // lblCopyFolder
            // 
            lblCopyFolder.AutoSize = true;
            lblCopyFolder.Location = new Point(12, 12);
            lblCopyFolder.Name = "lblCopyFolder";
            lblCopyFolder.Size = new Size(71, 15);
            lblCopyFolder.TabIndex = 0;
            lblCopyFolder.Text = "Copy Folder";
            // 
            // txtCopyFolder
            // 
            txtCopyFolder.Location = new Point(89, 8);
            txtCopyFolder.Name = "txtCopyFolder";
            txtCopyFolder.Size = new Size(385, 23);
            txtCopyFolder.TabIndex = 1;
            txtCopyFolder.Text = "Copy Folder";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(480, 8);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnCopyBrowse_Click;
            // 
            // lstModsList
            // 
            lstModsList.FormattingEnabled = true;
            lstModsList.HorizontalScrollbar = true;
            lstModsList.ItemHeight = 15;
            lstModsList.Location = new Point(12, 57);
            lstModsList.Name = "lstModsList";
            lstModsList.Size = new Size(543, 484);
            lstModsList.TabIndex = 3;
            // 
            // lblModsList
            // 
            lblModsList.AutoSize = true;
            lblModsList.Location = new Point(16, 39);
            lblModsList.Name = "lblModsList";
            lblModsList.Size = new Size(58, 15);
            lblModsList.TabIndex = 4;
            lblModsList.Text = "Mods List";
            // 
            // lblNewFilder
            // 
            lblNewFilder.AutoSize = true;
            lblNewFilder.Location = new Point(12, 565);
            lblNewFilder.Name = "lblNewFilder";
            lblNewFilder.Size = new Size(67, 15);
            lblNewFilder.TabIndex = 5;
            lblNewFilder.Text = "New Folder";
            // 
            // txtNewFolder
            // 
            txtNewFolder.Location = new Point(85, 562);
            txtNewFolder.Name = "txtNewFolder";
            txtNewFolder.Size = new Size(389, 23);
            txtNewFolder.TabIndex = 6;
            txtNewFolder.Text = "New Folder";
            // 
            // btnNewFolder
            // 
            btnNewFolder.Location = new Point(480, 562);
            btnNewFolder.Name = "btnNewFolder";
            btnNewFolder.Size = new Size(75, 23);
            btnNewFolder.TabIndex = 7;
            btnNewFolder.Text = "Browse";
            btnNewFolder.UseVisualStyleBackColor = true;
            btnNewFolder.Click += btnNewBrowse_Click;
            // 
            // btnCreateFolder
            // 
            btnCreateFolder.Location = new Point(19, 591);
            btnCreateFolder.Name = "btnCreateFolder";
            btnCreateFolder.Size = new Size(121, 23);
            btnCreateFolder.TabIndex = 8;
            btnCreateFolder.Text = "Create New Folder";
            btnCreateFolder.UseVisualStyleBackColor = true;
            btnCreateFolder.Click += btnCreateFolder_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(480, 591);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { statusBar });
            statusStrip.Location = new Point(0, 617);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(567, 22);
            statusStrip.TabIndex = 10;
            statusStrip.Text = "statusStrip";
            // 
            // statusBar
            // 
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(55, 17);
            statusBar.Text = "statusBar";
            // 
            // lblFileCount
            // 
            lblFileCount.AutoSize = true;
            lblFileCount.Location = new Point(12, 544);
            lblFileCount.Name = "lblFileCount";
            lblFileCount.Size = new Size(37, 15);
            lblFileCount.TabIndex = 11;
            lblFileCount.Text = "0 files";
            // 
            // frmCreateModsFolder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 639);
            Controls.Add(lblFileCount);
            Controls.Add(statusStrip);
            Controls.Add(btnExit);
            Controls.Add(btnCreateFolder);
            Controls.Add(btnNewFolder);
            Controls.Add(txtNewFolder);
            Controls.Add(lblNewFilder);
            Controls.Add(lblModsList);
            Controls.Add(lstModsList);
            Controls.Add(btnBrowse);
            Controls.Add(txtCopyFolder);
            Controls.Add(lblCopyFolder);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCreateModsFolder";
            Text = "Create New Mods Folder";
            Load += frmCreateModsFolder_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCopyFolder;
        private TextBox txtCopyFolder;
        private Button btnBrowse;
        private ListBox lstModsList;
        private Label lblModsList;
        private Label lblNewFilder;
        private TextBox txtNewFolder;
        private Button btnNewFolder;
        private Button btnCreateFolder;
        private Button btnExit;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusBar;
        private Label lblFileCount;
    }
}