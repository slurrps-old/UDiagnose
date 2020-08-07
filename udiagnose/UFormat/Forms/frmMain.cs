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
using Test_Event_Logs;

namespace UDiagnose
{
    public partial class frmMain : KryptonForm
    {
        #region Public variables and constants for the program
        //Public Timer for the system to gather load and temperatures live so that they do not iterfier with the UI controls
        public System.Timers.Timer systemLoadTimer;
        //-------------------------------------------------------------------------------------------------
        //Variable for performance counters
        public string[] Instances;
        //-------------------------------------------------------------------------------------------------
        //Initialize the appropriate classes
        readonly Hardware hwInfo = new Hardware(); //Hardware info class called
        readonly CPUTemp CPUTemperature = new CPUTemp(); //CPU class
        FormatClass format = new FormatClass(); //format class called
        readonly DriveInfoClass driveInformation = new DriveInfoClass();//drive information class
        readonly SaveHWInfo saveHW = new SaveHWInfo();
        readonly ErrorCodeForm form = new ErrorCodeForm();
        readonly About facts = new About();
        readonly Popups.License license = new Popups.License();
        readonly EventLogClass Events = new EventLogClass();

        #endregion

        #region Performance Counters
        //Performance Counters-------------------------------------------------------------------------------------------
        //Physical Disk
        public PerformanceCounter pDrive = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total"); //Drive utilization
        //System
        public PerformanceCounter pUpTime = new PerformanceCounter("System", "System Up Time"); //System up time
        //Processor
        public PerformanceCounter pFrequency = new PerformanceCounter("Processor Performance", "Processor Frequency", "PPM_Processor_0"); //Processor frequency
        public PerformanceCounter pThreads = new PerformanceCounter("Process", "Thread Count", "_Total");//Processor thread count
        public PerformanceCounter pHandles = new PerformanceCounter("Process", "Handle Count", "_Total");//Processor handle count

        //GPU
        public PerformanceCounter[] pGPU;
        //------------------------------------------------------------------------------------------------
        #endregion

        public frmMain()
        {
            InitializeComponent();
        }

        #region Form Load
        ///////////////////////////////////////////////////////////////////////////////////////////////////
        //This is the load section that loads in the default values and code when launching the program.
        private void Form1_Load(object sender, EventArgs e)
        {
            //Call the FillTreeView function
            //It will load the treeview with all of the information queried in the splash screen.
            hwInfo.FillTreeView(this);

            //Start the timer for the live data       
            //properties
            systemLoadTimer = new System.Timers.Timer(1000); //set a new timer at 1 second per tick
            systemLoadTimer.Elapsed += OnTimedEvent;//set it to the on timed event
            systemLoadTimer.Enabled = true;//enable the timer
            //Defaults for the Charts in the program-----
            //set the maximum to 100 for all charts
            chartCPURAM.ChartAreas[0].AxisY.Maximum = 100;
            chartCPU.ChartAreas[0].AxisY.Maximum = 100;

            //Get the instances from the hardware for GPU
            Instances = hwInfo.GetInstances();
            //Set the array of performance counters to equal the length of the instances
            pGPU = new PerformanceCounter[Instances.Length];
            //Create an array of performance counters
            for (int i = 0; i < Instances.Length; i++)
            {
                pGPU[i] = new PerformanceCounter("GPU Engine", "Utilization Percentage", Instances[i]);
            }

            //Load Events for system Event View
            Events.LoadInfo(this);

        }//End Form Load
        #endregion      

        #region Events for the Timer and Load for the splash screen
        //This event will load up the live data that will continue to read as long as the program is up and running. This is on a separate thread from the GUI

        //This is being called in the form load event which causes it to lag in starting by about 3 to 5 seconds will need to sort that out
        public void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            ////Temp has some issues that need to be worked out...
            //lblCPUTemp.Text = CPUTemperature.GetCPUTemp().ToString() + " °C";
            //lblGPUTemp.Text = CPUTemperature.GetGPUTemp().ToString() + " °C";


            ////Temp
            //progCPUTemp.Value = (int)CPUTemperature.GetCPUTemp();
            //progGPUTemp.Value = (int)CPUTemperature.GetGPUTemp();

            //if (progCPUTemp.Value >= 90)
            //{
            //    MessageBox.Show("Alert - Your CPU Temperature is dangerously high please shutdown", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            //--------------------------------System Loads Page------------------------------------------//
            //Holds the performance counters for CPU, RAM, and Drive load percentage on the system
            //Memeory
            float fRAM = pRAMCounter.NextValue();//get the next value of the counter
            //Physical Disk
            float fDrive = pDrive.NextValue();//get the next value of the counter
            //CPU
            float fCPU = pCPUCounter.NextValue();//get the next value of the counter
            float fFrequency = (pFrequency.NextValue()/ 1000);//get the next value of the counter
            int intThreads = Convert.ToInt32(pThreads.NextValue());//get the next value of the counter
            int intHandles = Convert.ToInt32(pHandles.NextValue());//get the next value of the counter
            //GPU
            float fGPU = 0.0f;
            //Add all of the instances together to get utilization
            for (int i = 0; i < Instances.Length; i++)
            {
                fGPU = fGPU + pGPU[i].NextValue();

            }


