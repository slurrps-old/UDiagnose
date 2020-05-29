using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDiagnose;
using System.Windows.Forms;
using System.Management;

namespace HardwareDisplay
{
    class Hardware: SystemInfo
    {
        
        //------------------------------------------------------------------------------------
        //Search PDM's to load up the data required for the FillTree method
        //to be searched on a separate thread than the UI
        //OS
        private string OSInfo;
        //Processor
        private string processorInfo;
        private string processorSubInfo;
        private string processorID;
        private string numCores;
        private string numThreads;
        private string cpuSpeed;
        private string l2Cache;
        private string l3Cache;
        //Mobo
        private string manufacturerMobo;
        private string baseboard;
        //Bios
        private string biosMaker;
        private string biosSerial;
        private string biosCaption;
        //RAM
        private string ramManufacturer;
        private string ramInstalled;
        private string ramSpeed;
        private string slotsOnBoard;
        //GPU
        private string gpuName;
        private string gpuDriver;
        private string gpuInfo;


        //--------------------------------------------------------------------------------------------------------
        //Default Constructor
        public Hardware()
        {
            
        }

        //Non-Default Constructor
        public Hardware(frmMain frmMain)
        {
            
        }

        //--------------------------------------------------------------------------------------------------------
        //This function will load up the data required for FillTree method
        public void TreeViewHardware()
        {

            //In this method we will be querying all of the data that we would like to 
            //show in the treeview and setting it to the appropriate variable

            //OS Info
            OSInfo = (GetOSInformation());
            //CPU info
            processorInfo = (GetProcessorInformation());
            processorSubInfo = (GetProcessorSubInfo());
            processorID = ("Processor ID: " + GetProcessorId());
            numCores = ("Number of Cores: " + GetNumberCores().ToString());
            numThreads = ("Number of Threads: " + GetNumberThreads().ToString());
            cpuSpeed = ("Speed: " + GetCpuMaxSpeedInGHz().ToString("0.00") + " GHz");
            l2Cache = ("L2 Cache: " + GetL2Cache().ToString() + " KB");
            l3Cache = ("L3 Cache: " + GetL3Cache().ToString() + " MB");

            //Mobo info
            manufacturerMobo = ("Manufacturer: " + GetBoardMaker());
            baseboard = ("Baseboard Product: " + GetBoardProductId());
            //BIOS info
            biosMaker = ("Maker: " + GetBIOSmaker());
            biosSerial = ("Serial Number: " + GetBIOSserNo());
            biosCaption = (GetBIOScaption());
            //RAM info
            ramManufacturer = ("Manufacturer: " + GetRAMManufact()); //RAM Maker
            ramInstalled = ("RAM Installed: " + GetPhysicalMemory().ToString() + " MB"); //Amount installed
            ramSpeed = ("Speed: " + GetRAMSpeed().ToString() + " GHz"); //Clock speed
            slotsOnBoard = ("Dimm slots on board: " + GetNoRamSlots()); //Dimm slots on board

            //GPU info
            gpuName = (GetGPUName());
            gpuDriver = ("Driver version: " + GetGPUDriver());
            gpuInfo = (GetGPUInformation());

        }//End TreeView
        //------------------------------------------------------------------------------------------------

        //This method will take all of the PDM's of the application and load them into the treeview from the main form
        //Needs to have the main form initialized to access the elements
        public void FillTreeView(frmMain mainForm)
        {
            //OS Info
            
            mainForm.treeHardwareInfo.Nodes[0].Nodes[0].Nodes.Add(OSInfo);
            //CPU info
            mainForm.treeHardwareInfo.Nodes[0].Nodes[1].Nodes.Add(processorInfo); //Processor information like the name
            mainForm.treeHardwareInfo.Nodes[0].Nodes[1].Nodes[0].Nodes.Add(processorSubInfo); //Sub info 
            mainForm.treeHardwareInfo.Nodes[0].Nodes[1].Nodes.Add(processorID);// the ID of the processor
            mainForm.treeHardwareInfo.Nodes[0].Nodes[1].Nodes.Add(numCores); //Amount of cores
            mainForm.treeHardwareInfo.Nodes[0].Nodes[1].Nodes.Add(numThreads); //Number of threads
            mainForm.treeHardwareInfo.Nodes[0].Nodes[1].Nodes.Add(cpuSpeed); //Current clock speed of the CPU
            mainForm.treeHardwareInfo.Nodes[0].Nodes[1].Nodes.Add(l2Cache); //Size of the l2 Cache
            mainForm.treeHardwareInfo.Nodes[0].Nodes[1].Nodes.Add(l3Cache); //Size of the l3 Cache

            //Mobo info
            mainForm.treeHardwareInfo.Nodes[0].Nodes[2].Nodes.Add(manufacturerMobo); //Mobo manufacturer
            mainForm.treeHardwareInfo.Nodes[0].Nodes[2].Nodes.Add(baseboard); //baseboard info
            //BIOS info
            mainForm.treeHardwareInfo.Nodes[0].Nodes[3].Nodes.Add(biosMaker);//Bios maker
            mainForm.treeHardwareInfo.Nodes[0].Nodes[3].Nodes.Add(biosSerial);//Serial of the bios
            mainForm.treeHardwareInfo.Nodes[0].Nodes[3].Nodes.Add(biosCaption);//Bios caption
            //RAM info
            mainForm.treeHardwareInfo.Nodes[0].Nodes[4].Nodes.Add(ramManufacturer); //RAM Maker
            mainForm.treeHardwareInfo.Nodes[0].Nodes[4].Nodes.Add(ramInstalled); //Amount installed
            mainForm.treeHardwareInfo.Nodes[0].Nodes[4].Nodes.Add(ramSpeed); //Clock speed
            mainForm.treeHardwareInfo.Nodes[0].Nodes[4].Nodes.Add(slotsOnBoard); //Dimm slots on board

            //GPU info
            mainForm.treeHardwareInfo.Nodes[0].Nodes[5].Nodes.Add(gpuName);//Name of the GPU
            mainForm.treeHardwareInfo.Nodes[0].Nodes[5].Nodes.Add(gpuDriver);//Driver information
            mainForm.treeHardwareInfo.Nodes[0].Nodes[5].Nodes.Add(gpuInfo);//More information on the GPU


            //Open all nodes
            mainForm.treeHardwareInfo.ExpandAll(); //Expand the treeview 
        }

        public string ProcessorName() //Hold the name of the processor in this method and return it
        {
            string info = "";
             info = GetProcessorInformation();
            return info;
        }

        public string RamInformation() //Get the RAM information in this method and return it
        {
            string info = "";
            info = GetRAMManufact() + " " + (GetPhysicalMemory() / 1024).ToString() + " GB";
            return info;
        }

        public string GPUName() //Get the RAM information in this method and return it
        {
            string info = "";
            info = GetGPUName();
            return info;
        }

    }//End Class

}//End Namespace
