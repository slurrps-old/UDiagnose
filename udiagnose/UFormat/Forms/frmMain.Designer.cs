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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstDrives = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.rtbDriveInfo = new System.Windows.Forms.RichTextBox();
            this.progHardDrive = new System.Windows.Forms.ProgressBar();
            this.lblDrivePercentage = new System.Windows.Forms.Label();
            this.lblDriveInfo = new System.Windows.Forms.Label();
            this.lblDriveList = new System.Windows.Forms.Label();
            this.treeHardwareInfo = new System.Windows.Forms.TreeView();
            this.pCPUCounter = new System.Diagnostics.PerformanceCounter();
            this.pRAMCounter = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.grpHardwareInfo = new System.Windows.Forms.GroupBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.DriveandHardware = new ComponentFactory.Krypton.Docking.KryptonDockableNavigator();
            this.pgDrives = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnFormatDrive = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pgHardwareInfo = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.pgSystemLoad = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonDockableNavigator1 = new ComponentFactory.Krypton.Docking.KryptonDockableNavigator();
            this.pgOverview = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCPUOverview = new System.Windows.Forms.Label();
            this.lblGPUInfo = new System.Windows.Forms.Label();
            this.lblGPUUtilization = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            this.pgCPU = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.lblCPUPageUpTime = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lblCPUPAgeUtil = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.lblL3Cache = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.lblL2Cache = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblCPUThreads = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.lblCPUCores = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.lblL1Cahce = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.lblBaseCPUSpeed = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblHandles = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblThreads = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chartCPU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pgGPU = new ComponentFactory.Krypton.Navigator.KryptonPage();
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
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableNavigator1)).BeginInit();
            this.kryptonDockableNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgOverview)).BeginInit();
            this.pgOverview.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPURAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgCPU)).BeginInit();
            this.pgCPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgGPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgSystemTemp)).BeginInit();
            this.pgSystemTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uDiagnoseRibbon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.DriveandHardware.Size = new System.Drawing.Size(909, 715);
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
            this.pgDrives.Size = new System.Drawing.Size(745, 713);
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
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnFormatDrive);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonButton2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonButton3);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(327, 213);
            this.kryptonGroupBox1.TabIndex = 12;
            this.kryptonGroupBox1.Values.Heading = "Test Features not yet available";
            // 
            // btnFormatDrive
            // 
            this.btnFormatDrive.Location = new System.Drawing.Point(13, 27);
            this.btnFormatDrive.Name = "btnFormatDrive";
            this.btnFormatDrive.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.btnFormatDrive.Size = new System.Drawing.Size(155, 34);
            this.btnFormatDrive.TabIndex = 9;
            this.btnFormatDrive.Values.Text = "Format Drive";
            this.btnFormatDrive.Click += new System.EventHandler(this.kryptonButton1_Click);
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
            this.pgHardwareInfo.Size = new System.Drawing.Size(745, 713);
            this.pgHardwareInfo.Text = "Hardware Information";
            this.pgHardwareInfo.ToolTipTitle = "Page ToolTip";
            this.pgHardwareInfo.UniqueName = "0624E6BFA1794EE8C288E0B74C38C0B1";
            // 
            // pgSystemLoad
            // 
            this.pgSystemLoad.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pgSystemLoad.AutoScroll = true;
            this.pgSystemLoad.Controls.Add(this.kryptonDockableNavigator1);
            this.pgSystemLoad.Flags = 65534;
            this.pgSystemLoad.LastVisibleSet = true;
            this.pgSystemLoad.MinimumSize = new System.Drawing.Size(50, 50);
            this.pgSystemLoad.Name = "pgSystemLoad";
            this.pgSystemLoad.Size = new System.Drawing.Size(745, 713);
            this.pgSystemLoad.Text = "System Load Information";
            this.pgSystemLoad.ToolTipTitle = "Page ToolTip";
            this.pgSystemLoad.UniqueName = "8B90722461304B7090A540F28F5BAE4E";
            // 
            // kryptonDockableNavigator1
            // 
            this.kryptonDockableNavigator1.Bar.ItemSizing = ComponentFactory.Krypton.Navigator.BarItemSizing.SameWidthAndHeight;
            this.kryptonDockableNavigator1.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.kryptonDockableNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonDockableNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDockableNavigator1.Group.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderForm;
            this.kryptonDockableNavigator1.Group.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.HeaderPrimary;
            this.kryptonDockableNavigator1.Location = new System.Drawing.Point(0, 0);
            this.kryptonDockableNavigator1.Name = "kryptonDockableNavigator1";
            this.kryptonDockableNavigator1.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.HeaderBarCheckButtonGroup;
            this.kryptonDockableNavigator1.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.kryptonDockableNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.pgOverview,
            this.pgCPU,
            this.pgGPU});
            this.kryptonDockableNavigator1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonDockableNavigator1.SelectedIndex = 1;
            this.kryptonDockableNavigator1.Size = new System.Drawing.Size(745, 713);
            this.kryptonDockableNavigator1.TabIndex = 9;
            this.kryptonDockableNavigator1.Text = "kryptonDockableNavigator1";
            // 
            // pgOverview
            // 
            this.pgOverview.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pgOverview.Controls.Add(this.groupBox2);
            this.pgOverview.Flags = 65534;
            this.pgOverview.LastVisibleSet = true;
            this.pgOverview.MinimumSize = new System.Drawing.Size(50, 50);
            this.pgOverview.Name = "pgOverview";
            this.pgOverview.Size = new System.Drawing.Size(743, 680);
            this.pgOverview.Text = "Overview";
            this.pgOverview.ToolTipTitle = "Page ToolTip";
            this.pgOverview.UniqueName = "34A892A6CC4B4C55F18C496F192F9936";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblCPUOverview);
            this.groupBox2.Controls.Add(this.lblGPUInfo);
            this.groupBox2.Controls.Add(this.lblGPUUtilization);
            this.groupBox2.Controls.Add(this.label10);
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
            this.groupBox2.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(20, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 623);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System Loads";
            // 
            // lblCPUOverview
            // 
            this.lblCPUOverview.AutoSize = true;
            this.lblCPUOverview.BackColor = System.Drawing.Color.Transparent;
            this.lblCPUOverview.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUOverview.ForeColor = System.Drawing.Color.White;
            this.lblCPUOverview.Location = new System.Drawing.Point(26, 43);
            this.lblCPUOverview.Name = "lblCPUOverview";
            this.lblCPUOverview.Size = new System.Drawing.Size(76, 19);
            this.lblCPUOverview.TabIndex = 27;
            this.lblCPUOverview.Text = "CPU Info";
            // 
            // lblGPUInfo
            // 
            this.lblGPUInfo.AutoSize = true;
            this.lblGPUInfo.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUInfo.Location = new System.Drawing.Point(26, 101);
            this.lblGPUInfo.Name = "lblGPUInfo";
            this.lblGPUInfo.Size = new System.Drawing.Size(92, 19);
            this.lblGPUInfo.TabIndex = 22;
            this.lblGPUInfo.Text = "GPU Name";
            // 
            // lblGPUUtilization
            // 
            this.lblGPUUtilization.AutoSize = true;
            this.lblGPUUtilization.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUUtilization.Location = new System.Drawing.Point(541, 473);
            this.lblGPUUtilization.Name = "lblGPUUtilization";
            this.lblGPUUtilization.Size = new System.Drawing.Size(19, 17);
            this.lblGPUUtilization.TabIndex = 20;
            this.lblGPUUtilization.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(419, 472);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "GPU Utilization";
            // 
            // lblDriveUtilization
            // 
            this.lblDriveUtilization.AutoSize = true;
            this.lblDriveUtilization.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriveUtilization.Location = new System.Drawing.Point(541, 437);
            this.lblDriveUtilization.Name = "lblDriveUtilization";
            this.lblDriveUtilization.Size = new System.Drawing.Size(19, 17);
            this.lblDriveUtilization.TabIndex = 12;
            this.lblDriveUtilization.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(420, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Drive Utilization";
            // 
            // lblRAMUtilization
            // 
            this.lblRAMUtilization.AutoSize = true;
            this.lblRAMUtilization.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAMUtilization.Location = new System.Drawing.Point(193, 473);
            this.lblRAMUtilization.Name = "lblRAMUtilization";
            this.lblRAMUtilization.Size = new System.Drawing.Size(19, 17);
            this.lblRAMUtilization.TabIndex = 10;
            this.lblRAMUtilization.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ram Utilization";
            // 
            // lblCPUUtilization
            // 
            this.lblCPUUtilization.AutoSize = true;
            this.lblCPUUtilization.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUUtilization.Location = new System.Drawing.Point(193, 438);
            this.lblCPUUtilization.Name = "lblCPUUtilization";
            this.lblCPUUtilization.Size = new System.Drawing.Size(19, 17);
            this.lblCPUUtilization.TabIndex = 9;
            this.lblCPUUtilization.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "CPU Utilization:";
            // 
            // lblSystemUpTime
            // 
            this.lblSystemUpTime.AutoSize = true;
            this.lblSystemUpTime.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemUpTime.Location = new System.Drawing.Point(193, 554);
            this.lblSystemUpTime.Name = "lblSystemUpTime";
            this.lblSystemUpTime.Size = new System.Drawing.Size(21, 19);
            this.lblSystemUpTime.TabIndex = 9;
            this.lblSystemUpTime.Text = "--";
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystem.Location = new System.Drawing.Point(62, 554);
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
            chartArea1.AxisY.Title = "System Utilization %";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "Overview";
            chartArea1.ShadowColor = System.Drawing.Color.White;
            this.chartCPURAM.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartCPURAM.Legends.Add(legend1);
            this.chartCPURAM.Location = new System.Drawing.Point(10, 110);
            this.chartCPURAM.Name = "chartCPURAM";
            this.chartCPURAM.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartCPURAM.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Aqua,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.LawnGreen};
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.ChartArea = "Overview";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.EmptyPointStyle.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series2.ChartArea = "Overview";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series3.ChartArea = "Overview";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Legend = "Legend1";
            series3.Name = "Drive";
            series4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series4.ChartArea = "Overview";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series4.Legend = "Legend1";
            series4.Name = "GPU";
            this.chartCPURAM.Series.Add(series1);
            this.chartCPURAM.Series.Add(series2);
            this.chartCPURAM.Series.Add(series3);
            this.chartCPURAM.Series.Add(series4);
            this.chartCPURAM.Size = new System.Drawing.Size(684, 324);
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
            this.lblRAM.Location = new System.Drawing.Point(26, 72);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(80, 19);
            this.lblRAM.TabIndex = 6;
            this.lblRAM.Text = "RAM Info";
            // 
            // pgCPU
            // 
            this.pgCPU.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pgCPU.Controls.Add(this.lblCPUPageUpTime);
            this.pgCPU.Controls.Add(this.label38);
            this.pgCPU.Controls.Add(this.lblCPUPAgeUtil);
            this.pgCPU.Controls.Add(this.label35);
            this.pgCPU.Controls.Add(this.lblL3Cache);
            this.pgCPU.Controls.Add(this.label37);
            this.pgCPU.Controls.Add(this.lblL2Cache);
            this.pgCPU.Controls.Add(this.label33);
            this.pgCPU.Controls.Add(this.lblCPUThreads);
            this.pgCPU.Controls.Add(this.label32);
            this.pgCPU.Controls.Add(this.lblCPUCores);
            this.pgCPU.Controls.Add(this.label34);
            this.pgCPU.Controls.Add(this.lblL1Cahce);
            this.pgCPU.Controls.Add(this.label36);
            this.pgCPU.Controls.Add(this.lblBaseCPUSpeed);
            this.pgCPU.Controls.Add(this.label31);
            this.pgCPU.Controls.Add(this.lblCPU);
            this.pgCPU.Controls.Add(this.lblHandles);
            this.pgCPU.Controls.Add(this.label11);
            this.pgCPU.Controls.Add(this.lblThreads);
            this.pgCPU.Controls.Add(this.label8);
            this.pgCPU.Controls.Add(this.lblFrequency);
            this.pgCPU.Controls.Add(this.label6);
            this.pgCPU.Controls.Add(this.chartCPU);
            this.pgCPU.Flags = 65534;
            this.pgCPU.LastVisibleSet = true;
            this.pgCPU.MinimumSize = new System.Drawing.Size(50, 50);
            this.pgCPU.Name = "pgCPU";
            this.pgCPU.Size = new System.Drawing.Size(743, 680);
            this.pgCPU.Text = "CPU Details";
            this.pgCPU.ToolTipTitle = "Page ToolTip";
            this.pgCPU.UniqueName = "C3ABA6D2693646D01AA7D8E5CE815F85";
            // 
            // lblCPUPageUpTime
            // 
            this.lblCPUPageUpTime.AutoSize = true;
            this.lblCPUPageUpTime.BackColor = System.Drawing.Color.Transparent;
            this.lblCPUPageUpTime.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUPageUpTime.ForeColor = System.Drawing.Color.White;
            this.lblCPUPageUpTime.Location = new System.Drawing.Point(177, 635);
            this.lblCPUPageUpTime.Name = "lblCPUPageUpTime";
            this.lblCPUPageUpTime.Size = new System.Drawing.Size(21, 19);
            this.lblCPUPageUpTime.TabIndex = 41;
            this.lblCPUPageUpTime.Text = "--";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.White;
            this.label38.Location = new System.Drawing.Point(46, 635);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(125, 19);
            this.label38.TabIndex = 42;
            this.label38.Text = "System Up Time:";
            // 
            // lblCPUPAgeUtil
            // 
            this.lblCPUPAgeUtil.AutoSize = true;
            this.lblCPUPAgeUtil.BackColor = System.Drawing.Color.Transparent;
            this.lblCPUPAgeUtil.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUPAgeUtil.ForeColor = System.Drawing.Color.White;
            this.lblCPUPAgeUtil.Location = new System.Drawing.Point(168, 429);
            this.lblCPUPAgeUtil.Name = "lblCPUPAgeUtil";
            this.lblCPUPAgeUtil.Size = new System.Drawing.Size(19, 17);
            this.lblCPUPAgeUtil.TabIndex = 39;
            this.lblCPUPAgeUtil.Text = "%";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(46, 428);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(116, 19);
            this.label35.TabIndex = 40;
            this.label35.Text = "CPU Utilization:";
            // 
            // lblL3Cache
            // 
            this.lblL3Cache.AutoSize = true;
            this.lblL3Cache.BackColor = System.Drawing.Color.Transparent;
            this.lblL3Cache.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblL3Cache.ForeColor = System.Drawing.Color.White;
            this.lblL3Cache.Location = new System.Drawing.Point(572, 605);
            this.lblL3Cache.Name = "lblL3Cache";
            this.lblL3Cache.Size = new System.Drawing.Size(18, 17);
            this.lblL3Cache.TabIndex = 37;
            this.lblL3Cache.Text = "--";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(422, 603);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(75, 19);
            this.label37.TabIndex = 38;
            this.label37.Text = "L3 Cache:";
            // 
            // lblL2Cache
            // 
            this.lblL2Cache.AutoSize = true;
            this.lblL2Cache.BackColor = System.Drawing.Color.Transparent;
            this.lblL2Cache.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblL2Cache.ForeColor = System.Drawing.Color.White;
            this.lblL2Cache.Location = new System.Drawing.Point(572, 570);
            this.lblL2Cache.Name = "lblL2Cache";
            this.lblL2Cache.Size = new System.Drawing.Size(18, 17);
            this.lblL2Cache.TabIndex = 35;
            this.lblL2Cache.Text = "--";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(422, 568);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(75, 19);
            this.label33.TabIndex = 36;
            this.label33.Text = "L2 Cache:";
            // 
            // lblCPUThreads
            // 
            this.lblCPUThreads.AutoSize = true;
            this.lblCPUThreads.BackColor = System.Drawing.Color.Transparent;
            this.lblCPUThreads.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUThreads.ForeColor = System.Drawing.Color.White;
            this.lblCPUThreads.Location = new System.Drawing.Point(572, 500);
            this.lblCPUThreads.Name = "lblCPUThreads";
            this.lblCPUThreads.Size = new System.Drawing.Size(18, 17);
            this.lblCPUThreads.TabIndex = 33;
            this.lblCPUThreads.Text = "--";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(422, 498);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(140, 19);
            this.label32.TabIndex = 34;
            this.label32.Text = "Logical Processors:";
            // 
            // lblCPUCores
            // 
            this.lblCPUCores.AutoSize = true;
            this.lblCPUCores.BackColor = System.Drawing.Color.Transparent;
            this.lblCPUCores.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUCores.ForeColor = System.Drawing.Color.White;
            this.lblCPUCores.Location = new System.Drawing.Point(572, 465);
            this.lblCPUCores.Name = "lblCPUCores";
            this.lblCPUCores.Size = new System.Drawing.Size(18, 17);
            this.lblCPUCores.TabIndex = 31;
            this.lblCPUCores.Text = "--";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(422, 463);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(52, 19);
            this.label34.TabIndex = 32;
            this.label34.Text = "Cores:";
            // 
            // lblL1Cahce
            // 
            this.lblL1Cahce.AutoSize = true;
            this.lblL1Cahce.BackColor = System.Drawing.Color.Transparent;
            this.lblL1Cahce.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblL1Cahce.ForeColor = System.Drawing.Color.White;
            this.lblL1Cahce.Location = new System.Drawing.Point(572, 535);
            this.lblL1Cahce.Name = "lblL1Cahce";
            this.lblL1Cahce.Size = new System.Drawing.Size(18, 17);
            this.lblL1Cahce.TabIndex = 29;
            this.lblL1Cahce.Text = "--";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(422, 533);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(75, 19);
            this.label36.TabIndex = 30;
            this.label36.Text = "L1 Cache:";
            // 
            // lblBaseCPUSpeed
            // 
            this.lblBaseCPUSpeed.AutoSize = true;
            this.lblBaseCPUSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lblBaseCPUSpeed.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseCPUSpeed.ForeColor = System.Drawing.Color.White;
            this.lblBaseCPUSpeed.Location = new System.Drawing.Point(569, 429);
            this.lblBaseCPUSpeed.Name = "lblBaseCPUSpeed";
            this.lblBaseCPUSpeed.Size = new System.Drawing.Size(33, 17);
            this.lblBaseCPUSpeed.TabIndex = 27;
            this.lblBaseCPUSpeed.Text = "GHz";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(419, 428);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(91, 19);
            this.label31.TabIndex = 28;
            this.label31.Text = "Base Speed:";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.BackColor = System.Drawing.Color.Transparent;
            this.lblCPU.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.ForeColor = System.Drawing.Color.White;
            this.lblCPU.Location = new System.Drawing.Point(177, 25);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(76, 19);
            this.lblCPU.TabIndex = 26;
            this.lblCPU.Text = "CPU Info";
            // 
            // lblHandles
            // 
            this.lblHandles.AutoSize = true;
            this.lblHandles.BackColor = System.Drawing.Color.Transparent;
            this.lblHandles.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandles.ForeColor = System.Drawing.Color.White;
            this.lblHandles.Location = new System.Drawing.Point(331, 500);
            this.lblHandles.Name = "lblHandles";
            this.lblHandles.Size = new System.Drawing.Size(18, 17);
            this.lblHandles.TabIndex = 24;
            this.lblHandles.Text = "--";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(223, 498);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 19);
            this.label11.TabIndex = 25;
            this.label11.Text = "CPU Handles:";
            // 
            // lblThreads
            // 
            this.lblThreads.AutoSize = true;
            this.lblThreads.BackColor = System.Drawing.Color.Transparent;
            this.lblThreads.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreads.ForeColor = System.Drawing.Color.White;
            this.lblThreads.Location = new System.Drawing.Point(331, 464);
            this.lblThreads.Name = "lblThreads";
            this.lblThreads.Size = new System.Drawing.Size(18, 17);
            this.lblThreads.TabIndex = 22;
            this.lblThreads.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(223, 462);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "CPU Threads:";
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.BackColor = System.Drawing.Color.Transparent;
            this.lblFrequency.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrequency.ForeColor = System.Drawing.Color.White;
            this.lblFrequency.Location = new System.Drawing.Point(331, 428);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(33, 17);
            this.lblFrequency.TabIndex = 20;
            this.lblFrequency.Text = "GHz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(223, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "CPU Speed:";
            // 
            // chartCPU
            // 
            this.chartCPU.BackColor = System.Drawing.Color.Transparent;
            this.chartCPU.BorderSkin.BackColor = System.Drawing.Color.White;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.Title = "Time in Seconds";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.Title = "System Utilization %";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.White;
            chartArea2.Name = "CPUArea";
            chartArea2.ShadowColor = System.Drawing.Color.White;
            this.chartCPU.ChartAreas.Add(chartArea2);
            legend2.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            legend2.TitleFont = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartCPU.Legends.Add(legend2);
            this.chartCPU.Location = new System.Drawing.Point(4, 24);
            this.chartCPU.Name = "chartCPU";
            this.chartCPU.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartCPU.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Aqua,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.LawnGreen};
            series5.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series5.ChartArea = "CPUArea";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series5.EmptyPointStyle.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series5.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.LabelBackColor = System.Drawing.Color.Transparent;
            series5.LabelBorderColor = System.Drawing.Color.Transparent;
            series5.LabelForeColor = System.Drawing.Color.White;
            series5.Legend = "Legend1";
            series5.Name = "CPU";
            series5.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chartCPU.Series.Add(series5);
            this.chartCPU.Size = new System.Drawing.Size(737, 406);
            this.chartCPU.TabIndex = 9;
            this.chartCPU.Text = "CPU Utilization";
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "CPU Utilization";
            this.chartCPU.Titles.Add(title2);
            // 
            // pgGPU
            // 
            this.pgGPU.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pgGPU.Flags = 65534;
            this.pgGPU.LastVisibleSet = true;
            this.pgGPU.MinimumSize = new System.Drawing.Size(50, 50);
            this.pgGPU.Name = "pgGPU";
            this.pgGPU.Size = new System.Drawing.Size(743, 680);
            this.pgGPU.Text = "GPU Details";
            this.pgGPU.ToolTipTitle = "Page ToolTip";
            this.pgGPU.UniqueName = "F28124FC65A8430BDB934FF2B49CD80E";
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
            this.pgSystemTemp.Size = new System.Drawing.Size(745, 713);
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
            this.btnGetDriveInfo.Size = new System.Drawing.Size(909, 47);
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
            this.uDiagnoseRibbon.SelectedTab = this.kryptonRibbonTab1;
            this.uDiagnoseRibbon.Size = new System.Drawing.Size(909, 115);
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
            this.panel1.Size = new System.Drawing.Size(909, 715);
            this.panel1.TabIndex = 16;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(25, 35);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(76, 19);
            this.label29.TabIndex = 6;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(26, 62);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(80, 19);
            this.label28.TabIndex = 6;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.White;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisX.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.Title = "Time in Seconds";
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea3.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.Title = "System Utilization";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea3.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BorderColor = System.Drawing.Color.White;
            chartArea3.Name = "ChartArea1";
            chartArea3.ShadowColor = System.Drawing.Color.White;
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(10, 138);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Aqua,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.LawnGreen};
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.EmptyPointStyle.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series6.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series6.LabelBackColor = System.Drawing.Color.Transparent;
            series6.LabelBorderColor = System.Drawing.Color.Transparent;
            series6.LabelForeColor = System.Drawing.Color.White;
            series6.Legend = "Legend1";
            series6.Name = "CPU";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series7.Legend = "Legend1";
            series7.Name = "RAM";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Drive";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "GPU";
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(684, 276);
            this.chart1.TabIndex = 8;
            title3.ForeColor = System.Drawing.Color.White;
            title3.Name = "System Loads";
            this.chart1.Titles.Add(title3);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(25, 586);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(125, 19);
            this.label27.TabIndex = 9;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(156, 586);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(21, 19);
            this.label26.TabIndex = 9;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(61, 406);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(116, 19);
            this.label25.TabIndex = 9;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(183, 407);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(19, 17);
            this.label24.TabIndex = 9;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(62, 442);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(115, 19);
            this.label23.TabIndex = 11;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(183, 442);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(19, 17);
            this.label22.TabIndex = 10;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(62, 478);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(120, 19);
            this.label21.TabIndex = 13;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(183, 479);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 17);
            this.label20.TabIndex = 12;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(255, 407);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 19);
            this.label19.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(363, 407);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 17);
            this.label18.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(255, 441);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 19);
            this.label17.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(363, 443);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 17);
            this.label16.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(255, 477);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 19);
            this.label15.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(363, 479);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 17);
            this.label14.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(61, 514);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 19);
            this.label13.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(183, 515);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 17);
            this.label12.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 22;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(909, 877);
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
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableNavigator1)).EndInit();
            this.kryptonDockableNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pgOverview)).EndInit();
            this.pgOverview.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPURAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgCPU)).EndInit();
            this.pgCPU.ResumeLayout(false);
            this.pgCPU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgGPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgSystemTemp)).EndInit();
            this.pgSystemTemp.ResumeLayout(false);
            this.pgSystemTemp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uDiagnoseRibbon)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDriveInfo;
        private System.Windows.Forms.Label lblDriveList;
        public System.Windows.Forms.TreeView treeHardwareInfo;
        private System.Diagnostics.PerformanceCounter pCPUCounter;
        private System.Diagnostics.PerformanceCounter pRAMCounter;
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
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnFormatDrive;
        private System.Windows.Forms.ToolTip ToolTipUDiagnose;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton3;
        private ComponentFactory.Krypton.Navigator.KryptonPage pgSystemTemp;
        private System.Windows.Forms.Label lblGPUTemp;
        private System.Windows.Forms.Label lblCPUTemp;
        private MetroFramework.Controls.MetroProgressSpinner progGPUTemp;
        private MetroFramework.Controls.MetroProgressSpinner progCPUTemp;
        private System.Windows.Forms.Label lblGetGPUTemp;
        private System.Windows.Forms.Label lblGetCPUTemp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroProgressSpinner progMoboTemp;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Navigator.KryptonPage pgHardwareInfo;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab6;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Docking.KryptonDockableNavigator kryptonDockableNavigator1;
        private ComponentFactory.Krypton.Navigator.KryptonPage pgOverview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblGPUInfo;
        private System.Windows.Forms.Label lblGPUUtilization;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDriveUtilization;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblRAMUtilization;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCPUUtilization;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSystemUpTime;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCPURAM;
        private System.Windows.Forms.Label lblRAM;
        private ComponentFactory.Krypton.Navigator.KryptonPage pgCPU;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCPU;
        private System.Windows.Forms.Label lblHandles;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblThreads;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Navigator.KryptonPage pgGPU;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblCPUThreads;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lblCPUCores;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label lblL1Cahce;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label lblBaseCPUSpeed;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lblL3Cache;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lblL2Cache;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblCPUPAgeUtil;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label lblCPUPageUpTime;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lblCPUOverview;
        public ComponentFactory.Krypton.Toolkit.KryptonListBox lstDrives;
        public System.Windows.Forms.RichTextBox rtbDriveInfo;
        public System.Windows.Forms.ProgressBar progHardDrive;
        public System.Windows.Forms.Label lblDrivePercentage;
    }
}