            //Sysyem up time-----
            TimeSpan ts = TimeSpan.FromSeconds(pUpTime.NextValue());//Holds the performance counter for the system up time
            string time = string.Format("{0}d:{1}h:{2}m:{3}s", ts.Days, ts.Hours, ts.Minutes, ts.Seconds);//Format the system up time
            //-----

            //Important!!!
            //Invoke the UI elements from a different thread!! Important or the UI will not work for the system loads
            this.BeginInvoke((ThreadStart)delegate ()
            {
                //--------------------------------OVERVIEW PAGE----------------------------------
                //Utilizations
                //Memory
                lblRAMUtilization.Text = string.Format("{0:0.00}%", fRAM);//displays ram utilization

                //Physical Disk
                lblDriveUtilization.Text = string.Format("{0:0.00}%", fDrive);//displays drive utilization

                //CPU On Overview page
                lblCPUUtilization.Text = string.Format("{0:0.00}%", fCPU);//displays cpu utilization

                //GPU
                lblGPUUtilization.Text = string.Format("{0:0.00}%", fGPU);

                //System Up Time
                lblSystemUpTime.Text = time;//set the label to the time variable

                //Chart Overview Load
                chartCPURAM.Series["CPU"].Points.AddY(fCPU);//add the points to the fCPU variable per tic
                chartCPURAM.Series["RAM"].Points.AddY(fRAM);//add the points to the fRAM variable per tic
                chartCPURAM.Series["Drive"].Points.AddY(fDrive);//add the points to the fDrive variable per tic
                chartCPURAM.Series["GPU"].Points.AddY(fGPU);


                //---------------------------CPU PAGE-----------------------------------
                //CPU Information
                lblFrequency.Text = string.Format("{0:0.00}GHz", fFrequency);//Get the current frequency of the cpu
                lblHandles.Text = (intHandles.ToString());//Get the amount of handles on the cpu
                lblThreads.Text = (intThreads.ToString());//Get the amount of threads on the cpu
                //chartCPU
                chartCPU.Series["CPU"].Points.AddY(fCPU);//add the points to the fCPU variable per tic
                //Utilization
                lblCPUPAgeUtil.Text = string.Format("{0:0.00}%", fCPU);//displays cpu utilization
                //System Up Time
                lblCPUPageUpTime.Text = time;//set to the time variable to show system up time

                //---------------------------GPU PAGE-----------------------------------
                chartGPU.Series["GPU"].Points.AddY(fGPU);


                //---------------------------Temp PAGE-----------------------------------
                //progCPUTemp.Value = Convert.ToInt32(CPUTemperature.GetCPUTemp());

            });//End Invoke

        }//End OnTimedEvent event
         
        /// <summary>
        /// Brandons public method to initialize and setup controls for formMain to be called during the splash screen
        /// </summary>
        public void loadUpData()
        {
            //Pre: Does not need anything to initialize
            //Purpose: To load up the data during the splash screen form
            //Get the CPU name and RAM information for the OVERVIEW Page

            lblCPUOverview.Text = "CPU - " + hwInfo.ProcessorName();//Grab the processor name
            lblRAM.Text = "RAM - " + hwInfo.RamInformation();//Grab the ram amount and manufacturer
            lblGPUInfo.Text = "GPU - " + hwInfo.GPUName();//Grab the gpu name

            driveInformation.RefreshDrives(this); //Get the drives information loaded in the list

            //Grab the TreeViewHardware queries
            hwInfo.SearchHardware(); //Search up the hardware on the computer

            //---------------------------CPU PAGE-----------------------------------
            //CPU PAGE Information must be loaded after the Hardware information above.
            //CPU Page Details to be loaded from the splash screen
            lblCPU.Text = "CPU - " + hwInfo.ProcessorName(); //Processor name
            lblBaseCPUSpeed.Text = hwInfo.cpuSpeed.ToString(); //Base Processor speed
            lblCPUCores.Text = hwInfo.numCores.ToString(); //Number of cores on processor
            lblCPUThreads.Text = hwInfo.numThreads.ToString(); //Number of threads on processor
            lblL1Cahce.Text = hwInfo.l1Cache.ToString(); //L1 Cache size
            lblL2Cache.Text = hwInfo.l2Cache.ToString(); //L2 Cache size
            lblL3Cache.Text = hwInfo.l3Cache.ToString(); //L3 Cache size

            

        }//End loadUpData

        #endregion

        #region Drive Information
        private void lstDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            //This will update the drive information in rtbDriveInfo rich text box on the 
            //form everytime you select a different drive from lstDrives on the form

