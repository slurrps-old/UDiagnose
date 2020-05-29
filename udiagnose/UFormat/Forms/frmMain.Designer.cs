namespace UDiagnose
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Operating System");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("CPU");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Motherboard");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("BIOS");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("RAM");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("GPU");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Hardware Information", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstDrives = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.rtbDriveInfo = new System.Windows.Forms.RichTextBox();
            this.progHardDrive = new System.Windows.Forms.ProgressBar();
            this.lblDrivePercentage = new System.Windows.Forms.Label();
            this.lblDriveInfo = new System.Windows.Forms.Label();
            this.lblDriveList = new System.Windows.Forms.Label();
            this.treeHardwareInfo = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblGPUUtilization = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblHandles = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblThreads = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDriveUtilization = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRAMUtilization = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCPUUtilization = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSystemUpTime = new System.Windows.Forms.Label();
            this.lblSystem = new System.Windows.Forms.Label();
            this.chartCPURAM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.pCPUCounter = new System.Diagnostics.PerformanceCounter();
            this.pRAMCounter = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.grpHardwareInfo = new System.Windows.Forms.GroupBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.DriveandHardware = new ComponentFactory.Krypton.Docking.KryptonDockableNavigator();
            this.pgDrives = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pgHardwareInfo = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pgSystemLoad = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pgSystemTemp = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.label4 = new System.Windows.Forms.Label();
            this.progMoboTemp = new MetroFramework.Controls.MetroProgressSpinner();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGPUTemp = new System.Windows.Forms.Label();
            this.lblCPUTemp = new System.Windows.Forms.Label();
            this.progGPUTemp = new MetroFramework.Controls.MetroProgressSpinner();
            this.progCPUTemp = new MetroFramework.Controls.MetroProgressSpinner();
            this.lblGetGPUTemp = new System.Windows.Forms.Label();
            this.lblGetCPUTemp = new System.Windows.Forms.Label();
            this.btnGetDriveInfo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.uDiagnoseRibbon = new ComponentFactory.Krypton.Ribbon.KryptonRibbon();
            this.kryptonRibbonTab1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.btnSaveInfo = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnExit = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonTab5 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonTab2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup4 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupLines3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLines();
            this.btnDiskPart = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnCMD = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnRegedit = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnEventView = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonTab4 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonTab3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupLines1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLines();
            this.btnErrorCodeDesc = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupLines2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLines();
            this.kryptonRibbonGroupLabel1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLabel();
            this.cmbWebsites = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupComboBox();
            this.btnGo = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup5 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.kryptonRibbonGroupButton1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupButton2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupButton3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonTab6 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.ToolTipUDiagnose = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.lblGPUInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPURAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPUCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAMCounter)).BeginInit();
            this.grpHardwareInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DriveandHardware)).BeginInit();
            this.DriveandHardware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgDrives)).BeginInit();
            this.pgDrives.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgHardwareInfo)).BeginInit();
            this.pgHardwareInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgSystemLoad)).BeginInit();
            this.pgSystemLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgSystemTemp)).BeginInit();
            this.pgSystemTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uDiagnoseRibbon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lstDrives);
            this.groupBox1.Controls.Add(this.rtbDriveInfo);
            this.groupBox1.Controls.Add(this.progHardDrive);
            this.groupBox1.Controls.Add(this.lblDrivePercentage);
            this.groupBox1.Controls.Add(this.lblDriveInfo);
            this.groupBox1.Controls.Add(this.lblDriveList);
            this.groupBox1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 365);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drive Information";
            // 
            // lstDrives
            // 
            this.lstDrives.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderForm;
            this.lstDrives.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.HeaderForm;
            this.lstDrives.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.lstDrives.Location = new System.Drawing.Point(17, 62);
            this.lstDrives.Name = "lstDrives";
            this.lstDrives.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.lstDrives.Size = new System.Drawing.Size(199, 264);
            this.lstDrives.StateNormal.Item.Content.LongText.Color1 = System.Drawing.Color.White;
            this.lstDrives.StateNormal.Item.Content.LongText.Color2 = System.Drawing.Color.White;
            this.lstDrives.StateNormal.Item.Content.LongText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lstDrives.TabIndex = 13;
            this.lstDrives.SelectedIndexChanged += new System.EventHandler(this.lstDrives_SelectedIndexChanged);
            // 
            // rtbDriveInfo
            // 
            this.rtbDriveInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtbDriveInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDriveInfo.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDriveInfo.ForeColor = System.Drawing.Color.White;
            this.rtbDriveInfo.Location = new System.Drawing.Point(236, 67);
            this.rtbDriveInfo.Name = "rtbDriveInfo";
            this.rtbDriveInfo.ReadOnly = true;
            this.rtbDriveInfo.Size = new System.Drawing.Size(263, 198);
            this.rtbDriveInfo.TabIndex = 8;
            this.rtbDriveInfo.Text = "";
            // 
            // progHardDrive
            // 
            this.progHardDrive.Location = new System.Drawing.Point(236, 309);
            this.progHardDrive.Name = "progHardDrive";
            this.progHardDrive.Size = new System.Drawing.Size(270, 35);
            this.progHardDrive.TabIndex = 7;
            // 
            // lblDrivePercentage
            // 
            this.lblDrivePercentage.AutoSize = true;
            this.lblDrivePercentage.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrivePercentage.Location = new System.Drawing.Point(242, 277);
            this.lblDrivePercentage.Name = "lblDrivePercentage";
            this.lblDrivePercentage.Size = new System.Drawing.Size(0, 19);
            this.lblDrivePercentage.TabIndex = 6;
            // 
            // lblDriveInfo
            // 
            this.lblDriveInfo.AutoSize = true;
            this.lblDriveInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblDriveInfo.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriveInfo.ForeColor = System.Drawing.Color.White;
            this.lblDriveInfo.Location = new System.Drawing.Point(242, 33);
            this.lblDriveInfo.Name = "lblDriveInfo";
            this.lblDriveInfo.Size = new System.Drawing.Size(101, 19);
            this.lblDriveInfo.TabIndex = 6;
            this.lblDriveInfo.Text = "Information";
            // 
            // lblDriveList
            // 
            this.lblDriveList.AutoSize = true;
            this.lblDriveList.BackColor = System.Drawing.Color.Transparent;
            this.lblDriveList.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriveList.ForeColor = System.Drawing.Color.White;
            this.lblDriveList.Location = new System.Drawing.Point(25, 33);
            this.lblDriveList.Name = "lblDriveList";
            this.lblDriveList.Size = new System.Drawing.Size(107, 19);
            this.lblDriveList.TabIndex = 6;
            this.lblDriveList.Text = "List of Drives";
            // 
            // treeHardwareInfo
            // 
            this.treeHardwareInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeHardwareInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeHardwareInfo.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeHardwareInfo.ForeColor = System.Drawing.Color.White;
            this.treeHardwareInfo.Location = new System.Drawing.Point(15, 32);
            this.treeHardwareInfo.Name = "treeHardwareInfo";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Operating System";
            treeNode2.Name = "Node2";
            treeNode2.Text = "CPU";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Motherboard";
            treeNode4.Name = "Node4";
            treeNode4.Text = "BIOS";
            treeNode5.Name = "Node5";
            treeNode5.Text = "RAM";
            treeNode6.Name = "Node6";
            treeNode6.Text = "GPU";
            treeNode7.Name = "Node0";
            treeNode7.Text = "Hardware Information";
            this.treeHardwareInfo.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.treeHardwareInfo.Size = new System.Drawing.Size(521, 654);
            this.treeHardwareInfo.TabIndex = 7;
            this.ToolTipUDiagnose.SetToolTip(this.treeHardwareInfo, "Here is displayed all of the current hardware in your system.");
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblGPUInfo);
            this.groupBox2.Controls.Add(this.lblGPUUtilization);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblHandles);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblThreads);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblFrequency);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblDriveUtilization);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblRAMUtilization);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblCPUUtilization);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblSystemUpTime);
            this.groupBox2.Controls.Add(this.lblSystem);
            this.groupBox2.Controls.Add(this.chartCPURAM);
            this.groupBox2.Controls.Add(this.lblRAM);
            this.groupBox2.Controls.Add(this.lblCPU);
            this.groupBox2.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(11, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 623);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System Loads";
            // 
            // lblGPUUtilization
            // 
            this.lblGPUUtilization.AutoSize = true;
            this.lblGPUUtilization.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUUtilization.Location = new System.Drawing.Point(183, 515);
            this.lblGPUUtilization.Name = "lblGPUUtilization";
            this.lblGPUUtilization.Size = new System.Drawing.Size(19, 17);
            this.lblGPUUtilization.TabIndex = 20;
            this.lblGPUUtilization.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(61, 514);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "GPU Utilization";
            // 
            // lblHandles
            // 
            this.lblHandles.AutoSize = true;
            this.lblHandles.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandles.Location = new System.Drawing.Point(363, 479);
            this.lblHandles.Name = "lblHandles";
            this.lblHandles.Size = new System.Drawing.Size(18, 17);
            this.lblHandles.TabIndex = 18;
            this.lblHandles.Text = "--";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(255, 477);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 19);
            this.label11.TabIndex = 19;
            this.label11.Text = "CPU Handles:";
            // 
            // lblThreads
            // 
            this.lblThreads.AutoSize = true;
            this.lblThreads.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreads.Location = new System.Drawing.Point(362, 443);
            this.lblThreads.Name = "lblThreads";
            this.lblThreads.Size = new System.Drawing.Size(18, 17);
            this.lblThreads.TabIndex = 16;
            this.lblThreads.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(255, 441);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "CPU Threads:";
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrequency.Location = new System.Drawing.Point(350, 407);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(33, 17);
            this.lblFrequency.TabIndex = 14;
            this.lblFrequency.Text = "GHz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(255, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "CPU Speed:";
            // 
            // lblDriveUtilization
            // 
            this.lblDriveUtilization.AutoSize = true;
            this.lblDriveUtilization.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriveUtilization.Location = new System.Drawing.Point(183, 479);
            this.lblDriveUtilization.Name = "lblDriveUtilization";
            this.lblDriveUtilization.Size = new System.Drawing.Size(19, 17);
            this.lblDriveUtilization.TabIndex = 12;
            this.lblDriveUtilization.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(62, 478);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Drive Utilization";
            // 
            // lblRAMUtilization
            // 
            this.lblRAMUtilization.AutoSize = true;
            this.lblRAMUtilization.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAMUtilization.Location = new System.Drawing.Point(183, 442);
            this.lblRAMUtilization.Name = "lblRAMUtilization";
            this.lblRAMUtilization.Size = new System.Drawing.Size(19, 17);
            this.lblRAMUtilization.TabIndex = 10;
            this.lblRAMUtilization.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ram Utilization";
            // 
            // lblCPUUtilization
            // 
            this.lblCPUUtilization.AutoSize = true;
            this.lblCPUUtilization.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUUtilization.Location = new System.Drawing.Point(183, 407);
            this.lblCPUUtilization.Name = "lblCPUUtilization";
            this.lblCPUUtilization.Size = new System.Drawing.Size(19, 17);
            this.lblCPUUtilization.TabIndex = 9;
            this.lblCPUUtilization.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "CPU Utilization:";
            // 
            // lblSystemUpTime
            // 
            this.lblSystemUpTime.AutoSize = true;
            this.lblSystemUpTime.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemUpTime.Location = new System.Drawing.Point(156, 586);
            this.lblSystemUpTime.Name = "lblSystemUpTime";
            this.lblSystemUpTime.Size = new System.Drawing.Size(21, 19);
            this.lblSystemUpTime.TabIndex = 9;
            this.lblSystemUpTime.Text = "--";
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystem.Location = new System.Drawing.Point(25, 586);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(125, 19);
            this.lblSystem.TabIndex = 9;
            this.lblSystem.Text = "System Up Time:";
            // 
            // chartCPURAM
            // 
            this.chartCPURAM.BackColor = System.Drawing.Color.Transparent;
            this.chartCPURAM.BorderSkin.BackColor = System.Drawing.Color.White;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.Title = "Time in Seconds";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.Title = "System Utilization";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.White;
            this.chartCPURAM.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartCPURAM.Legends.Add(legend1);
            this.chartCPURAM.Location = new System.Drawing.Point(10, 138);
            this.chartCPURAM.Name = "chartCPURAM";
            this.chartCPURAM.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartCPURAM.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Aqua,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.LawnGreen};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.EmptyPointStyle.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Drive";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "GPU";
            this.chartCPURAM.Series.Add(series1);
            this.chartCPURAM.Series.Add(series2);
            this.chartCPURAM.Series.Add(series3);
            this.chartCPURAM.Series.Add(series4);
            this.chartCPURAM.Size = new System.Drawing.Size(684, 276);
            this.chartCPURAM.TabIndex = 8;
            this.chartCPURAM.Text = "Usage Chart";
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "System Loads";
            this.chartCPURAM.Titles.Add(title1);
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.Location = new System.Drawing.Point(26, 62);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(80, 19);
            this.lblRAM.TabIndex = 6;
            this.lblRAM.Text = "RAM Info";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.Location = new System.Drawing.Point(25, 35);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(76, 19);
            this.lblCPU.TabIndex = 6;
            this.lblCPU.Text = "CPU Info";
            // 
            // pCPUCounter
            // 
            this.pCPUCounter.CategoryName = "Processor";
            this.pCPUCounter.CounterName = "% Processor Time";
            this.pCPUCounter.InstanceName = "_Total";
            // 
            // pRAMCounter
            // 
            this.pRAMCounter.CategoryName = "Memory";
            this.pRAMCounter.CounterName = "% Committed Bytes In Use";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // grpHardwareInfo
            // 
            this.grpHardwareInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpHardwareInfo.Controls.Add(this.treeHardwareInfo);
            this.grpHardwareInfo.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpHardwareInfo.ForeColor = System.Drawing.Color.White;
            this.grpHardwareInfo.Location = new System.Drawing.Point(25, 9);
            this.grpHardwareInfo.Name = "grpHardwareInfo";
            this.grpHardwareInfo.Size = new System.Drawing.Size(548, 698);
            this.grpHardwareInfo.TabIndex = 10;
            this.grpHardwareInfo.TabStop = false;
            this.grpHardwareInfo.Text = "Hardware Specs";
            // 
            // DriveandHardware
            // 
            this.DriveandHardware.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DriveandHardware.Bar.ItemOrientation = ComponentFactory.Krypton.Toolkit.ButtonOrientation.FixedTop;
            this.DriveandHardware.Bar.ItemSizing = ComponentFactory.Krypton.Navigator.BarItemSizing.SameWidthAndHeight;
            this.DriveandHardware.Bar.TabBorderStyle = ComponentFactory.Krypton.Toolkit.TabBorderStyle.OneNote;
            this.DriveandHardware.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.DriveandHardware.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.DriveandHardware.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DriveandHardware.Group.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderForm;
            this.DriveandHardware.Group.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.HeaderPrimary;
            this.DriveandHardware.Header.HeaderPositionBar = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left;
            this.DriveandHardware.Header.HeaderStyleBar = ComponentFactory.Krypton.Toolkit.HeaderStyle.Form;
            this.DriveandHardware.Location = new System.Drawing.Point(0, 0);
            this.DriveandHardware.Name = "DriveandHardware";
            this.DriveandHardware.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.HeaderBarCheckButtonGroup;
            this.DriveandHardware.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.DriveandHardware.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.pgDrives,
            this.pgHardwareInfo,
            this.pgSystemLoad,
            this.pgSystemTemp});
            this.DriveandHardware.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.DriveandHardware.SelectedIndex = 0;
            this.DriveandHardware.Size = new System.Drawing.Size(896, 715);
            this.DriveandHardware.TabIndex = 12;
            this.DriveandHardware.Text = "kryptonDockableNavigator1";
            // 
            // pgDrives
            // 
            this.pgDrives.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pgDrives.AutoScroll = true;
            this.pgDrives.Controls.Add(this.kryptonGroupBox1);
            this.pgDrives.Controls.Add(this.label2);
            this.pgDrives.Controls.Add(this.groupBox1);
            this.pgDrives.Flags = 65534;
            this.pgDrives.LastVisibleSet = true;
            this.pgDrives.MinimumSize = new System.Drawing.Size(50, 50);
            this.pgDrives.Name = "pgDrives";
            this.pgDrives.Size = new System.Drawing.Size(732, 713);
            this.pgDrives.Text = "Drive Information";
            this.pgDrives.ToolTipTitle = "Page ToolTip";
            this.pgDrives.UniqueName = "0E0C8E0A832345B073A5BFCB901374AF";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionEdge = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom;
            this.kryptonGroupBox1.CaptionOverlap = 0D;
            this.kryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.kryptonGroupBox1.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.HeaderPrimary;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(12, 482);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            this.kryptonGroupBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonButton1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonButton2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonButton3);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(327, 213);
            this.kryptonGroupBox1.TabIndex = 12;
            this.kryptonGroupBox1.Values.Heading = "Test Features not yet available";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(13, 27);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonButton1.Size = new System.Drawing.Size(155, 34);
            this.kryptonButton1.TabIndex = 9;
            this.kryptonButton1.Values.Text = "Format Drive";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(12, 125);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonButton2.Size = new System.Drawing.Size(156, 34);
            this.kryptonButton2.TabIndex = 10;
            this.kryptonButton2.Values.Text = "Assess Drive Performance";
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(12, 76);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonButton3.Size = new System.Drawing.Size(156, 34);
            this.kryptonButton3.TabIndex = 11;
            this.kryptonButton3.Values.Text = "Clean Drive";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(523, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Please select a drive to view its information";
            // 
            // pgHardwareInfo
            // 
            this.pgHardwareInfo.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pgHardwareInfo.AutoScroll = true;
            this.pgHardwareInfo.Controls.Add(this.grpHardwareInfo);
            this.pgHardwareInfo.Flags = 65534;
            this.pgHardwareInfo.LastVisibleSet = true;
            this.pgHardwareInfo.MinimumSize = new System.Drawing.Size(50, 50);
            this.pgHardwareInfo.Name = "pgHardwareInfo";
            this.pgHardwareInfo.Size = new System.Drawing.Size(732, 713);
            this.pgHardwareInfo.Text = "Hardware Information";
            this.pgHardwareInfo.ToolTipTitle = "Page ToolTip";
            this.pgHardwareInfo.UniqueName = "0624E6BFA1794EE8C288E0B74C38C0B1";
            // 
            // pgSystemLoad
            // 
            this.pgSystemLoad.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pgSystemLoad.AutoScroll = true;
            this.pgSystemLoad.Controls.Add(this.groupBox2);
            this.pgSystemLoad.Flags = 65534;
            this.pgSystemLoad.LastVisibleSet = true;
            this.pgSystemLoad.MinimumSize = new System.Drawing.Size(50, 50);
            this.pgSystemLoad.Name = "pgSystemLoad";
            this.pgSystemLoad.Size = new System.Drawing.Size(732, 713);
            this.pgSystemLoad.Text = "System Load Information";
            this.pgSystemLoad.ToolTipTitle = "Page ToolTip";
            this.pgSystemLoad.UniqueName = "8B90722461304B7090A540F28F5BAE4E";
            // 
            // pgSystemTemp
            // 
            this.pgSystemTemp.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pgSystemTemp.AutoScroll = true;
            this.pgSystemTemp.Controls.Add(this.label4);
            this.pgSystemTemp.Controls.Add(this.progMoboTemp);
            this.pgSystemTemp.Controls.Add(this.label5);
            this.pgSystemTemp.Controls.Add(this.lblGPUTemp);
            this.pgSystemTemp.Controls.Add(this.lblCPUTemp);
            this.pgSystemTemp.Controls.Add(this.progGPUTemp);
            this.pgSystemTemp.Controls.Add(this.progCPUTemp);
            this.pgSystemTemp.Controls.Add(this.lblGetGPUTemp);
            this.pgSystemTemp.Controls.Add(this.lblGetCPUTemp);
            this.pgSystemTemp.Flags = 65534;
            this.pgSystemTemp.LastVisibleSet = true;
            this.pgSystemTemp.MinimumSize = new System.Drawing.Size(50, 50);
            this.pgSystemTemp.Name = "pgSystemTemp";
            this.pgSystemTemp.Size = new System.Drawing.Size(732, 713);
            this.pgSystemTemp.Text = "System Temperatures";
            this.pgSystemTemp.ToolTipTitle = "Page ToolTip";
            this.pgSystemTemp.UniqueName = "9CAC71B5A8DD4B3D24B75C4949832D73";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(385, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Mobo";
            // 
            // progMoboTemp
            // 
            this.progMoboTemp.BackColor = System.Drawing.Color.Black;
            this.progMoboTemp.Location = new System.Drawing.Point(349, 71);
            this.progMoboTemp.Maximum = 100;
            this.progMoboTemp.Name = "progMoboTemp";
            this.progMoboTemp.Size = new System.Drawing.Size(130, 130);
            this.progMoboTemp.Spinning = false;
            this.progMoboTemp.TabIndex = 30;
            this.progMoboTemp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.progMoboTemp.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(373, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Mobo Temp";
            // 
            // lblGPUTemp
            // 
            this.lblGPUTemp.AutoSize = true;
            this.lblGPUTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblGPUTemp.ForeColor = System.Drawing.Color.White;
            this.lblGPUTemp.Location = new System.Drawing.Point(228, 121);
            this.lblGPUTemp.Name = "lblGPUTemp";
            this.lblGPUTemp.Size = new System.Drawing.Size(33, 16);
            this.lblGPUTemp.TabIndex = 27;
            this.lblGPUTemp.Text = "GPU";
            // 
            // lblCPUTemp
            // 
            this.lblCPUTemp.AutoSize = true;
            this.lblCPUTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblCPUTemp.ForeColor = System.Drawing.Color.White;
            this.lblCPUTemp.Location = new System.Drawing.Point(73, 123);
            this.lblCPUTemp.Name = "lblCPUTemp";
            this.lblCPUTemp.Size = new System.Drawing.Size(32, 16);
            this.lblCPUTemp.TabIndex = 28;
            this.lblCPUTemp.Text = "CPU";
            // 
            // progGPUTemp
            // 
            this.progGPUTemp.BackColor = System.Drawing.Color.Black;
            this.progGPUTemp.Location = new System.Drawing.Point(192, 73);
            this.progGPUTemp.Maximum = 100;
            this.progGPUTemp.Name = "progGPUTemp";
            this.progGPUTemp.Size = new System.Drawing.Size(130, 130);
            this.progGPUTemp.Spinning = false;
            this.progGPUTemp.TabIndex = 25;
            this.progGPUTemp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.progGPUTemp.UseSelectable = true;
            // 
            // progCPUTemp
            // 
            this.progCPUTemp.BackColor = System.Drawing.Color.Black;
            this.progCPUTemp.Location = new System.Drawing.Point(37, 73);
            this.progCPUTemp.Maximum = 100;
            this.progCPUTemp.Name = "progCPUTemp";
            this.progCPUTemp.Size = new System.Drawing.Size(130, 130);
            this.progCPUTemp.Spinning = false;
            this.progCPUTemp.TabIndex = 26;
            this.progCPUTemp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.progCPUTemp.UseSelectable = true;
            // 
            // lblGetGPUTemp
            // 
            this.lblGetGPUTemp.AutoSize = true;
            this.lblGetGPUTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblGetGPUTemp.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetGPUTemp.ForeColor = System.Drawing.Color.White;
            this.lblGetGPUTemp.Location = new System.Drawing.Point(216, 44);
            this.lblGetGPUTemp.Name = "lblGetGPUTemp";
            this.lblGetGPUTemp.Size = new System.Drawing.Size(89, 19);
            this.lblGetGPUTemp.TabIndex = 23;
            this.lblGetGPUTemp.Text = "GPU Temp";
            // 
            // lblGetCPUTemp
            // 
            this.lblGetCPUTemp.AutoSize = true;
            this.lblGetCPUTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblGetCPUTemp.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetCPUTemp.ForeColor = System.Drawing.Color.White;
            this.lblGetCPUTemp.Location = new System.Drawing.Point(60, 44);
            this.lblGetCPUTemp.Name = "lblGetCPUTemp";
            this.lblGetCPUTemp.Size = new System.Drawing.Size(88, 19);
            this.lblGetCPUTemp.TabIndex = 24;
            this.lblGetCPUTemp.Text = "CPU Temp";
            // 
            // btnGetDriveInfo
            // 
            this.btnGetDriveInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGetDriveInfo.Location = new System.Drawing.Point(0, 115);
            this.btnGetDriveInfo.Name = "btnGetDriveInfo";
            this.btnGetDriveInfo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.btnGetDriveInfo.Size = new System.Drawing.Size(896, 47);
            this.btnGetDriveInfo.TabIndex = 14;
            this.btnGetDriveInfo.Values.Text = "Reload Drive Information";
            this.btnGetDriveInfo.Click += new System.EventHandler(this.btnGetDriveInfo_Click);
            // 
            // uDiagnoseRibbon
            // 
            this.uDiagnoseRibbon.InDesignHelperMode = true;
            this.uDiagnoseRibbon.Name = "uDiagnoseRibbon";
            this.uDiagnoseRibbon.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.uDiagnoseRibbon.RibbonAppButton.AppButtonImage = global::UDiagnose.Properties.Resources.UDiagnose64v2px;
            this.uDiagnoseRibbon.RibbonAppButton.AppButtonTextColor = System.Drawing.Color.Transparent;
            this.uDiagnoseRibbon.RibbonTabs.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab[] {
            this.kryptonRibbonTab1,
            this.kryptonRibbonTab5,
            this.kryptonRibbonTab2,
            this.kryptonRibbonTab4,
            this.kryptonRibbonTab3,
            this.kryptonRibbonTab6});
            this.uDiagnoseRibbon.SelectedContext = null;
            this.uDiagnoseRibbon.SelectedTab = this.kryptonRibbonTab1;
            this.uDiagnoseRibbon.Size = new System.Drawing.Size(896, 115);
            this.uDiagnoseRibbon.TabIndex = 15;
            // 
            // kryptonRibbonTab1
            // 
            this.kryptonRibbonTab1.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup1});
            this.kryptonRibbonTab1.Text = "File";
            // 
            // kryptonRibbonGroup1
            // 
            this.kryptonRibbonGroup1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple1});
            this.kryptonRibbonGroup1.TextLine1 = "Save";
            // 
            // kryptonRibbonGroupTriple1
            // 
            this.kryptonRibbonGroupTriple1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.btnSaveInfo,
            this.btnExit});
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.TextLine1 = "Save Hardware Info";
            this.btnSaveInfo.Click += new System.EventHandler(this.saveAstxtToolStripMenuItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.TextLine1 = "Exit";
            this.btnExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // kryptonRibbonTab5
            // 
            this.kryptonRibbonTab5.Text = "View";
            // 
            // kryptonRibbonTab2
            // 
            this.kryptonRibbonTab2.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup4});
            this.kryptonRibbonTab2.Text = "Tools";
            // 
            // kryptonRibbonGroup4
            // 
            this.kryptonRibbonGroup4.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupLines3});
            this.kryptonRibbonGroup4.TextLine1 = "Windows Tools";
            // 
            // kryptonRibbonGroupLines3
            // 
            this.kryptonRibbonGroupLines3.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.btnDiskPart,
            this.btnCMD,
            this.btnRegedit,
            this.btnEventView});
            // 
            // btnDiskPart
            // 
            this.btnDiskPart.TextLine1 = "Disk Partition";
            this.btnDiskPart.Click += new System.EventHandler(this.diskPartitionToolStripMenuItem_Click);
            // 
            // btnCMD
            // 
            this.btnCMD.TextLine1 = "CMD";
            this.btnCMD.Click += new System.EventHandler(this.cMDToolStripMenuItem_Click);
            // 
            // btnRegedit
            // 
            this.btnRegedit.TextLine1 = "Regedit";
            this.btnRegedit.Click += new System.EventHandler(this.regEditToolStripMenuItem_Click);
            // 
            // btnEventView
            // 
            this.btnEventView.TextLine1 = "Event Viewer";
            this.btnEventView.Click += new System.EventHandler(this.eventViewerToolStripMenuItem_Click);
            // 
            // kryptonRibbonTab4
            // 
            this.kryptonRibbonTab4.Text = "Options";
            // 
            // kryptonRibbonTab3
            // 
            this.kryptonRibbonTab3.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup2,
            this.kryptonRibbonGroup3,
            this.kryptonRibbonGroup5});
            this.kryptonRibbonTab3.Text = "Help";
            // 
            // kryptonRibbonGroup2
            // 
            this.kryptonRibbonGroup2.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupLines1});
            this.kryptonRibbonGroup2.TextLine1 = "Error Codes";
            // 
            // kryptonRibbonGroupLines1
            // 
            this.kryptonRibbonGroupLines1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.btnErrorCodeDesc});
            // 
            // btnErrorCodeDesc
            // 
            this.btnErrorCodeDesc.TextLine1 = "Error Code Descriptions";
            this.btnErrorCodeDesc.Click += new System.EventHandler(this.errorCodeDescriptionsToolStripMenuItem_Click);
            // 
            // kryptonRibbonGroup3
            // 
            this.kryptonRibbonGroup3.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupLines2});
            this.kryptonRibbonGroup3.TextLine1 = "Useful Websites";
            // 
            // kryptonRibbonGroupLines2
            // 
            this.kryptonRibbonGroupLines2.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.kryptonRibbonGroupLabel1,
            this.cmbWebsites,
            this.btnGo});
            // 
            // kryptonRibbonGroupLabel1
            // 
            this.kryptonRibbonGroupLabel1.TextLine1 = "Please choose a website";
            // 
            // cmbWebsites
            // 
            this.cmbWebsites.DropDownWidth = 121;
            this.cmbWebsites.FormattingEnabled = false;
            this.cmbWebsites.ItemHeight = 15;
            this.cmbWebsites.Items.AddRange(new object[] {
            "Stack Overflow",
            "Code Project",
            "Toms Hardware"});
            this.cmbWebsites.Text = "";
            // 
            // btnGo
            // 
            this.btnGo.TextLine1 = "Go";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // kryptonRibbonGroup5
            // 
            this.kryptonRibbonGroup5.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple2});
            this.kryptonRibbonGroup5.TextLine1 = "Information";
            // 
            // kryptonRibbonGroupTriple2
            // 
            this.kryptonRibbonGroupTriple2.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.kryptonRibbonGroupButton1,
            this.kryptonRibbonGroupButton2,
            this.kryptonRibbonGroupButton3});
            // 
            // kryptonRibbonGroupButton1
            // 
            this.kryptonRibbonGroupButton1.TextLine1 = "About";
            this.kryptonRibbonGroupButton1.Click += new System.EventHandler(this.kryptonRibbonGroupButton1_Click);
            // 
            // kryptonRibbonGroupButton2
            // 
            this.kryptonRibbonGroupButton2.TextLine1 = "License";
            // 
            // kryptonRibbonGroupButton3
            // 
            this.kryptonRibbonGroupButton3.TextLine1 = "Feature List";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.DriveandHardware);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 715);
            this.panel1.TabIndex = 16;
            // 
            // lblGPUInfo
            // 
            this.lblGPUInfo.AutoSize = true;
            this.lblGPUInfo.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUInfo.Location = new System.Drawing.Point(26, 88);
            this.lblGPUInfo.Name = "lblGPUInfo";
            this.lblGPUInfo.Size = new System.Drawing.Size(92, 19);
            this.lblGPUInfo.TabIndex = 22;
            this.lblGPUInfo.Text = "GPU Name";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(896, 877);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGetDriveInfo);
            this.Controls.Add(this.uDiagnoseRibbon);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UDiagnose";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPURAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPUCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAMCounter)).EndInit();
            this.grpHardwareInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DriveandHardware)).EndInit();
            this.DriveandHardware.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pgDrives)).EndInit();
            this.pgDrives.ResumeLayout(false);
            this.pgDrives.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pgHardwareInfo)).EndInit();
            this.pgHardwareInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pgSystemLoad)).EndInit();
            this.pgSystemLoad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pgSystemTemp)).EndInit();
            this.pgSystemTemp.ResumeLayout(false);
            this.pgSystemTemp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uDiagnoseRibbon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbDriveInfo;
        private System.Windows.Forms.ProgressBar progHardDrive;
        private System.Windows.Forms.Label lblDrivePercentage;
        private System.Windows.Forms.Label lblDriveInfo;
        private System.Windows.Forms.Label lblDriveList;
        public System.Windows.Forms.TreeView treeHardwareInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblCPU;
        private System.Diagnostics.PerformanceCounter pCPUCounter;
        private System.Diagnostics.PerformanceCounter pRAMCounter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCPURAM;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox grpHardwareInfo;
        public System.Windows.Forms.Timer timer1;
        private ComponentFactory.Krypton.Docking.KryptonDockableNavigator DriveandHardware;
        private ComponentFactory.Krypton.Navigator.KryptonPage pgDrives;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnGetDriveInfo;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbon uDiagnoseRibbon;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton btnSaveInfo;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton btnExit;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab5;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab2;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup4;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLines kryptonRibbonGroupLines3;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton btnDiskPart;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton btnCMD;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton btnRegedit;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton btnEventView;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab4;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab3;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup2;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLines kryptonRibbonGroupLines1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton btnErrorCodeDesc;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup3;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLines kryptonRibbonGroupLines2;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLabel kryptonRibbonGroupLabel1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupComboBox cmbWebsites;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton btnGo;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup5;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple2;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton2;
        private ComponentFactory.Krypton.Navigator.KryptonPage pgSystemLoad;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.ToolTip ToolTipUDiagnose;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton3;
        private System.Windows.Forms.Label lblCPUUtilization;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSystemUpTime;
        private System.Windows.Forms.Label lblSystem;
        private ComponentFactory.Krypton.Navigator.KryptonPage pgSystemTemp;
        private System.Windows.Forms.Label lblGPUTemp;
        private System.Windows.Forms.Label lblCPUTemp;
        private MetroFramework.Controls.MetroProgressSpinner progGPUTemp;
        private MetroFramework.Controls.MetroProgressSpinner progCPUTemp;
        private System.Windows.Forms.Label lblGetGPUTemp;
        private System.Windows.Forms.Label lblGetCPUTemp;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox lstDrives;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroProgressSpinner progMoboTemp;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Navigator.KryptonPage pgHardwareInfo;
        private System.Windows.Forms.Label lblDriveUtilization;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblRAMUtilization;
        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab6;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHandles;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblThreads;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblGPUUtilization;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblGPUInfo;
    }
}

