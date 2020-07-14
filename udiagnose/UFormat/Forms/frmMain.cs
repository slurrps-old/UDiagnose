//Author: Kenneth Lamb / Brandon Thomas
//Date: 02/13/2020
//Purpose: This program is a diagnostic utility for computers
//Input: None
//Processing: Each method of the class is tested for functionality
//Output: All output resulting from the various test statements is printed to the screen. 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Used to list the drives
using System.Management;
using System.Diagnostics;
using Microsoft.Win32;
using HardwareDisplay; //HardWare class
using UDiagnose.Forms;
using System.Timers;
using UDiagnose.Classes;
using ComponentFactory.Krypton.Toolkit;
using System.Threading;
using UFormat.Forms;
using System.Windows.Forms.VisualStyles;
using UDiagnose.Popups;

namespace UDiagnose
{
    public partial class frmMain : KryptonForm
    {
        #region Public variables and constants for the program
        //Public Timer for the system to gather load and temperatures live so that they do not iterfier with the UI controls
        public System.Timers.Timer systemLoadTimer;
        public string[] instances = null;
        //-------------------------------------------------------------------------------------------------
        //Constants for conveersions of different byt sizes
        const float FLOAT_GIG_CONVERSION = 1073741824f; //Holds the float conversion number of GB per bit
        const float FLOAT_TERA_CONVERSION = 0.0009765625F;

        //Global Variables to use DriveInfo and variable to hold all of the systems rive information.
        //DriveInfo[] allDrives = DriveInfo.GetDrives(); //Calling the drive info instance from system.IO
        public string driveInfo; //This is the variable that will hold all of the drive information

        //Initialize the appropriate classes
        Hardware hwInfo = new Hardware();
        CPUTemp CPUTemperature = new CPUTemp();
        FormatClass format = new FormatClass();
        #endregion

        #region Performance Counters
        //Performance Counters-------------------------------------------------------------------------------------------
        //Physical Disk
        public PerformanceCounter pDrive = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");
        //System
        public PerformanceCounter pUpTime = new PerformanceCounter("System", "System Up Time");
        //Processor
        public PerformanceCounter pFrequency = new PerformanceCounter("Processor Performance", "Processor Frequency", "PPM_Processor_0");
        public PerformanceCounter pThreads = new PerformanceCounter("Process", "Thread Count", "_Total");
        public PerformanceCounter pHandles = new PerformanceCounter("Process", "Handle Count", "_Total");


        //GPU
        //GPU Utilization
        //Not sure how to implement this as this changes from computer to computer
        //public PerformanceCounter pGPUPercent = new PerformanceCounter("GPU Engine", "Utilization Percentage", "pid_10236_luid_0x00000000_0x0000CE82_phus_0_eng_0_engtype_3D");




        //Find a way to make this work for any GPU
        //public PerformanceCounter pGPUPercent = new PerformanceCounter("GPU Engine", "Utilization Percentage", "pid_10244_luid_0x00000000_0x00009FDA_phys_0_eng_0_engtype_3D");
        //------------------------------------------------------------------------------------------------
        #endregion

        public frmMain()
        {
            InitializeComponent();
        }

        #region Form Load
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //This is the load section that loads in the default values and code when launching the program.
        private void Form1_Load(object sender, EventArgs e)
        {
            //Call the FillTreeView function
            //It will load the treeview with all of the information queried in the splash screen.
            hwInfo.FillTreeView(this);

            //Start the timer for the live data       
            systemLoadTimer = new System.Timers.Timer(1000);
            systemLoadTimer.Elapsed += OnTimedEvent;
            systemLoadTimer.Enabled = true;
            //Defaults for the Charts in the program-----
            chartCPURAM.ChartAreas[0].AxisY.Maximum = 100;
            chartCPU.ChartAreas[0].AxisY.Maximum = 100;

            

        }//End Form Load
        #endregion

        #region Functions
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////// Functions ///////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Convert bytes to Gigabytes used to display correct drive information
        public float ConversionToGig(float conversionNum)
        {
            //Set the gigConversion to 0
            float gigConversion = 0.0f;

            gigConversion = conversionNum / FLOAT_GIG_CONVERSION; //Grabs the conversionNum from the one passed into the function then divides by the Float_GIG_CONVERSION Constant

            return gigConversion; //Returns the variable gigConversion
        }

        public float ConversionToTer(float ConversionNum)
        {
            float teraConversion = 0.0f;

            teraConversion = ConversionNum / FLOAT_TERA_CONVERSION;

            return teraConversion;
        }

        //Convert the treeview into a sting using the stringbuilder used to save the tree as a text document
        public void BuildTreeString(TreeNode rootNode, System.Text.StringBuilder buffer)
        {

            buffer.Append(rootNode.Text);
            buffer.Append(Environment.NewLine);

            foreach (TreeNode childNode in rootNode.Nodes)
            {
                //Call the buildstring method within the method and throw it the treenode and stringbuilder
                BuildTreeString(childNode, buffer);
            }

        }
        #endregion

