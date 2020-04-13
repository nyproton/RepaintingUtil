namespace RepaintingUtil
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.utilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMedicalID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFractions = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDosefx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPlanID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbFields = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMU = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGantry = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRS = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCouch = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEnergy = new System.Windows.Forms.TextBox();
            this.btnLoadField = new System.Windows.Forms.Button();
            this.txtSnout = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.plotViewHistogram = new OxyPlot.WindowsForms.PlotView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtLayerMinMU = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtLayerMinMW = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtLayerMaxMU = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtLayerMaxMW = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtLayerSpots = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtLayerEn = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtLayerIndex = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.utilityToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "S&ave as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "&Close";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "&Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // utilityToolStripMenuItem
            // 
            this.utilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.splitToolStripMenuItem});
            this.utilityToolStripMenuItem.Name = "utilityToolStripMenuItem";
            this.utilityToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.utilityToolStripMenuItem.Text = "&Utility";
            // 
            // splitToolStripMenuItem
            // 
            this.splitToolStripMenuItem.Enabled = false;
            this.splitToolStripMenuItem.Name = "splitToolStripMenuItem";
            this.splitToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.splitToolStripMenuItem.Text = "&Split...";
            this.splitToolStripMenuItem.Click += new System.EventHandler(this.splitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSex);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDOB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMedicalID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(871, 47);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(556, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sex";
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(584, 17);
            this.txtSex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(76, 20);
            this.txtSex.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DOB";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(472, 17);
            this.txtDOB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.ReadOnly = true;
            this.txtDOB.Size = new System.Drawing.Size(76, 20);
            this.txtDOB.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Medical ID";
            // 
            // txtMedicalID
            // 
            this.txtMedicalID.Location = new System.Drawing.Point(355, 17);
            this.txtMedicalID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMedicalID.Name = "txtMedicalID";
            this.txtMedicalID.ReadOnly = true;
            this.txtMedicalID.Size = new System.Drawing.Size(76, 20);
            this.txtMedicalID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(212, 17);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(76, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(66, 17);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(76, 20);
            this.txtLastName.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fractions";
            // 
            // txtFractions
            // 
            this.txtFractions.Location = new System.Drawing.Point(355, 17);
            this.txtFractions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFractions.Name = "txtFractions";
            this.txtFractions.ReadOnly = true;
            this.txtFractions.Size = new System.Drawing.Size(76, 20);
            this.txtFractions.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Dose/fx";
            // 
            // txtDosefx
            // 
            this.txtDosefx.Location = new System.Drawing.Point(212, 17);
            this.txtDosefx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDosefx.Name = "txtDosefx";
            this.txtDosefx.ReadOnly = true;
            this.txtDosefx.Size = new System.Drawing.Size(76, 20);
            this.txtDosefx.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "RT Plan ID";
            // 
            // txtPlanID
            // 
            this.txtPlanID.Location = new System.Drawing.Point(66, 17);
            this.txtPlanID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPlanID.Name = "txtPlanID";
            this.txtPlanID.ReadOnly = true;
            this.txtPlanID.Size = new System.Drawing.Size(76, 20);
            this.txtPlanID.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFractions);
            this.groupBox2.Controls.Add(this.txtPlanID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDosefx);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 71);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(871, 46);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plan Information";
            // 
            // cbFields
            // 
            this.cbFields.FormattingEnabled = true;
            this.cbFields.Location = new System.Drawing.Point(45, 17);
            this.cbFields.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFields.Name = "cbFields";
            this.cbFields.Size = new System.Drawing.Size(142, 21);
            this.cbFields.TabIndex = 14;
            this.cbFields.SelectedIndexChanged += new System.EventHandler(this.cbFields_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Fields";
            // 
            // txtMU
            // 
            this.txtMU.Location = new System.Drawing.Point(224, 17);
            this.txtMU.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMU.Name = "txtMU";
            this.txtMU.ReadOnly = true;
            this.txtMU.Size = new System.Drawing.Size(114, 20);
            this.txtMU.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(197, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "MU";
            // 
            // txtGantry
            // 
            this.txtGantry.Location = new System.Drawing.Point(384, 17);
            this.txtGantry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGantry.Name = "txtGantry";
            this.txtGantry.ReadOnly = true;
            this.txtGantry.Size = new System.Drawing.Size(47, 20);
            this.txtGantry.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(341, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Gantry";
            // 
            // txtRS
            // 
            this.txtRS.Location = new System.Drawing.Point(514, 53);
            this.txtRS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRS.Name = "txtRS";
            this.txtRS.ReadOnly = true;
            this.txtRS.Size = new System.Drawing.Size(89, 20);
            this.txtRS.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(438, 55);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Range Shifter";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCouch);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtEnergy);
            this.groupBox3.Controls.Add(this.btnLoadField);
            this.groupBox3.Controls.Add(this.txtSnout);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtRS);
            this.groupBox3.Controls.Add(this.cbFields);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtGantry);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtMU);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 117);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(871, 84);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Field Information";
            // 
            // txtCouch
            // 
            this.txtCouch.Location = new System.Drawing.Point(384, 53);
            this.txtCouch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCouch.Name = "txtCouch";
            this.txtCouch.ReadOnly = true;
            this.txtCouch.Size = new System.Drawing.Size(47, 20);
            this.txtCouch.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(344, 55);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Couch";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(179, 55);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Energy";
            // 
            // txtEnergy
            // 
            this.txtEnergy.Location = new System.Drawing.Point(224, 53);
            this.txtEnergy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEnergy.Name = "txtEnergy";
            this.txtEnergy.ReadOnly = true;
            this.txtEnergy.Size = new System.Drawing.Size(116, 20);
            this.txtEnergy.TabIndex = 25;
            // 
            // btnLoadField
            // 
            this.btnLoadField.Enabled = false;
            this.btnLoadField.Location = new System.Drawing.Point(21, 53);
            this.btnLoadField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoadField.Name = "btnLoadField";
            this.btnLoadField.Size = new System.Drawing.Size(120, 19);
            this.btnLoadField.TabIndex = 24;
            this.btnLoadField.Text = "Load Field";
            this.btnLoadField.UseVisualStyleBackColor = true;
            this.btnLoadField.Click += new System.EventHandler(this.btnLoadField_Click);
            // 
            // txtSnout
            // 
            this.txtSnout.Location = new System.Drawing.Point(514, 17);
            this.txtSnout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSnout.Name = "txtSnout";
            this.txtSnout.ReadOnly = true;
            this.txtSnout.Size = new System.Drawing.Size(89, 20);
            this.txtSnout.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(435, 20);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Snout Position";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.plotView1);
            this.groupBox4.Controls.Add(this.plotViewHistogram);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 201);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(871, 509);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Spot map";
            // 
            // plotViewHistogram
            // 
            this.plotViewHistogram.Location = new System.Drawing.Point(460, 191);
            this.plotViewHistogram.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.plotViewHistogram.Name = "plotViewHistogram";
            this.plotViewHistogram.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotViewHistogram.Size = new System.Drawing.Size(406, 312);
            this.plotViewHistogram.TabIndex = 4;
            this.plotViewHistogram.Text = "pvHistogram";
            this.plotViewHistogram.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotViewHistogram.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotViewHistogram.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtLayerMinMU);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.txtLayerMinMW);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.txtLayerMaxMU);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.txtLayerMaxMW);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.txtLayerSpots);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.txtLayerEn);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.txtLayerIndex);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.btnNext);
            this.groupBox5.Controls.Add(this.btnPrev);
            this.groupBox5.Controls.Add(this.btnLast);
            this.groupBox5.Controls.Add(this.btnFirst);
            this.groupBox5.Location = new System.Drawing.Point(460, 18);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(400, 169);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Layer Information";
            // 
            // txtLayerMinMU
            // 
            this.txtLayerMinMU.Location = new System.Drawing.Point(283, 85);
            this.txtLayerMinMU.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLayerMinMU.Name = "txtLayerMinMU";
            this.txtLayerMinMU.ReadOnly = true;
            this.txtLayerMinMU.Size = new System.Drawing.Size(76, 20);
            this.txtLayerMinMU.TabIndex = 17;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(237, 88);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(44, 13);
            this.label25.TabIndex = 16;
            this.label25.Text = "MU Min";
            // 
            // txtLayerMinMW
            // 
            this.txtLayerMinMW.Location = new System.Drawing.Point(283, 63);
            this.txtLayerMinMW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLayerMinMW.Name = "txtLayerMinMW";
            this.txtLayerMinMW.ReadOnly = true;
            this.txtLayerMinMW.Size = new System.Drawing.Size(76, 20);
            this.txtLayerMinMW.TabIndex = 15;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(201, 65);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(81, 13);
            this.label26.TabIndex = 14;
            this.label26.Text = "MU Weight Min";
            // 
            // txtLayerMaxMU
            // 
            this.txtLayerMaxMU.Location = new System.Drawing.Point(283, 40);
            this.txtLayerMaxMU.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLayerMaxMU.Name = "txtLayerMaxMU";
            this.txtLayerMaxMU.ReadOnly = true;
            this.txtLayerMaxMU.Size = new System.Drawing.Size(76, 20);
            this.txtLayerMaxMU.TabIndex = 13;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(235, 42);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 13);
            this.label21.TabIndex = 12;
            this.label21.Text = "MU Max";
            // 
            // txtLayerMaxMW
            // 
            this.txtLayerMaxMW.Location = new System.Drawing.Point(283, 17);
            this.txtLayerMaxMW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLayerMaxMW.Name = "txtLayerMaxMW";
            this.txtLayerMaxMW.ReadOnly = true;
            this.txtLayerMaxMW.Size = new System.Drawing.Size(76, 20);
            this.txtLayerMaxMW.TabIndex = 11;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(199, 20);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 13);
            this.label19.TabIndex = 10;
            this.label19.Text = "MU Weight Max";
            // 
            // txtLayerSpots
            // 
            this.txtLayerSpots.Location = new System.Drawing.Point(98, 63);
            this.txtLayerSpots.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLayerSpots.Name = "txtLayerSpots";
            this.txtLayerSpots.ReadOnly = true;
            this.txtLayerSpots.Size = new System.Drawing.Size(76, 20);
            this.txtLayerSpots.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(34, 66);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "Scan Spots";
            // 
            // txtLayerEn
            // 
            this.txtLayerEn.Location = new System.Drawing.Point(98, 41);
            this.txtLayerEn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLayerEn.Name = "txtLayerEn";
            this.txtLayerEn.ReadOnly = true;
            this.txtLayerEn.Size = new System.Drawing.Size(76, 20);
            this.txtLayerEn.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(54, 43);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Energy";
            // 
            // txtLayerIndex
            // 
            this.txtLayerIndex.Location = new System.Drawing.Point(98, 18);
            this.txtLayerIndex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLayerIndex.Name = "txtLayerIndex";
            this.txtLayerIndex.ReadOnly = true;
            this.txtLayerIndex.Size = new System.Drawing.Size(76, 20);
            this.txtLayerIndex.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(63, 20);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Index";
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(221, 125);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(45, 24);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Enabled = false;
            this.btnPrev.Location = new System.Drawing.Point(129, 125);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(45, 24);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnLast
            // 
            this.btnLast.Enabled = false;
            this.btnLast.Location = new System.Drawing.Point(313, 125);
            this.btnLast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(45, 24);
            this.btnLast.TabIndex = 1;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Enabled = false;
            this.btnFirst.Location = new System.Drawing.Point(37, 125);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(45, 24);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 708);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(871, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel1.Text = "No File";
            // 
            // plotView1
            // 
            this.plotView1.Location = new System.Drawing.Point(7, 18);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(450, 488);
            this.plotView1.TabIndex = 5;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 730);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Repainting Utility - No File";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem utilityToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMedicalID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFractions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDosefx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPlanID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbFields;
        private System.Windows.Forms.TextBox txtRS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGantry;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMU;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TextBox txtSnout;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEnergy;
        private System.Windows.Forms.Button btnLoadField;
        private System.Windows.Forms.TextBox txtCouch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtLayerEn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtLayerIndex;
        private System.Windows.Forms.TextBox txtLayerSpots;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtLayerMaxMW;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox txtLayerMaxMU;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ToolStripMenuItem splitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtLayerMinMU;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtLayerMinMW;
        private System.Windows.Forms.Label label26;
        private OxyPlot.WindowsForms.PlotView plotViewHistogram;
        private OxyPlot.WindowsForms.PlotView plotView1;
    }
}

