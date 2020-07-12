using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Management;
using UDiagnose.Forms;

namespace UDiagnose.Classes
{
    class FormatClass
    {

        public FormatClass()
        {

        }

        public bool FormatDrive(string driveLetter, string fileSystem = "NTFS", bool quickFormat = true, int clusterSize = 8192, string label = "", bool enableCompression = false)
        {
            //Set an instance of the frmPopup form
            frmPopup drivedetails = new frmPopup();

            //Check to make sure the drive letter is correctly formatted.
            if (driveLetter.Length != 2 || driveLetter[1] != ':' || !char.IsLetter(driveLetter[0]))
                return false;

            //Make sure that the user knows the repercussions.
            DialogResult result = MessageBox.Show("Are you sure you want to format, this will permenantly delete any information on the drive." 
                + driveLetter + " ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //If Yes go ahead with the format
            if (result == DialogResult.Yes)
            {
                //Show the popup form
                drivedetails.ShowDialog();
                //Get the variables from the popup forms details.
                label = drivedetails.VolumeLabel;
                fileSystem = drivedetails.fileSystem;
                quickFormat = drivedetails.quickFormat;
                clusterSize = drivedetails.allocationSize;

                //query and format given drive         
                ManagementObjectSearcher searcher = new ManagementObjectSearcher
                 (@"select * from Win32_Volume WHERE DriveLetter = '" + driveLetter + "'");
                //Format the drive with the below code.
                foreach (ManagementObject vi in searcher.Get())
                {
                    vi.InvokeMethod("Format", new object[]
                  { fileSystem, quickFormat,clusterSize, label, enableCompression });
                }

                MessageBox.Show("Format Complete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            //Else quit the process.
            else
            {
                MessageBox.Show("This has been aborted.");
                return false;
            }

        }
    }
}
