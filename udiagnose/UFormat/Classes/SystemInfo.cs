//Author: http://www.codescratcher.com/windows-forms/get-computer-hardware-information-using-c/
//I have used some form of the code here to achieve the proper hardware information to be pulled.
//This helped me figure out how to query the information from the Operating system.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;

namespace UDiagnose
{
    //Author: Kenneth Lamb
    //Purpose:  This class contains the definiton of a SystemInfo class. It contains no private variables however 
    // it does contain 21 methods that pull the computer hardware information from the system the application is on
    //There may be more added on as more hardware info is requested in the program
    //This uses System.Management so that you can Query the WMI Classes on windows.
    // A summary of the methods appears below:
    // 
    // Assumptions: That the locations for the readings will be in the same place
    //
    // Exception Handling: None as all of the queries are properly made to always inquire the appropriate information from the OS
    //
    // Summary of Methods:


    class SystemInfo
    {
        //Default constructor
        //Pre: Object has been instantiated
        //Post: Class has been initialized does not need anything
        //Purpose: initialized a class object
        public SystemInfo()
        {
            //Default contructor
            //This class needs nothing to be inputted as it is just an inquiry class to search information.
        }

        #region OS Region
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //OS Information
        //Retrieves OS information
        protected string GetOSInformation()
        {

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return ((string)wmi["Caption"]).Trim() + ", " + (string)wmi["Version"] + ", " + (string)wmi["OSArchitecture"];
                }
                catch { }
            }
            return "BIOS Maker: Unknown";
        }
        #endregion

        #region CPU Information
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //CPU Information ------------------------------------------------------------
        //Retrieves processorID
        static ManagementClass mcCpu = new ManagementClass("win32_processor");
        ManagementObjectCollection mocCpu = mcCpu.GetInstances();

        protected String GetProcessorId()
        {
            String Id = String.Empty;
            foreach (ManagementObject mo in mocCpu)
            {

                Id = mo.Properties["processorID"].Value.ToString();
                break;
            }
            return Id;

        }

        //Retrieves processor information
        protected String GetProcessorInformation()
        {
            String info = String.Empty;
            foreach (ManagementObject mo in mocCpu)
            {
                string name = (string)mo["Name"];
                name = name.Replace("(TM)", "™").Replace("(tm)", "™").Replace("(R)", "®").Replace("(r)", "®").Replace("(C)", "©").Replace("(c)", "©").Replace("    ", " ").Replace("  ", " ");

                info = name;
                //mo.Properties["Name"].Value.ToString();
                //break;
            }
            return info;
        }

        //Processor sub information
        protected string GetProcessorSubInfo()
        {
            String info = String.Empty;
            foreach (ManagementObject mo in mocCpu)
            {
                info = (string)mo["Caption"] + ", " + (string)mo["SocketDesignation"];
            }

            return info;
        }

        //Retrieves processor speed
        protected double GetCpuMaxSpeedInGHz()
        {
            double GHz = 0.0;
            using (mcCpu)
            {
                foreach (ManagementObject mo in mocCpu)
                {
                    GHz = 0.001 * (UInt32)mo.Properties["MaxClockSpeed"].Value;
                    break;
                }
            }
            return GHz;
        }

        //Retrieves Processor all levels of cache
        protected int[] GetCache()
        {
            int[] cache = new int[3];

            using (ManagementClass mc = new ManagementClass("Win32_CacheMemory"))
            {
                int i = 0;
                foreach (ManagementObject mo in mc.GetInstances())
                {
                    cache[i] += (Convert.ToInt32(mo.Properties["MaxCacheSize"].Value));

                    i++;
                    //break;
                }
            }
            return cache;
        }

        //Get Revision of CPU
        protected Int16 GetProcessorRevision()
        {
            Int16 revision = 0;
            using (mcCpu)
            {
                foreach (ManagementObject mo in mocCpu)
                {
                    revision = (Convert.ToInt16(mo.Properties["Revision"].Value));
                    break;
                }
            }
            return revision;

        }

        //Get Virtualization Boolean
        protected bool GetVirtualization()
        {
            bool isVirtualized = false;
            using (mcCpu)
            {
                foreach (ManagementObject mo in mocCpu)
                {
                    isVirtualized = (Convert.ToBoolean(mo.Properties["VirtualizationFirmwareEnabled"].Value));
                    break;
                }
            }
            return isVirtualized;
        }

        //Retrieves the number of cores on a CPU
        protected int GetNumberCores()
        {
            int cores = 0;

            foreach (ManagementObject obj in mocCpu)
            {
                cores = Convert.ToInt32(obj.Properties["NumberOfCores"].Value.ToString());
            }

            return cores;
        }

        //Retrieves the number of threads on a CPU
        protected int GetNumberThreads()
        {
            int threads = 0;

            foreach (ManagementObject obj in mocCpu)
            {
                threads = Convert.ToInt32(obj.Properties["ThreadCount"].Value.ToString());
            }

            return threads;
        }

        //Retrieves the CPU Load
        protected double GetLoadInfo()
        {
            double load = 0.00;

            foreach (ManagementObject mo in mocCpu)
            {
                load = Convert.ToDouble(mo.Properties["LoadPercentage"].Value);
            }

            return load;
        }

        ////////////////////////////////////////////////////////////////////////
        //Retrieves current clock speed of cpu
        protected double GetCPUCurrentClockSpeed()
        {
            double cpuClockSpeed = 0;
            //start our loop for all processors found
            foreach (ManagementObject obj in mocCpu)
            {
                if (cpuClockSpeed == 0)
                {
                    // only return cpuStatus from first CPU
                    cpuClockSpeed = 0.001 * (UInt32)(obj.Properties["CurrentClockSpeed"].Value);
                }
            }
            //return the status
            return cpuClockSpeed;
        }
        #endregion

        #region RAM Information
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //RAM Information---------------------------------------------------------------------------
        //Gets the physical memory amount installed into the computer

        static ManagementClass mcRAM = new ManagementClass("Win32_PhysicalMemory");
        ManagementObjectCollection mocRAM = mcRAM.GetInstances();
        protected long GetPhysicalMemory()
        {
            
            long MemSize = 0;
            long mCap = 0;

            // In case more than one Memory sticks are installed
            foreach (ManagementObject mo in mocRAM)
            {
                mCap = Convert.ToInt64(mo["Capacity"]);
                MemSize += mCap;
            }
            MemSize = (MemSize / 1024) / 1024;
            return MemSize;
        }

        //Gets the number of ram slots on the computer
        protected string GetNoRamSlots()
        {

            int MemSlots = 0;
            ManagementScope oMs = new ManagementScope();
            ObjectQuery oQuery2 = new ObjectQuery("SELECT MemoryDevices FROM Win32_PhysicalMemoryArray");
            ManagementObjectSearcher oSearcher2 = new ManagementObjectSearcher(oMs, oQuery2);
            ManagementObjectCollection oCollection2 = oSearcher2.Get();
            foreach (ManagementObject obj in oCollection2)
            {
                MemSlots = Convert.ToInt32(obj["MemoryDevices"]);

            }
            return MemSlots.ToString();
        }

        //Ram Speed
        protected int GetRAMSpeed()
        {
            int clockSpeed = 0;

            foreach (ManagementObject mo in mocRAM)
            {
                clockSpeed = Convert.ToInt32(mo["ConfiguredClockSpeed"]);

            }
            return clockSpeed;
        }

        //Ram Manufacturer
        protected string GetRAMManufact()
        {
            foreach (ManagementObject mo in mocRAM)
            {
                try
                {
                    return mo.GetPropertyValue("Manufacturer").ToString();
                }
                catch { }
            }

            return "RAM Maker: Unknown";
        }
        #endregion

        #region Motherboard Information
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Motherboard Information
        static ManagementClass mcMobo = new ManagementClass("win32_BaseBoard");
        ManagementObjectCollection mocMobo = mcMobo.GetInstances();
        //Mobo Maker
        protected string GetBoardMaker()
        {

            
            String Id = String.Empty;
            foreach (ManagementObject mo in mocMobo)
            {

                Id = mo.Properties["Manufacturer"].Value.ToString();
                break;
            }
            return Id;

        }

        //Mobo Product ID
        protected string GetBoardProductId()
        {
                        
            String Id = String.Empty;
            foreach (ManagementObject mo in mocMobo)
            {

                Id = mo.Properties["Product"].Value.ToString();
                break;
            }
            return Id;

        }

        //Get Motherboard Serial number
        protected string GetBoardSerialNumber()
        {
            String Id = String.Empty;
            foreach (ManagementObject mo in mocMobo)
            {

                Id = mo.Properties["SerialNumber"].Value.ToString();
                break;
            }
            return Id;

        }
        #endregion

        #region BIOS Information
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Bios Information
        static ManagementClass mcBIOS = new ManagementClass("Win32_BIOS");
        ManagementObjectCollection mocBIOS = mcBIOS.GetInstances();
        //Retrieves BIOS Maker
        protected string GetBIOSmaker()
        {

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");

            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Manufacturer").ToString();
                }
                catch { }
            }
            return "BIOS Maker: Unknown";
        }

        //BIOS Serial Number
        protected string GetBIOSVersion()
        {
            
            String Id = String.Empty;
            foreach (ManagementObject mo in mocBIOS)
            {

                Id = mo.Properties["Version"].Value.ToString();
                break;
            }
            return Id;

        }

        //BIOS Caption
        protected string GetBIOScaption()
        {

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");

            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Caption").ToString();
                }
                catch { }
            }
            return "BIOS Caption: Unknown";
        }
        #endregion

        #region GPU Information
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //GPU Information
        static ManagementClass mcGPU = new ManagementClass("Win32_VideoController");
        ManagementObjectCollection mocGPU = mcGPU.GetInstances();
        //In process of being worked on

        protected string GetGPUInformation() //Gets the processor information
        {
            string strGPU = "";

            

            foreach (ManagementObject mo in mocGPU)
            {
                strGPU = mo.Properties["VideoProcessor"].Value.ToString();
            }

            return strGPU;
        }

        //GPU Name
        protected string GetGPUName() //Gets the GPU name
        {
            string strGPUName = "";

            foreach (ManagementObject obj in mocGPU)
            {
                strGPUName = obj.Properties["Name"].Value.ToString();
            }

            return strGPUName;

        }

        //GPU Driver
        protected string GetGPUDriver() //Gets the driver installed
        {
            string strGPUDriver = "";

            foreach (ManagementObject obj in mocGPU)
            {
                strGPUDriver = obj.Properties["DriverVersion"].Value.ToString();
            }

            return strGPUDriver;

        }

        //Get Driver Date
        protected string GetDriverDate()
        {
            string driverDate = "";
            DateTime date = System.DateTime.Now;
            ManagementObjectSearcher gpuDriver = new ManagementObjectSearcher("select * from Win32_VideoController");

            foreach (ManagementObject obj in gpuDriver.Get())
            {
                driverDate = (obj.Properties["DriverDate"].Value.ToString());
            }

            int pos = 0;
            pos = driverDate.IndexOf(".");
            driverDate = driverDate.Substring(0, pos);
            driverDate = driverDate.Remove(8, 6);

            return driverDate;
        }

        //Get Max Memory Supported
        #endregion

    }//End SystemInfo Class

}//End Namespace