        #region Events for the Timer and Load for the splash screen
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //This event will load up the live data that will continue to read as long as the program is up and running. This is on a separate thread from the GUI

        //This is being called in the form load event which causes it to lag in starting by about 3 to 5 seconds will need to sort that out
        public void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            SystemInfo sysInfo = new SystemInfo();
            //Temp has some issues that need to be worked out...
            //lblCPUTemp.Text = CPUTemperature.GetCPUTemp().ToString() + " °C";
            //lblGPUTemp.Text = CPUTemperature.GetGPUTemp().ToString() + " °C";


            ////Temp
            //progCPUTemp.Value = (int)CPUTemperature.GetCPUTemp();
            //progGPUTemp.Value = (int)CPUTemperature.GetGPUTemp();

            //if (progCPUTemp.Value >= 90)
            //{
            //    MessageBox.Show("Alert - Your CPU Temperature is dangerously high please shutdown", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            //System Loads Page--------------------------------------------------------------------------//
            //Holds the performance counters for CPU, RAM, and Drive load percentage on the system
            //Memeory
            float fRAM = pRAMCounter.NextValue();
            //Physical Disk
            float fDrive = pDrive.NextValue();
            //CPU
            float fCPU = pCPUCounter.NextValue();
            float fFrequency = (pFrequency.NextValue()/ 1000);
            int intThreads = Convert.ToInt32(pThreads.NextValue());
            int intHandles = Convert.ToInt32(pHandles.NextValue());
            //GPU
            //float fGPU = pGPUPercent.NextValue();


            //Sysyem up time
            TimeSpan ts = TimeSpan.FromSeconds(pUpTime.NextValue());//Holds the performance counter for the system up time
            //------

            //Important!!!
            //Invoke the UI elements from a different thread!! Important or the UI will not work for the system loads
            this.BeginInvoke((ThreadStart)delegate ()
            {
               
                //OVERVIEW PAGE---------------------------------------------------------------------------------
                //Utilizations
                //Memory
                lblRAMUtilization.Text = string.Format("{0:0.00}%", fRAM);

                //Physical Disk
                lblDriveUtilization.Text = string.Format("{0:0.00}%", fDrive);

                //CPU On Overview page
                lblCPUUtilization.Text = string.Format("{0:0.00}%", fCPU);

                //GPU
                //lblGPUUtilization.Text = string.Format("{0:0.00}%", fGPU);

                //System Up Time
                lblSystemUpTime.Text = string.Format("{0}d:{1}h:{2}m:{3}s", ts.Days, ts.Hours, ts.Minutes, ts.Seconds);

                //Chart Overview Load
                chartCPURAM.Series["CPU"].Points.AddY(fCPU);
                chartCPURAM.Series["RAM"].Points.AddY(fRAM);
                chartCPURAM.Series["Drive"].Points.AddY(fDrive);
                //chartCPURAM.Series["GPU"].Points.AddY(fGPU);


                //CPU PAGE-----------------------------------------------------------------------------------------
                //CPU Information
                lblFrequency.Text = string.Format("{0:0.00}GHz", fFrequency);
                lblHandles.Text = (intHandles.ToString());
                lblThreads.Text = (intThreads.ToString());

                //chartCPU
                chartCPU.Series["CPU"].Points.AddY(fCPU);

                //Utilization
                lblCPUPAgeUtil.Text = string.Format("{0:0.00}%", fCPU);

                //System Up Time
                lblCPUPageUpTime.Text = string.Format("{0}d:{1}h:{2}m:{3}s", ts.Days, ts.Hours, ts.Minutes, ts.Seconds);

            });

        }//End OnTimedEvent event
         
        /// <summary>
        /// Brandons public method to initialize and setup controls for formMain to be called during the splash screen
        /// </summary>
        public void loadUpData()
        {
            //Pre: Does not need anything to initialize
            //Purpose: To load up the data during the splash screen form
            //Get the CPU name and RAM information for the OVERVIEW Page---------------------------------------
            lblCPUOverview.Text = "CPU - " + hwInfo.ProcessorName();
            lblRAM.Text = "RAM - " + hwInfo.RamInformation();
            lblGPUInfo.Text = "GPU - " + hwInfo.GPUName();

            
            //We get all of the drive information here for the DRIVE PAGE--------------------------------------
            foreach (DriveInfo di in DriveInfo.GetDrives())
            {
                lstDrives.Items.Add(di.Name); //Populates the drive list with all of the drives attached to the computer
                lstDrives.SelectedIndex = 0; //Sets the selected drive to index 0
            }
            //Grab the TreeViewHardware queries
            hwInfo.TreeViewHardware();

            //CPU PAGE Information must be loaded after the Hardware information above.
            //CPU Page Details
            lblCPU.Text = "CPU - " + hwInfo.ProcessorName();
            lblBaseCPUSpeed.Text = hwInfo.cpuSpeed.ToString();
            lblCPUCores.Text = hwInfo.numCores.ToString();
            lblCPUThreads.Text = hwInfo.numThreads.ToString();
            lblL1Cahce.Text = hwInfo.l1Cache.ToString();
            lblL2Cache.Text = hwInfo.l2Cache.ToString();
            lblL3Cache.Text = hwInfo.l3Cache.ToString();

        }//End loadUpData

