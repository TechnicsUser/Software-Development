namespace mock {
    partial class frmEstimate {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.grpCarMake = new System.Windows.Forms.GroupBox();
            this.radAudi = new System.Windows.Forms.RadioButton();
            this.radBmw = new System.Windows.Forms.RadioButton();
            this.radToyota = new System.Windows.Forms.RadioButton();
            this.radFord = new System.Windows.Forms.RadioButton();
            this.tbFord = new System.Windows.Forms.TextBox();
            this.tbToyota = new System.Windows.Forms.TextBox();
            this.tbBmw = new System.Windows.Forms.TextBox();
            this.tbAudi = new System.Windows.Forms.TextBox();
            this.grpAssessories = new System.Windows.Forms.GroupBox();
            this.radExtra = new System.Windows.Forms.RadioButton();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblExVat = new System.Windows.Forms.Label();
            this.lblIncVat = new System.Windows.Forms.Label();
            this.tbDays = new System.Windows.Forms.TextBox();
            this.tbExVat = new System.Windows.Forms.TextBox();
            this.tbIncVat = new System.Windows.Forms.TextBox();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdGo = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblCostPerDay = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.grpCarMake.SuspendLayout();
            this.grpAssessories.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCarMake
            // 
            this.grpCarMake.Controls.Add(this.radAudi);
            this.grpCarMake.Controls.Add(this.radBmw);
            this.grpCarMake.Controls.Add(this.radToyota);
            this.grpCarMake.Controls.Add(this.radFord);
            this.grpCarMake.Location = new System.Drawing.Point(29, 43);
            this.grpCarMake.Name = "grpCarMake";
            this.grpCarMake.Size = new System.Drawing.Size(102, 133);
            this.grpCarMake.TabIndex = 0;
            this.grpCarMake.TabStop = false;
            this.grpCarMake.Text = "Car Make";
            // 
            // radAudi
            // 
            this.radAudi.AutoSize = true;
            this.radAudi.Location = new System.Drawing.Point(23, 98);
            this.radAudi.Name = "radAudi";
            this.radAudi.Size = new System.Drawing.Size(46, 17);
            this.radAudi.TabIndex = 3;
            this.radAudi.TabStop = true;
            this.radAudi.Text = "Audi";
            this.radAudi.UseVisualStyleBackColor = true;
            this.radAudi.CheckedChanged += new System.EventHandler(this.radAudi_CheckedChanged);
            // 
            // radBmw
            // 
            this.radBmw.AutoSize = true;
            this.radBmw.Location = new System.Drawing.Point(23, 75);
            this.radBmw.Name = "radBmw";
            this.radBmw.Size = new System.Drawing.Size(52, 17);
            this.radBmw.TabIndex = 2;
            this.radBmw.TabStop = true;
            this.radBmw.Text = "BMW";
            this.radBmw.UseVisualStyleBackColor = true;
            this.radBmw.CheckedChanged += new System.EventHandler(this.radBmw_CheckedChanged);
            // 
            // radToyota
            // 
            this.radToyota.AutoSize = true;
            this.radToyota.Location = new System.Drawing.Point(23, 52);
            this.radToyota.Name = "radToyota";
            this.radToyota.Size = new System.Drawing.Size(58, 17);
            this.radToyota.TabIndex = 1;
            this.radToyota.TabStop = true;
            this.radToyota.Text = "Toyota";
            this.radToyota.UseVisualStyleBackColor = true;
            this.radToyota.CheckedChanged += new System.EventHandler(this.radToyota_CheckedChanged);
            // 
            // radFord
            // 
            this.radFord.AutoSize = true;
            this.radFord.Location = new System.Drawing.Point(23, 26);
            this.radFord.Name = "radFord";
            this.radFord.Size = new System.Drawing.Size(46, 17);
            this.radFord.TabIndex = 0;
            this.radFord.TabStop = true;
            this.radFord.Text = "Ford";
            this.radFord.UseVisualStyleBackColor = true;
            this.radFord.CheckedChanged += new System.EventHandler(this.radFord_CheckedChanged);
            // 
            // tbFord
            // 
            this.tbFord.Enabled = false;
            this.tbFord.Location = new System.Drawing.Point(165, 63);
            this.tbFord.Name = "tbFord";
            this.tbFord.Size = new System.Drawing.Size(100, 20);
            this.tbFord.TabIndex = 1;
            this.tbFord.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbToyota
            // 
            this.tbToyota.Enabled = false;
            this.tbToyota.Location = new System.Drawing.Point(165, 89);
            this.tbToyota.Name = "tbToyota";
            this.tbToyota.Size = new System.Drawing.Size(100, 20);
            this.tbToyota.TabIndex = 2;
            this.tbToyota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbBmw
            // 
            this.tbBmw.Enabled = false;
            this.tbBmw.Location = new System.Drawing.Point(165, 115);
            this.tbBmw.Name = "tbBmw";
            this.tbBmw.Size = new System.Drawing.Size(100, 20);
            this.tbBmw.TabIndex = 3;
            this.tbBmw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbAudi
            // 
            this.tbAudi.Enabled = false;
            this.tbAudi.Location = new System.Drawing.Point(165, 141);
            this.tbAudi.Name = "tbAudi";
            this.tbAudi.Size = new System.Drawing.Size(100, 20);
            this.tbAudi.TabIndex = 4;
            this.tbAudi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpAssessories
            // 
            this.grpAssessories.Controls.Add(this.radExtra);
            this.grpAssessories.Controls.Add(this.radStandard);
            this.grpAssessories.Location = new System.Drawing.Point(316, 47);
            this.grpAssessories.Name = "grpAssessories";
            this.grpAssessories.Size = new System.Drawing.Size(94, 100);
            this.grpAssessories.TabIndex = 5;
            this.grpAssessories.TabStop = false;
            this.grpAssessories.Text = "Assessories";
            // 
            // radExtra
            // 
            this.radExtra.AutoSize = true;
            this.radExtra.Location = new System.Drawing.Point(17, 48);
            this.radExtra.Name = "radExtra";
            this.radExtra.Size = new System.Drawing.Size(49, 17);
            this.radExtra.TabIndex = 1;
            this.radExtra.TabStop = true;
            this.radExtra.Text = "Extra";
            this.radExtra.UseVisualStyleBackColor = true;
            this.radExtra.CheckedChanged += new System.EventHandler(this.radExtra_CheckedChanged);
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Location = new System.Drawing.Point(17, 22);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(68, 17);
            this.radStandard.TabIndex = 0;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "Standard";
            this.radStandard.UseVisualStyleBackColor = true;
            this.radStandard.CheckedChanged += new System.EventHandler(this.radStandard_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(422, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(92, 197);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(83, 13);
            this.lblDays.TabIndex = 7;
            this.lblDays.Text = "Number of Days";
            // 
            // lblExVat
            // 
            this.lblExVat.AutoSize = true;
            this.lblExVat.Location = new System.Drawing.Point(79, 227);
            this.lblExVat.Name = "lblExVat";
            this.lblExVat.Size = new System.Drawing.Size(96, 13);
            this.lblExVat.TabIndex = 8;
            this.lblExVat.Text = "Cost Excluding Vat";
            // 
            // lblIncVat
            // 
            this.lblIncVat.AutoSize = true;
            this.lblIncVat.Location = new System.Drawing.Point(82, 261);
            this.lblIncVat.Name = "lblIncVat";
            this.lblIncVat.Size = new System.Drawing.Size(93, 13);
            this.lblIncVat.TabIndex = 9;
            this.lblIncVat.Text = "Cost Including Vat";
            // 
            // tbDays
            // 
            this.tbDays.Location = new System.Drawing.Point(193, 194);
            this.tbDays.Name = "tbDays";
            this.tbDays.Size = new System.Drawing.Size(100, 20);
            this.tbDays.TabIndex = 10;
            this.tbDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbExVat
            // 
            this.tbExVat.Enabled = false;
            this.tbExVat.Location = new System.Drawing.Point(193, 227);
            this.tbExVat.Name = "tbExVat";
            this.tbExVat.Size = new System.Drawing.Size(100, 20);
            this.tbExVat.TabIndex = 11;
            this.tbExVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbIncVat
            // 
            this.tbIncVat.Enabled = false;
            this.tbIncVat.Location = new System.Drawing.Point(196, 258);
            this.tbIncVat.Name = "tbIncVat";
            this.tbIncVat.Size = new System.Drawing.Size(100, 20);
            this.tbIncVat.TabIndex = 12;
            this.tbIncVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Location = new System.Drawing.Point(343, 197);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(75, 23);
            this.cmdCalculate.TabIndex = 13;
            this.cmdCalculate.Text = "Calculate";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(343, 227);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 14;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(343, 307);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 23);
            this.cmdExit.TabIndex = 15;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdGo
            // 
            this.cmdGo.Location = new System.Drawing.Point(196, 307);
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(75, 23);
            this.cmdGo.TabIndex = 16;
            this.cmdGo.Text = "&Go";
            this.cmdGo.UseVisualStyleBackColor = true;
            this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.Red;
            this.lblMain.Location = new System.Drawing.Point(139, 9);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(106, 26);
            this.lblMain.TabIndex = 17;
            this.lblMain.Text = "Car Hire";
            // 
            // lblCostPerDay
            // 
            this.lblCostPerDay.AutoSize = true;
            this.lblCostPerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCostPerDay.Location = new System.Drawing.Point(169, 43);
            this.lblCostPerDay.Name = "lblCostPerDay";
            this.lblCostPerDay.Size = new System.Drawing.Size(69, 13);
            this.lblCostPerDay.TabIndex = 18;
            this.lblCostPerDay.Text = "Cost Per Day";
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.Yellow;
            this.lblOutput.Location = new System.Drawing.Point(79, 281);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(300, 23);
            this.lblOutput.TabIndex = 19;
            // 
            // frmEstimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 340);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblCostPerDay);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.cmdGo);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.tbIncVat);
            this.Controls.Add(this.tbExVat);
            this.Controls.Add(this.tbDays);
            this.Controls.Add(this.lblIncVat);
            this.Controls.Add(this.lblExVat);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.grpAssessories);
            this.Controls.Add(this.tbAudi);
            this.Controls.Add(this.tbBmw);
            this.Controls.Add(this.tbToyota);
            this.Controls.Add(this.tbFord);
            this.Controls.Add(this.grpCarMake);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEstimate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Hire Estimate";
            this.grpCarMake.ResumeLayout(false);
            this.grpCarMake.PerformLayout();
            this.grpAssessories.ResumeLayout(false);
            this.grpAssessories.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.GroupBox grpCarMake;
        private System.Windows.Forms.RadioButton radAudi;
        private System.Windows.Forms.RadioButton radBmw;
        private System.Windows.Forms.RadioButton radToyota;
        private System.Windows.Forms.RadioButton radFord;
        private System.Windows.Forms.TextBox tbFord;
        private System.Windows.Forms.TextBox tbToyota;
        private System.Windows.Forms.TextBox tbBmw;
        private System.Windows.Forms.TextBox tbAudi;
        private System.Windows.Forms.GroupBox grpAssessories;
        private System.Windows.Forms.RadioButton radExtra;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblExVat;
        private System.Windows.Forms.Label lblIncVat;
        private System.Windows.Forms.TextBox tbDays;
        private System.Windows.Forms.TextBox tbExVat;
        private System.Windows.Forms.TextBox tbIncVat;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdGo;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblCostPerDay;
        private System.Windows.Forms.Label lblOutput;
        }
    }

