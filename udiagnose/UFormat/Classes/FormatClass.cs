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
                //Go through a loop creating and deleting a file as big as the available space on the drive.
                for (int i = 0; i < 50; i++)
                {
                    CreateFile(driveLetter);
                    File.Delete(driveLetter.ToString() + @"\Secure.txt");
                }

                //Then to finish query and format given drive         
                ManagementObjectSearcher searcher = new ManagementObjectSearcher
                 (@"select * from Win32_Volume WHERE DriveLetter = '" + driveLetter + "'");
                //Format the drive with the below code.
                foreach (ManagementObject vi in searcher.Get())
                {
                    vi.InvokeMethod("Format", new object[]
                  { "NFTS", true ,8192, "Untitled" , false });
                }

                MessageBox.Show("The secure erase was successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            

            }
            else
            {
                MessageBox.Show("This has been aborted.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

        }

        #region File Wipe
        public bool WipeFile()
        {
            int timesToWrite = 0;

            frmWipe wipeTimes = new frmWipe();
            wipeTimes.ShowDialog();

            timesToWrite = wipeTimes.numPasses;

            if(wipeTimes.canceled == true)
            {
                MessageBox.Show("This has been aborted.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.ShowDialog();

                string filename = openFile.FileName;
                try
                {
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

                        MessageBox.Show("The file " +
                            filename + " has successfully been wiped.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                }
                catch (Exception ex)
                {
                    //WipeError(ex);
                }

                return true;
            }

        }

        #endregion

    }
}
