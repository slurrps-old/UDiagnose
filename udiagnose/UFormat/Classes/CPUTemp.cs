//Using OpenHardware DLL to achieve this

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using OpenHardwareMonitor.Hardware;
using UFormat.Forms;

namespace UDiagnose
{
    class CPUTemp
    {
        #region OpenHardware Monitor
        UpdateVisitor updateVisitor = new UpdateVisitor(); //create a new instance of the update visitor class
        Computer computer = new Computer(); //create a new instance of the computer class
        public CPUTemp()
        {

        }

        //Method used to get the CPU temperature from the hardware sensor
        //Then return it as a float
        public float GetCPUTemp()
        {
            
            float cpuTemp = 0.0f; //Set the variable cpuTemp to 0.0f

            computer.Open(); //Open the connection to the computer class
            computer.CPUEnabled = true; //enable the cpu
            computer.Accept(updateVisitor); //use the updatevisitor to travers the cpu data
            for (int i = 0; i < computer.Hardware.Length; i++) //for loop to loop through the information
            {
                if (computer.Hardware[i].HardwareType == HardwareType.CPU) //if the type is a CPU hardware type then go into the next for loop
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++) //Go through all of the cpu hardware info
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature) //If the sensortype is a temperature sensor then do the code below
                            cpuTemp = (float)computer.Hardware[i].Sensors[j].Value; //set the cpuTemp to the hardware at level i. sensor at level j. value
                    }
                }
            }
            computer.Close();//Close the computer connection
            return cpuTemp;//Return the cpuTemp
        }

        //Here we will get the GPU temp from the hardware sensors
        //and return it as a float
        public float GetGPUTemp()
        {
            float gpuTemp = 0.0f;

            computer.Open();
            computer.GPUEnabled = true;
            computer.Accept(updateVisitor);
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.GpuAti || computer.Hardware[i].HardwareType == HardwareType.GpuNvidia)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                            gpuTemp = (float)computer.Hardware[i].Sensors[j].Value;
                    }
                }
            }
            computer.Close();
            return gpuTemp;
        }

        //This method will get the mainboard temp from the hardware sensors 
        //and return it as a float
        public float GetMainBoardTemp()
        {
            float mainBoard = 0.0f;

            computer.Open();
            computer.MainboardEnabled = true;
            computer.Accept(updateVisitor);
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.Mainboard)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                            mainBoard = (float)computer.Hardware[i].Sensors[j].Value;
                    }
                }
            }
            computer.Close();
            return mainBoard;
        }
        #endregion


        
    }
}
