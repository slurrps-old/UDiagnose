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
    // it does contain 20 methods that pull the computer hardware information from the system the application is on
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
        protected String GetProcessorId()
        {

            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String Id = String.Empty;
            foreach (ManagementObject mo in moc)
            {

                Id = mo.Properties["processorID"].Value.ToString();
                break;
            }
            return Id;

        }

        //Retrieves processor information
        protected String GetProcessorInformation()
        {
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String info = String.Empty;
            foreach (ManagementObject mo in moc)
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
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String info = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                info = (string)mo["Caption"] + ", " + (string)mo["SocketDesignation"];
            }

            return info;
        }

        //Retrieves processor speed
        protected double GetCpuMaxSpeedInGHz()
        {
            double GHz = 0.0;
            using (ManagementClass mc = new ManagementClass("Win32_Processor"))
            {
                foreach (ManagementObject mo in mc.GetInstances())
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
            using (ManagementClass mc = new ManagementClass("Win32_Processor"))
            {
                foreach (ManagementObject mo in mc.GetInstances())
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
            using (ManagementClass mc = new ManagementClass("Win32_Processor"))
            {
                foreach (ManagementObject mo in mc.GetInstances())
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
            ManagementObjectSearcher cpuCore = new ManagementObjectSearcher("select NumberOfCores from Win32_Processor");

            foreach (ManagementObject obj in cpuCore.Get())
            {
                cores = Convert.ToInt32(obj.Properties["NumberOfCores"].Value.ToString());
            }

            return cores;
        }

        //Retrieves the number of threads on a CPU
        protected int GetNumberThreads()
        {
            int threads = 0;
            ManagementObjectSearcher cpuThread = new ManagementObjectSearcher("select NumberOfCores from Win32_Processor");

            foreach (ManagementObject obj in cpuThread.Get())
            {
                threads = Convert.ToInt32(obj.Properties["NumberOfCores"].Value.ToString());
            }

            return threads;
        }

        //Retrieves the CPU Load
        protected double GetLoadInfo()
        {
            double load = 0.00;

            ManagementClass mgmt = new ManagementClass("Win32_Processor");
            ManagementObjectCollection objCol = mgmt.GetInstances();

            foreach (ManagementObject obj in objCol)
            {
                load = Convert.ToDouble(obj.Properties["LoadPercentage"].Value);
            }

            return load;
        }

        ////////////////////////////////////////////////////////////////////////
        //Retrieves current clock speed of cpu
        protected double GetCPUCurrentClockSpeed()
        {
            double cpuClockSpeed = 0;
            //create an instance of the Managemnet class with the
            //Win32_Processor class
            ManagementClass mgmt = new ManagementClass("Win32_Processor");
            //create a ManagementObjectCollection to loop through
            ManagementObjectCollection objCol = mgmt.GetInstances();
            //start our loop for all processors found
            foreach (ManagementObject obj in objCol)
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
        protected long GetPhysicalMemory()
        {
            ManagementScope oMs = new ManagementScope();
            ObjectQuery oQuery = new ObjectQuery("SELECT Capacity FROM Win32_PhysicalMemory");
            ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(oMs, oQuery);
            ManagementObjectCollection oCollection = oSearcher.Get();

            long MemSize = 0;
            long mCap = 0;

            // In case more than one Memory sticks are installed
            foreach (ManagementObject obj in oCollection)
            {
                mCap = Convert.ToInt64(obj["Capacity"]);
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

            ManagementScope oMs = new ManagementScope();
            ObjectQuery oQuery3 = new ObjectQuery("select ConfiguredClockSpeed from Win32_PhysicalMemory");
            ManagementObjectSearcher oSearcher2 = new ManagementObjectSearcher(oMs, oQuery3);
            ManagementObjectCollection oCollection2 = oSearcher2.Get();
            foreach (ManagementObject obj in oCollection2)
            {
                clockSpeed = Convert.ToInt32(obj["ConfiguredClockSpeed"]);

            }
            return clockSpeed;
        }

        //Ram Manufacturer
        protected string GetRAMManufact()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select Manufacturer from Win32_PhysicalMemory");

            foreach (ManagementObject obj in searcher.Get())
            {
                try
                {
                    return obj.GetPropertyValue("Manufacturer").ToString();
                }
                catch { }
            }

            return "RAM Maker: Unknown";
        }
        #endregion

        #region Motherboard Information
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Motherboard Information

        //Mobo Maker
        protected string GetBoardMaker()
        {

            ManagementClass mc = new ManagementClass("win32_BaseBoard");
            ManagementObjectCollection moc = mc.GetInstances();
            String Id = String.Empty;
            foreach (ManagementObject mo in moc)
            {

                Id = mo.Properties["Manufacturer"].Value.ToString();
                break;
            }
            return Id;

        }

        //Mobo Product ID
        protected string GetBoardProductId()
        {

            ManagementClass mc = new ManagementClass("win32_BaseBoard");
            ManagementObjectCollection moc = mc.GetInstances();
            String Id = String.Empty;
            foreach (ManagementObject mo in moc)
            {

                Id = mo.Properties["Product"].Value.ToString();
                break;
            }
            return Id;

        }

        //Get Motherboard Serial number
        protected string GetBoardSerialNumber()
        {

            ManagementClass mc = new ManagementClass("win32_BaseBoard");
            ManagementObjectCollection moc = mc.GetInstances();
            String Id = String.Empty;
            foreach (ManagementObject mo in moc)
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
            ManagementClass mc = new ManagementClass("Win32_BIOS");
            ManagementObjectCollection moc = mc.GetInstances();
            String Id = String.Empty;
            foreach (ManagementObject mo in moc)
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
        //In process of being worked on

        protected string GetGPUInformation() //Gets the processor information
        {
            string strGPU = "";

            ManagementObjectSearcher gpu = new ManagementObjectSearcher("select * from Win32_VideoController");

            foreach (ManagementObject mo in gpu.Get())
            {
                strGPU = mo.Properties["VideoProcessor"].Value.ToString();
            }

            return strGPU;
        }

        //GPU Name
        protected string GetGPUName() //Gets the GPU name
        {
            string strGPUName = "";

            ManagementObjectSearcher gpuName = new ManagementObjectSearcher("select Name from Win32_VideoController");

            foreach (ManagementObject obj in gpuName.Get())
            {
                strGPUName = obj.Properties["Name"].Value.ToString();
            }

            return strGPUName;

        }

        //GPU Driver
        protected string GetGPUDriver() //Gets the driver installed
        {
            string strGPUDriver = "";

            ManagementObjectSearcher gpuDriver = new ManagementObjectSearcher("select DriverVersion from Win32_VideoController");

            foreach (ManagementObject obj in gpuDriver.Get())
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
