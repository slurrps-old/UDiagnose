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
using UFormat.Forms;
using System.Timers;
using UFormat.Classes;
using ComponentFactory.Krypton.Toolkit;
using System.Threading;


namespace UFormat
{
    public partial class frmMain : KryptonForm
    {
        //-------------------------------------------------------------------------------------------------
        //Constants
        const float FLOAT_GIG_CONVERSION = 1073741824f; //Holds the float conversion number of GB per bit
        const float FLOAT_TERA_CONVERSION = 0.0009765625F;

        //Global Variables
        DriveInfo[] allDrives = DriveInfo.GetDrives(); //Calling the drive info instance from system.IO
        string driveInfo; //This is the variable that will hold all of the drive information

        //Initialize the SystemInfo Class and cputemp classes
        Hardware hwInfo = new Hardware();
        CPUTemp CPUTemperature = new CPUTemp();

        //Public Timer for the system to gather load and temperatures live
        public System.Timers.Timer systemLoadTimer;

        //------------------------------------------------------------------------------------------------

        public frmMain()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //This is the load section that loads in the default values and code when launching the program.
        private void Form1_Load(object sender, EventArgs e)
        {
            //Call the FillTreeView function
            hwInfo.FillTreeView(this);

            //Start the timer for the live data       
            systemLoadTimer = new System.Timers.Timer(1000);
            systemLoadTimer.Elapsed += OnTimedEvent;
            systemLoadTimer.Enabled = true;
            //--

        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
        //////////////////////////////////////////////////////////////Functions////////////////////////////////////////////////////////////////////

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

            //CPU and RAM load values on the chart and the progress bars
            //Load
            float fCPU = pCPUCounter.NextValue();
            float fRAM = pRAMCounter.NextValue();

            //Load
            //Invoke the UI elements from a different thread!! Important or the UI will not work for the system loads
            this.BeginInvoke((ThreadStart)delegate ()
            {
                //UI change code goes here
                cpuLoad.Value = (int)fCPU;
                ramLoad.Value = (int)fRAM;

                //Load
                lblCPUPercent.Text = string.Format("{0:0.00}%", fCPU);
                lblRAMPercent.Text = string.Format("{0:0.00}%", fRAM);
                //Load
                chartCPURAM.Series["CPU"].Points.AddY(fCPU);
                chartCPURAM.Series["RAM"].Points.AddY(fRAM);

                //lblCurrentCPUSpeed.Text = hwInfo.GetCpuSpeedInGHz().ToString() + " GHz";
            });

        }//End OnTimedEvent event
         
        /// <summary>
        /// Brandons public method to initialize and setup controls for formMain to be called during the splash screen
        /// </summary>
        public void loadUpData()
        {
            //Get the CPU name and RAM information
            lblCPU.Text = "CPU - " + hwInfo.ProcessorName();
            lblRAM.Text = "RAM - " + hwInfo.RamInformation();

            //We get all of the drive information here
            foreach (DriveInfo di in DriveInfo.GetDrives())
            {
                lstDrives.Items.Add(di.Name); //Populates the drive list with all of the drives attached to the computer
                lstDrives.SelectedIndex = 0; //Sets the selected drive to index 0
            }
            //Grab the TreeViewHardware queries
            hwInfo.TreeViewHardware();

        }//End loadUpData


         //----------------------------------------------------------------------------------------------------------------
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////// DRIVE INFORMATION ////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //This will update the drive information in rtbDriveInfo rich text box on the form everytime you select a different drive from lstDrives on the form
        private void lstDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Here we will set a couple variables.
            string drive_letter = lstDrives.SelectedItem.ToString(); //Set the drive letter of the selected drives and populate the listbox on the form
            DriveInfo di = new DriveInfo(drive_letter); //Set the drive information as a new instance di
            float fltPercent = 0;

            //Here we will start to fill in the variable driveInfo
            driveInfo = "Is Drive Ready: " + di.IsReady.ToString() + Environment.NewLine;
            driveInfo = driveInfo + "Drive Type: " + di.DriveType.ToString() + Environment.NewLine;
            driveInfo = driveInfo + "Drive Letter: " + di.Name + Environment.NewLine;
            //driveInfo = driveInfo + "RootDirectory: " +di.RootDirectory.Name + Environment.NewLine; //Not sure if I need the root directory

