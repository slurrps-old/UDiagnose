using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO; //Used to list the drives
using System.Management;

namespace UDiagnose.Classes
{
    
    class DriveInfoClass
    {

        //Constants for conveersions of different byt sizes
        const float FLOAT_GIG_CONVERSION = 1073741824f; //Holds the float conversion number of GB per bit
        const float FLOAT_TERA_CONVERSION = 0.0009765625F;//Holds the float conversion number for TB per bit
        //-------------------------------------------------------------------------------------------------
        //Global Variables to use DriveInfo and variable to hold all of the systems rive information.
        public string driveInfo; //This is the variable that will hold all of the drive information
        //-------------------------------------------------------------------------------------------------
        public DriveInfoClass()
        {

        }

        #region Functions

        //Convert bytes to Gigabytes used to display correct drive information
        public float ConversionToGig(float conversionNum)
        {
            //Pre: Needs conversionNum to be initialized
            //Pose: Returns gigConversion number to the program
            //Purpose: To convert the bytes number that is incoming to gigabytes

            //Set the gigConversion to 0
            float gigConversion;
            //Grabs the conversionNum from the one passed into the function then 
            //divides by the Float_GIG_CONVERSION Constant
            gigConversion = conversionNum / FLOAT_GIG_CONVERSION;

            return gigConversion; //Returns the variable gigConversion
        }//End ConversionToGig

        //Convert bytes to TeraBytes used to display correct drive information
        public float ConversionToTer(float ConversionNum)
        {
            //Pre: Needs conversionNum to be initialized
            //Pose: Returns teraConversion number to the program
            //Purpose: To convert the bytes number that is incoming to terabytes

            //Set the teraConversion to 0
            float teraConversion;
            //Grabs the conversionNum from the one passed into the function then 
            //divides by the Float_TERA_CONVERSION Constant
            teraConversion = ConversionNum / FLOAT_TERA_CONVERSION;

            return teraConversion;
        }//End ConversionToTer
        #endregion

        #region Refresh Drive list
        public void RefreshDrives(frmMain main)
        {
            //Refresh the list
            main.lstDrives.Items.Clear();
            //Here we will update the list of drives in the system in case one was removed 
            foreach (DriveInfo di in DriveInfo.GetDrives())
            {
                main.lstDrives.Items.Add(di.Name);
                main.lstDrives.SelectedIndex = 0;
            }
        }
        #endregion

        #region Load Drive Info
        public void LoadDrives(frmMain main)
        {
            //Here we will set a couple variables.
            string drive_letter = main.lstDrives.SelectedItem.ToString(); //Set the drive letter of the selected drives and populate the listbox on the form
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
                //main.driveInfo = main.driveInfo + "Drive is a " + DriveType() + Environment.NewLine;
                driveInfo = driveInfo + "Drive Name: " + di.VolumeLabel + Environment.NewLine;
                driveInfo = driveInfo + "Drive Format: " + di.DriveFormat + Environment.NewLine;

                //--
                //Need to convert these to TB by setting up if statements.
                driveInfo = driveInfo + "Used Space: " + (ConversionToGig(di.TotalSize) - ConversionToGig(di.AvailableFreeSpace)).ToString("0.00") + " GB" + Environment.NewLine;
                driveInfo = driveInfo + "Available Free Space: " + ConversionToGig(di.AvailableFreeSpace).ToString("0.00") + " GB" + Environment.NewLine;
                driveInfo = driveInfo + "Total Size: " + ConversionToGig(di.TotalSize).ToString("0.00") + " GB" + Environment.NewLine;
                //Calculate the percentage of the drive that has been filled.
                fltPercent = (((float)ConversionToGig(di.TotalSize) - (float)ConversionToGig(di.AvailableFreeSpace)) / (float)ConversionToGig(di.TotalSize)) * 100.0f;


                main.lblDrivePercentage.Text = "You have used " + fltPercent.ToString("0.00") + "% of your drive"; //This will show the percentage of the drive being used 

                //Progress bar This needs to be inside the if statement as they need to be initialized by the drive being ready
                main.progHardDrive.Maximum = Convert.ToInt32(ConversionToGig(di.TotalSize)); //This will set the maximun space on the drive to the progress bar
                main.progHardDrive.Value = Convert.ToInt32(ConversionToGig(di.TotalSize) - ConversionToGig(di.AvailableFreeSpace)); //This will get how much is used on the drive and set the value to the progress bar

                if (fltPercent >= 80.0f)
                {
                    main.lblDrivePercentage.ForeColor = Color.Red; //Sets the label color to Crimson
                }
                else
                {
                    main.lblDrivePercentage.ForeColor = Color.White; //Sets the label color to White
                }
            }
            else
            {
                //Fills in the rich text box letting the user know the drive is not ready
                driveInfo = "Is Drive Ready: " + di.IsReady.ToString() + Environment.NewLine; //If not found set the information to nothing

                main.progHardDrive.Maximum = 100; //Sets the maximun to 100
                main.progHardDrive.Value = 0; //Sets the value to 0

                main.lblDrivePercentage.ForeColor = Color.White; //Sets the label color to white
                main.lblDrivePercentage.Text = "This drive is not ready"; //Changes the label to read the drive is not ready

            }

            main.rtbDriveInfo.Text = driveInfo; //Set the above information on the drives to the rich text box on the form
        }
        #endregion

        

        //Some test code to get the drive type SSD HDD ect...
        private string DriveType()
        {
            ManagementScope scope = new ManagementScope(@"\\.\root\microsoft\windows\storage");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM MSFT_PhysicalDisk");
            string type = "";
            scope.Connect();
            searcher.Scope = scope;

            foreach (ManagementObject queryObj in searcher.Get())
            {
                switch (Convert.ToInt16(queryObj["MediaType"]))
                {
                    case 1:
                        type = "Unspecified";
                        return type;

                    case 3:
                        type = "HDD";
                        return type;

                    case 4:
                        type = "SSD";
                        return type;

                    case 5:
                        type = "SCM";
                        return type;

                    default:
                        type = "Unspecified";
                        return type;
                }
            }
            searcher.Dispose();

            return type;
        }
    }
}