        #endregion

        #region Drive Information
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////// DRIVE INFORMATION ////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //This will update the drive information in rtbDriveInfo rich text box on the form everytime you select a different drive from lstDrives on the form
        private void lstDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            DriveInfoClass dwInfo = new DriveInfoClass(this);

            dwInfo.LoadDrives();
        }//End Drive information Gathering

        //The button code that will update the form with the most recent drives in the computer
        private void btnGetDriveInfo_Click(object sender, EventArgs e)
        {
            DriveInfoClass dwInfo = new DriveInfoClass(this);
            dwInfo.RefreshDrives();
        }//End Drive Button code

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            
            string driveLetter = "";

            if (lstDrives.SelectedIndex == 0)
            {
                MessageBox.Show("Error you cannot format the windows partition drive, please try another drive.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Get selected drive letter
                driveLetter = lstDrives.SelectedItem.ToString();
                driveLetter = driveLetter.Remove(2, 1);


                //Call the formatdrive method
                format.FormatDrive(driveLetter);
                //Set an instance of the driveinfo class and call the refresh drives
                DriveInfoClass dwInfo = new DriveInfoClass(this);
                dwInfo.RefreshDrives();
            }
        }

        private void btnSecureWipe_Click(object sender, EventArgs e)
        {
            if (lstDrives.SelectedIndex == 0)
            {
                MessageBox.Show("Error you cannot format the windows partition drive, please try another drive.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string driveLetter = "";
                //Get selected drive letter
                driveLetter = lstDrives.SelectedItem.ToString();
                driveLetter = driveLetter.Remove(2, 1);

                format.SecureFormat(driveLetter);
                DriveInfoClass dwInfo = new DriveInfoClass(this);
                dwInfo.RefreshDrives();
            }

        }
        #endregion

        #region Menu Strip Items

        #region File Strip
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////// Menu Strip ///////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //
        //File strip Menu items

        //Save the Hardware tree to a text file listing all the hardware in the system
        private void saveAstxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveHWInfo saveHW = new SaveHWInfo(this);

            saveHW.SaveInfo();

        }//End SaveAs tool

        //Exit button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region View Options
        //Show format options
        private void kryptonRibbonGroupButton4_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Tools Strip
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////tools strip menu items////////////////////////////////////////////////////////////////////////////
        ///
        //Launches disk management
        private void diskPartitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //We can use system.diagnostics.process.start to launch programs on the computer. diskmgmt.msc is alwasy located on the same directory in windows
            //we will use this to launch to take care of formatting for the most part.
            System.Diagnostics.Process.Start(@"C:\Windows\System32\diskmgmt.msc");
        }

        //Cmd launcher
        private void cMDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\cmd.exe");
        }
        //Disk Part launcher 
        private void diskPartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\diskpart.exe");
        }
        //Launches registry edit tool
        private void regEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Warning editing the registry can harm your computer. Are you sure you want to open this?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            switch (result)
            {
                case DialogResult.Yes:
                    System.Diagnostics.Process.Start(@"C:\WINDOWS\regedit.exe");
                    break;

                case DialogResult.No:

                    break;
            }
        }
        //This will launch the event viewer
        private void eventViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\eventvwr.exe");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        //Closed event
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region View Options
        //Show format options
        private void btnViewOptions(object sender, EventArgs e)
        {
            if (grpFormatOptions.Visible == false)
            {
                grpFormatOptions.Visible = true;
            }
            else
            {
                grpFormatOptions.Visible = false;
            }
        }
        #endregion

        #region Help Strip
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////Help Strip Menu/////////////////////////////////////////////////////////////////////
        ///

        //Error code show form button
        private void errorCodeDescriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ErrorCodeForm form = new ErrorCodeForm();
            this.Hide();
            systemLoadTimer.Stop();
            form.Show();
        }

        //Go to specific websites
        private void btnGo_Click(object sender, EventArgs e)
        {
            if(cmbWebsites.Text == "Stack Overflow")
            {
                System.Diagnostics.Process.Start("https://stackoverflow.com/");
            }
            else if(cmbWebsites.Text == "Code Project")
            {
                System.Diagnostics.Process.Start("https://codeproject.com/");
            }
            else if(cmbWebsites.Text == "Toms Hardware")
            {
                System.Diagnostics.Process.Start("https://www.tomshardware.com/");
            }
        }

        //About form show
        private void kryptonRibbonGroupButton1_Click(object sender, EventArgs e)
        {
            About facts = new About();
            facts.Show();
        }

        #endregion

        #endregion

        private void btnFileWipe_Click(object sender, EventArgs e)
        {

            format.WipeFile();
        }
    }//End class


}//End namespace