            if (di.IsReady)
            {
                //Information to populate the rich text box
                driveInfo = driveInfo + "Drive Name: " + di.VolumeLabel + Environment.NewLine;
                driveInfo = driveInfo + "Drive Format: " + di.DriveFormat + Environment.NewLine;
                driveInfo = driveInfo + "Used Space: " + (ConversionToGig(di.TotalSize) - ConversionToGig(di.AvailableFreeSpace)).ToString("0.00") + " GB" + Environment.NewLine;
                driveInfo = driveInfo + "Available Free Space: " + ConversionToGig(di.AvailableFreeSpace).ToString("0.00") + " GB" + Environment.NewLine;
                //driveInfo = driveInfo + "Total Free Space: " +ConversionToGig(di.TotalFreeSpace).ToString("0.00") + Environment.NewLine;
                driveInfo = driveInfo + "Total Size: " + ConversionToGig(di.TotalSize).ToString("0.00") + " GB" + Environment.NewLine;

                //Calculate the percentage of the drive that has been filled.
                fltPercent = (((float)ConversionToGig(di.TotalSize) - (float)ConversionToGig(di.AvailableFreeSpace)) / (float)ConversionToGig(di.TotalSize)) * 100.0f;


                lblDrivePercentage.Text = "You have used " + fltPercent.ToString("0.00") + "% of your drive"; //This will show the percentage of the drive being used 

                //Progress bar This needs to be inside the if statement as they need to be initialized by the drive being ready
                progHardDrive.Maximum = Convert.ToInt32(ConversionToGig(di.TotalSize)); //This will set the maximun space on the drive to the progress bar
                progHardDrive.Value = Convert.ToInt32(ConversionToGig(di.TotalSize) - ConversionToGig(di.AvailableFreeSpace)); //This will get how much is used on the drive and set the value to the progress bar

                if (fltPercent >= 80.0f)
                {
                    lblDrivePercentage.ForeColor = Color.Red; //Sets the label color to Crimson
                }
                else
                {
                    lblDrivePercentage.ForeColor = Color.White; //Sets the label color to White
                }
            }
            else
            {
                //Fills in the rich text box letting the user know the drive is not ready
                driveInfo = "Is Drive Ready: " + di.IsReady.ToString() + Environment.NewLine; //If not found set the information to nothing

                progHardDrive.Maximum = 100; //Sets the maximun to 100
                progHardDrive.Value = 0; //Sets the value to 0

                lblDrivePercentage.ForeColor = Color.White; //Sets the label color to white
                lblDrivePercentage.Text = "This drive is not ready"; //Changes the label to read the drive is not ready

            }

            rtbDriveInfo.Text = driveInfo; //Set the above information on the drives to the rich text box on the form

        }//End Drive information Gathering

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //The button code that will update the form with the most recent drives in the computer
        private void btnGetDriveInfo_Click(object sender, EventArgs e)
        {
            //Clears both lists in the system so that drives don't duplicate
            lstDrives.Items.Clear();
            rtbDriveInfo.Clear();

            //Here we will update the list of drives in the system in case one was removed 
            foreach (DriveInfo di in DriveInfo.GetDrives())
            {
                lstDrives.Items.Add(di.Name);
                lstDrives.SelectedIndex = 0;


            }

        }//End Drive Button code
         ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
         ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////// Menu Strip ///////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //
        //File strip Menu items

        //Save the Hardware tree to a text file listing all the hardware in the system
        private void saveAstxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                string location = "";
                //Set it's name
                saveFileDialog1.FileName = "HardWare Info ";
                //Set the extention
                saveFileDialog1.DefaultExt = ".txt";
                //Filters that can be used for the file
                saveFileDialog1.Filter = "All Documents (*.docx;*.docm;*.doc;*.dotx;*.dotm;*.dot;*.htm;*.html;*.rtf;*.txt;*.pdf)" +
                    "|*.docx;*.docm;*.dotx;*.dotm;*.doc;*.dot;*.htm;*.html;*.rtf;*.txt;*.pdf|" +
                        "Word Documents (*.docx)|*.docx|" +
                        "Word Macro-Enabled Documents (*.docm)|*.docm|" +
                        "Word 97-2003 Documents (*.doc)|*.doc|" +
                        "Word Templates (*.dotx)|*.dotx|" +
                        "Word Macro-Enabled Templates (*.dotm)|*.dotm|" +
                        "Word 97-2003 Templates (*.dot)|*.dot|" +
                        "Web Pages (*.htm;*.html)|*.htm;*.html|" +
                        "Rich Text Format (*.rtf)|*.rtf|" +
                        "Text Files (*.txt)|*.txt|" +
                        "PDF Files (*.pdf)|*.pdf";

                //Show the dialog
                saveFileDialog1.ShowDialog();
                //Save the filename to the variable string location
                location = saveFileDialog1.FileName;

                // create buffer for storing string data
                System.Text.StringBuilder buffer = new System.Text.StringBuilder();
                //Add the time to the top of the file and two lines 
                buffer.Append(System.DateTime.Now.ToString());
                buffer.Append(Environment.NewLine);
                buffer.Append(Environment.NewLine);
                // loop through each of the treeview's root nodes
                foreach (TreeNode rootNode in treeHardwareInfo.Nodes)
                    // call recursive function
                    BuildTreeString(rootNode, buffer);
                // write data to file
                System.IO.File.WriteAllText(location, buffer.ToString());
            
            
        }//End SaveAs tool

        //Exit button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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
        //---------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------



    }//End class


}//End namespace
