namespace FS22_Mod_Manager
{
    partial class GameOptions
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbPerformanceClass = new System.Windows.Forms.ComboBox();
            this.nudFoliageViewDistanceCoeff = new System.Windows.Forms.NumericUpDown();
            this.lblFoliageViewDistanceCoeff = new System.Windows.Forms.Label();
            this.nudTerrainLODDistanceCoeff = new System.Windows.Forms.NumericUpDown();
            this.lblTerrainLODDistanceCoeff = new System.Windows.Forms.Label();
            this.nudLodDistanceCoeff = new System.Windows.Forms.NumericUpDown();
            this.lblLodDistanceCoeff = new System.Windows.Forms.Label();
            this.lblPerformanceClass = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMaximumMirrors = new System.Windows.Forms.Label();
            this.nudMaximumMirrors = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFoliageViewDistanceCoeff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTerrainLODDistanceCoeff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLodDistanceCoeff)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximumMirrors)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(201, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(120, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Location = new System.Drawing.Point(3, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 35);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbPerformanceClass);
            this.panel2.Controls.Add(this.nudFoliageViewDistanceCoeff);
            this.panel2.Controls.Add(this.lblFoliageViewDistanceCoeff);
            this.panel2.Controls.Add(this.nudTerrainLODDistanceCoeff);
            this.panel2.Controls.Add(this.lblTerrainLODDistanceCoeff);
            this.panel2.Controls.Add(this.nudLodDistanceCoeff);
            this.panel2.Controls.Add(this.lblLodDistanceCoeff);
            this.panel2.Controls.Add(this.lblPerformanceClass);
            this.panel2.Location = new System.Drawing.Point(3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 124);
            this.panel2.TabIndex = 7;
            // 
            // cmbPerformanceClass
            // 
            this.cmbPerformanceClass.FormattingEnabled = true;
            this.cmbPerformanceClass.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Ultra"});
            this.cmbPerformanceClass.Location = new System.Drawing.Point(156, 6);
            this.cmbPerformanceClass.Name = "cmbPerformanceClass";
            this.cmbPerformanceClass.Size = new System.Drawing.Size(121, 23);
            this.cmbPerformanceClass.TabIndex = 8;
            this.cmbPerformanceClass.Text = "Medium";
            // 
            // nudFoliageViewDistanceCoeff
            // 
            this.nudFoliageViewDistanceCoeff.DecimalPlaces = 6;
            this.nudFoliageViewDistanceCoeff.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudFoliageViewDistanceCoeff.Location = new System.Drawing.Point(156, 93);
            this.nudFoliageViewDistanceCoeff.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudFoliageViewDistanceCoeff.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudFoliageViewDistanceCoeff.Name = "nudFoliageViewDistanceCoeff";
            this.nudFoliageViewDistanceCoeff.Size = new System.Drawing.Size(121, 23);
            this.nudFoliageViewDistanceCoeff.TabIndex = 7;
            this.nudFoliageViewDistanceCoeff.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblFoliageViewDistanceCoeff
            // 
            this.lblFoliageViewDistanceCoeff.Location = new System.Drawing.Point(10, 95);
            this.lblFoliageViewDistanceCoeff.Name = "lblFoliageViewDistanceCoeff";
            this.lblFoliageViewDistanceCoeff.Size = new System.Drawing.Size(142, 15);
            this.lblFoliageViewDistanceCoeff.TabIndex = 6;
            this.lblFoliageViewDistanceCoeff.Text = "foliageViewDistanceCoeff";
            this.lblFoliageViewDistanceCoeff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudTerrainLODDistanceCoeff
            // 
            this.nudTerrainLODDistanceCoeff.DecimalPlaces = 6;
            this.nudTerrainLODDistanceCoeff.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudTerrainLODDistanceCoeff.Location = new System.Drawing.Point(156, 64);
            this.nudTerrainLODDistanceCoeff.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTerrainLODDistanceCoeff.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudTerrainLODDistanceCoeff.Name = "nudTerrainLODDistanceCoeff";
            this.nudTerrainLODDistanceCoeff.Size = new System.Drawing.Size(121, 23);
            this.nudTerrainLODDistanceCoeff.TabIndex = 5;
            this.nudTerrainLODDistanceCoeff.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTerrainLODDistanceCoeff
            // 
            this.lblTerrainLODDistanceCoeff.Location = new System.Drawing.Point(10, 66);
            this.lblTerrainLODDistanceCoeff.Name = "lblTerrainLODDistanceCoeff";
            this.lblTerrainLODDistanceCoeff.Size = new System.Drawing.Size(142, 15);
            this.lblTerrainLODDistanceCoeff.TabIndex = 4;
            this.lblTerrainLODDistanceCoeff.Text = "terrainLODDistanceCoeff";
            this.lblTerrainLODDistanceCoeff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudLodDistanceCoeff
            // 
            this.nudLodDistanceCoeff.DecimalPlaces = 6;
            this.nudLodDistanceCoeff.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudLodDistanceCoeff.Location = new System.Drawing.Point(156, 35);
            this.nudLodDistanceCoeff.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLodDistanceCoeff.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudLodDistanceCoeff.Name = "nudLodDistanceCoeff";
            this.nudLodDistanceCoeff.Size = new System.Drawing.Size(121, 23);
            this.nudLodDistanceCoeff.TabIndex = 3;
            this.nudLodDistanceCoeff.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblLodDistanceCoeff
            // 
            this.lblLodDistanceCoeff.Location = new System.Drawing.Point(10, 37);
            this.lblLodDistanceCoeff.Name = "lblLodDistanceCoeff";
            this.lblLodDistanceCoeff.Size = new System.Drawing.Size(142, 15);
            this.lblLodDistanceCoeff.TabIndex = 2;
            this.lblLodDistanceCoeff.Text = "lodDistanceCoeff";
            this.lblLodDistanceCoeff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPerformanceClass
            // 
            this.lblPerformanceClass.Location = new System.Drawing.Point(10, 8);
            this.lblPerformanceClass.Name = "lblPerformanceClass";
            this.lblPerformanceClass.Size = new System.Drawing.Size(140, 23);
            this.lblPerformanceClass.TabIndex = 0;
            this.lblPerformanceClass.Text = "performanceClass";
            this.lblPerformanceClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblMaximumMirrors);
            this.panel3.Controls.Add(this.nudMaximumMirrors);
            this.panel3.Location = new System.Drawing.Point(3, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 35);
            this.panel3.TabIndex = 8;
            // 
            // lblMaximumMirrors
            // 
            this.lblMaximumMirrors.Location = new System.Drawing.Point(10, 5);
            this.lblMaximumMirrors.Name = "lblMaximumMirrors";
            this.lblMaximumMirrors.Size = new System.Drawing.Size(140, 21);
            this.lblMaximumMirrors.TabIndex = 1;
            this.lblMaximumMirrors.Text = "Maximum Mirrors";
            this.lblMaximumMirrors.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nudMaximumMirrors
            // 
            this.nudMaximumMirrors.Location = new System.Drawing.Point(158, 5);
            this.nudMaximumMirrors.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudMaximumMirrors.Name = "nudMaximumMirrors";
            this.nudMaximumMirrors.Size = new System.Drawing.Size(42, 23);
            this.nudMaximumMirrors.TabIndex = 0;
            // 
            // GameOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 215);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GameOptions";
            this.Text = "Game Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameOptions_FormClosing);
            this.Load += new System.EventHandler(this.GameOptions_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudFoliageViewDistanceCoeff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTerrainLODDistanceCoeff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLodDistanceCoeff)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximumMirrors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnOK;
        private Button btnCancel;
        private Panel panel1;
        private Panel panel2;
        private ComboBox cmbPerformanceClass;
        private NumericUpDown nudFoliageViewDistanceCoeff;
        private Label lblFoliageViewDistanceCoeff;
        private NumericUpDown nudTerrainLODDistanceCoeff;
        private Label lblTerrainLODDistanceCoeff;
        private NumericUpDown nudLodDistanceCoeff;
        private Label lblLodDistanceCoeff;
        private Label lblPerformanceClass;
        private Panel panel3;
        private Label lblMaximumMirrors;
        private NumericUpDown nudMaximumMirrors;
    }
}