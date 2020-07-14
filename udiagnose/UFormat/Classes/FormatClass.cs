using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Management;
using UDiagnose.Forms;
using UDiagnose.Popups;

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
                enableCompression = drivedetails.compression;

                if(drivedetails.canceled == true)
                {
                    MessageBox.Show("Format has been aborted.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    try
                    {
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
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Format has been aborted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                
                
            }
            //Else quit the process.
            else
            {
                return false;
            }

        }

        public void CreateFile(string drive_letter)
        {
            //Here we will set a couple variables.
            DriveInfo di = new DriveInfo(drive_letter); //Set the drive information as a new instance di

            string fileName = drive_letter + @"\Secure.txt";

            using (var fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                fileStream.SetLength(di.AvailableFreeSpace);
            }
        }

        public bool SecureFormat(string driveLetter)
        {
            //Make sure that the user knows the repercussions.
            DialogResult result = MessageBox.Show("Are you sure you want to format, this can damage the data on your drive."
                + driveLetter + " ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //If Yes go ahead with the format
            if (result == DialogResult.Yes)
            {
                frmSecurepopup secure = new frmSecurepopup();
                secure.ShowDialog();
                bool isFormated = false;
                int numtimes = 0;

                numtimes = secure.numPasses;
                isFormated = secure.isFormated;

                if(secure.canceled == true)
                {
                    MessageBox.Show("This has been aborted.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    if (isFormated == true)
                    {
                        //query and format given drive         
                        ManagementObjectSearcher searcher = new ManagementObjectSearcher
                         (@"select * from Win32_Volume WHERE DriveLetter = '" + driveLetter + "'");
                        //Format the drive with the below code.
                        foreach (ManagementObject vi in searcher.Get())
                        {
                            vi.InvokeMethod("Format", new object[]
                          { "NFTS", true ,8192, "Untitled" , false });
                        }
                    }

                    for (int i = 0; i < numtimes; i++)
                    {
                        CreateFile(driveLetter);
                        File.Delete(driveLetter.ToString() + @"\Secure.txt");
                    }


                    MessageBox.Show("The secure erase was successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                
            }
            else
            {
                MessageBox.Show("This has been aborted.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

        }

    }
}
