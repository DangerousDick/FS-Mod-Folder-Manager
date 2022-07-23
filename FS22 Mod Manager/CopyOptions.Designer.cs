namespace FS22_Mod_Manager
{
    partial class CopyOptions
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
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.chkOverwriteFile = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(133, 12);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(286, 23);
            this.txtFileName.TabIndex = 1;
            this.txtFileName.Text = "New File Name";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(8, 16);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(119, 15);
            this.lblFileName.TabIndex = 2;
            this.lblFileName.Text = "Rename File on Copy";
            // 
            // chkOverwriteFile
            // 
            this.chkOverwriteFile.AutoSize = true;
            this.chkOverwriteFile.Checked = true;
            this.chkOverwriteFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOverwriteFile.Location = new System.Drawing.Point(133, 41);
            this.chkOverwriteFile.Name = "chkOverwriteFile";
            this.chkOverwriteFile.Size = new System.Drawing.Size(142, 19);
            this.chkOverwriteFile.TabIndex = 3;
            this.chkOverwriteFile.Text = "Overwrite Existing File";
            this.chkOverwriteFile.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(344, 67);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(263, 67);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(8, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 91);
            this.label1.TabIndex = 6;
            this.label1.Text = "Currently Not being used. Chose checkable menu option instead.";
            // 
            // CopyOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 170);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkOverwriteFile);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.txtFileName);
            this.Name = "CopyOptions";
            this.Text = "Copy File Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtFileName;
        private Label lblFileName;
        private CheckBox chkOverwriteFile;
        private Button btnOK;
        private Button btnCancel;
        private Label label1;
    }
}