            //Load the drive information on the scelected drive from the list box
            driveInformation.LoadDrives(this); //Call the method from the DriveInfoClass
        }//End Drive information Gathering

        //The button code that will update the form with the most recent drives in the computer
        private void btnGetDriveInfo_Click(object sender, EventArgs e)
        {
            //Refresh the drive list in the list box
            driveInformation.RefreshDrives(this); //Call the method from the DriveInfoClass
        }//End Drive Button code

        #endregion

        #region Menu Strip Items

        #region File Strip
        //Save the Hardware tree to a text file listing all the hardware in the system
        private void saveAstxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Call the SaveInfo method from the SaveHWInfo class
            saveHW.SaveInfo(this);

        }//End saveAstxtToolStripMenuItem_Click

        //Exit button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close the application
            Application.Exit();
        }//End exitToolStripMenuItem_Click
        #endregion

        #region View Options
        //Show format options
        private void btnViewOptions(object sender, EventArgs e)
        {
           
        }//End btnViewOptions
        #endregion

        #region Tools Strip
        //Launches disk management
        private void diskPartitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //We can use system.diagnostics.process.start to launch programs on the computer. 
            //diskmgmt.msc is alwasy located on the same directory in windows
            //we will use this to launch to take care of formatting for the most part.
            Process diskPart = System.Diagnostics.Process.Start(@"C:\Windows\System32\diskmgmt.msc");

            diskPart.Close();
        }//End diskPartitionToolStripMenuItem_Click

        //Cmd launcher
        private void cMDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //We can use system.diagnostics.process.start to launch programs on the computer. 
            //Opens the command prompt
            Process CMD = System.Diagnostics.Process.Start(@"C:\Windows\System32\cmd.exe");

            CMD.Close();
        }//End cMDToolStripMenuItem_Click

        //Disk Part launcher 
        private void diskPartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //We can use system.diagnostics.process.start to launch programs on the computer. 
            //Opens the disk partition command prompt
            Process CMDDisk = System.Diagnostics.Process.Start(@"C:\Windows\System32\diskpart.exe");

            CMDDisk.Close();
        }//End diskPartToolStripMenuItem_Click

        //Launches registry edit tool
        private void regEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show message alerting that altering anything in registry may harm their computer
            DialogResult result = MessageBox.Show("Warning editing the registry can harm your computer. " +
                "Are you sure you want to open this?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            switch (result)
            {
                case DialogResult.Yes:
                    //We can use system.diagnostics.process.start to launch programs on the computer. 
                    //Opens the registry editor
                    Process regEdit = System.Diagnostics.Process.Start(@"C:\WINDOWS\regedit.exe");

                    regEdit.Close();
                    break;

                case DialogResult.No:

                    break;
            }
        }//End regEditToolStripMenuItem_Click

        //This will launch the event viewer
        private void eventViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //We can use system.diagnostics.process.start to launch programs on the computer. 
            //Opens the event viewer
            Process eventViewer = System.Diagnostics.Process.Start(@"C:\Windows\System32\eventvwr.exe");

            eventViewer.Close();
        }//End eventViewerToolStripMenuItem_Click

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the application
            Application.Exit();
        }//End btnExit_Click

        //Closed event
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Closes the application
            Application.Exit();
        }//End frmMain_FormClosed
        #endregion

        #region Help Strip
        //Error code show form button
        private void errorCodeDescriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Hide this form
            this.Hide();
            //Stop the timer
            systemLoadTimer.Stop();
            //Show the errorCodeForm
            form.Show();
        }//End errorCodeDescriptionsToolStripMenuItem_Click

        //Go to specific websites
        private void btnGo_Click(object sender, EventArgs e)
        {
            Process Website;
            //Check to see what the text in the cmbWebsites combo box reads and go to the appropriate
            //website via the default web browser
            if(cmbWebsites.Text == "Stack Overflow")
            {
                cmbWebsites.Text = null;
                Website = System.Diagnostics.Process.Start("https://stackoverflow.com/");

                Website.Close();
            }
            else if(cmbWebsites.Text == "Code Project")
            {
                cmbWebsites.Text = null;
                Website = System.Diagnostics.Process.Start("https://codeproject.com/");

                Website.Close();
            }
            else if(cmbWebsites.Text == "Toms Hardware")
            {
                cmbWebsites.Text = null;
                Website = System.Diagnostics.Process.Start("https://www.tomshardware.com/");

                Website.Close();
            }
        }//End btnGo_Click

        //About form show
        private void btnAbout_Click(object sender, EventArgs e)
        {
            //Show the About form
            facts.ShowDialog();
        } //End kryptonRibbonGroupButton1_Click

        private void btnLicense_Click(object sender, EventArgs e)
        {
            //Show license form
            license.ShowDialog();
        }//End btnLicense_Click
        #endregion

        #endregion



    }//End class


}//End namespace
