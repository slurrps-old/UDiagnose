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
using System.Security.Cryptography;
using System.Threading;

namespace UDiagnose.Classes
{
    class FormatClass
    {
        //Author: Kenneth Lamb
        //Purpose:  This clas handles the formatting of the drives algorithms
        // 
        // Assumptions: 
        //
        // Exception Handling: 
        //
        // Summary of Methods:

        //Instances of the Forms needed
        public frmPopup drivedetails = new frmPopup();
        public frmWait wait = new frmWait();

        public FormatClass()
        {

        }

        #region FormatDrives
        public bool FormatDrive(string driveLetter, string fileSystem = "NTFS", bool quickFormat = true, int clusterSize = 8192, string label = "", bool enableCompression = false)
        {
            //Set an instance of the frmPopup form
            

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

                //Check if the process has been canceled
                if(drivedetails.canceled == true)
                {
                    MessageBox.Show("Format has been aborted.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    Thread sf = new Thread(new ThreadStart(showWait));
                    sf.Start();
                    //Try and format the drive
                    try
                    {
                        //query and format given drive         
                        ManagementObjectSearcher searcher = new ManagementObjectSearcher
                         (@"select * from Win32_Volume WHERE DriveLetter = '" + driveLetter + "'");
                        //Format the drive with the below code.
                        foreach (ManagementObject vi in searcher.Get())
                        {
                            //Invoke the format method
                            vi.InvokeMethod("Format", new object[]
                          { fileSystem, quickFormat,clusterSize, label, enableCompression });
                        }
                        //Message complete
                        //close thread
                        sf.Abort();
                        //Call the new wait window
                        updateWait();

                        return true;
                    }
                    catch
                    {
                        //Error message
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

        private void showWait()
        {
            //set the button to be invisable
            wait.btnAccept.Visible = false;
            //Show form
            wait.ShowDialog();
        }

        public void updateWait()
        {
            //Change the text
            wait.lblMessage.Text = "Success, your format is complete.";
            //set button to be visable
            wait.btnAccept.Visible = true;
            //Show form
            wait.ShowDialog();
        }
        #endregion

        #region SecureWipe
        public void CreateFile(string directory, byte num)
        {
            //Create the file name
            string fileName = directory + @"\Secure.txt";
            //create the filestream
            FileStream fs = new FileStream(fileName, FileMode.CreateNew);
            //set the current position and the offset
            fs.Seek(2048L * 1024 * 1024, SeekOrigin.Begin);
            //write the byte to the file
            fs.WriteByte(num);
            //Close the stream
            fs.Close();

        }

        public bool SecureFormat(string driveLetter)
        {
            DriveInfo di = new DriveInfo(driveLetter); //Set the drive information as a new instance di

            //Check if the Drive is removable
            if (di.DriveType.ToString() == "removable")
            {
                //Give warning to the user about the feature
                MessageBox.Show("Warning this feature is stil experimental and may not work properly please be careful.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //Here we will set a couple variables.
                int num = 0; //Holds the num to add to the filename
                byte bt = 0; //Holds the byte for the file creation
                
                Random rng = new Random(); //Random number to be generated for the final loop

                //Make sure that the user knows the repercussions.
                DialogResult result = MessageBox.Show("Are you sure you want to format, this can damage the data on your drive."
                    + driveLetter + " ? Please be aware that doing this will take a while. Please do NOT use this on an SSD as this can damage the flash chips!"
                    , "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                //If Yes go ahead with the format
                if (result == DialogResult.Yes)
                {
                    //Create a new directory holding the files
                    CreateDirectory(driveLetter);

                    //Loop 7 times in total-----
                    //Loop 1 byte = 0
                    CreateFile(driveLetter + @"\SecureErase", bt);
                    for (int i = 0; i >= 3; i++)
                    {
                        while (di.AvailableFreeSpace > 2147483648)
                        {
                            num++;
                            File.Copy(driveLetter + @"\SecureErase\Secure.txt", driveLetter + @"\SecureErase\Secure" + num.ToString() + ".txt", true);
                        }

                        File.Delete(driveLetter.ToString() + @"\SecureErase");
                    }
                    //recreate directory
                    CreateDirectory(driveLetter);
                    //Loop 2 byte = 1
                    bt = 1;
                    CreateFile(driveLetter + @"\SecureErase", bt);
                    for (int i = 0; i >= 3; i++)
                    {
                        while (di.AvailableFreeSpace > 2147483648)
                        {
                            num++;
                            File.Copy(driveLetter + @"\SecureErase\Secure.txt", driveLetter + @"\SecureErase\Secure" + num.ToString() + ".txt", true);
                        }

                        File.Delete(driveLetter.ToString() + @"\SecureErase");
                    }
                    //Recreate directory
                    CreateDirectory(driveLetter);
                    //Loop 3 byte = random
                    bt = Convert.ToByte(rng.Next(1, 10));
                    CreateFile(driveLetter + @"\SecureErase", bt);
                    for (int i = 0; i >= 1; i++)
                    {
                        while (di.AvailableFreeSpace > 2147483648)
                        {
                            num++;
                            File.Copy(driveLetter + @"\SecureErase\Secure.txt", driveLetter + @"\SecureErase\Secure" + num.ToString() + ".txt", true);
                        }

                        File.Delete(driveLetter.ToString() + @"\SecureErase");
                    }
                    //End loops-----

                    MessageBox.Show("The secure erase was successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;


                }
                else //Abort
                {
                    MessageBox.Show("This has been aborted.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            else //Throw an error
            {
                MessageBox.Show("This is not a removable drive. This operation will only work for removable drives. Please select again",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void CreateDirectory(string driveLetter)
        {
            //Create a new directory holding the files
            DirectoryInfo directory = Directory.CreateDirectory(driveLetter + @"\SecureErase");
        }
        #endregion

        #region File Wipe
        public bool WipeFile()
        {
            //Holds the times to overwrite the file
            int timesToWrite = 0;
            //Set instance of the popup to get the timesToWrite
            frmWipe wipeTimes = new frmWipe();
            wipeTimes.ShowDialog();
            //Set timesToWrite to the number from the popup
            timesToWrite = wipeTimes.numPasses;

            //Check to see if this has been canceled
            if(wipeTimes.canceled == true)
            {
                MessageBox.Show("This has been aborted.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                //Set an instance of openfiledialog and show it
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.ShowDialog();

                //Get the filename from the dialog
                string filename = openFile.FileName;

                //Try to wipe the file
                try
                {
                    //Check if the file exists
                    if (File.Exists(filename))
                    {
                        // Set the files attributes to normal in case it's read-only.

                        File.SetAttributes(filename, FileAttributes.Normal);

                        // Calculate the total number of sectors in the file.
                        double sectors = Math.Ceiling(new FileInfo(filename).Length / 512.0);

                        // Create a dummy-buffer the size of a sector.

                        byte[] dummyBuffer = new byte[512];

                        // Create a cryptographic Random Number Generator.
                        // This is what I use to create the garbage data.

                        RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

                        // Open a FileStream to the file.
                        FileStream inputStream = new FileStream(filename, FileMode.Open);
                        for (int currentPass = 0; currentPass < timesToWrite; currentPass++)
                        {
                            //UpdatePassInfo(currentPass + 1, timesToWrite);

                            // Go to the beginning of the stream

                            inputStream.Position = 0;

                            // Loop all sectors
                            for (int sectorsWritten = 0; sectorsWritten < sectors; sectorsWritten++)
                            {
                                //UpdateSectorInfo(sectorsWritten + 1, (int)sectors);

                                // Fill the dummy-buffer with random data

                                rng.GetBytes(dummyBuffer);

                                // Write it to the stream
                                inputStream.Write(dummyBuffer, 0, dummyBuffer.Length);
                            }
                        }

                        // Truncate the file to 0 bytes.
                        // This will hide the original file-length if you try to recover the file.

                        inputStream.SetLength(0);

                        // Close the stream.
                        inputStream.Close();

                        // As an extra precaution I change the dates of the file so the
                        // original dates are hidden if you try to recover the file.

                        DateTime dt = new DateTime(2037, 1, 1, 0, 0, 0);
                        File.SetCreationTime(filename, dt);
                        File.SetLastAccessTime(filename, dt);
                        File.SetLastWriteTime(filename, dt);

                        // Finally, delete the file

                        File.Delete(filename);

                        //Success message
                        MessageBox.Show("The file " +
                            filename + " has successfully been wiped.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    //WipeError(ex);
                }

                return true;
            }
        }
        #endregion

    }
}
