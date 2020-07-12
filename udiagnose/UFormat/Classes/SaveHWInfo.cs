using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO; //Used to list the drives

namespace UDiagnose.Classes
{
    class SaveHWInfo
    {
        private frmMain mainForm; //PDM
        

        public SaveHWInfo(frmMain form)
        {
            mainForm = form;

        }

        public void BuildTreeString(TreeNode rootNode, System.Text.StringBuilder buffer)
        {

            buffer.Append(rootNode.Text);
            buffer.Append(Environment.NewLine);

            foreach (TreeNode childNode in rootNode.Nodes)
            {
                BuildTreeString(childNode, buffer);
            }

        }


        public void SaveInfo()
        {


            string location = "";
            //Set it's name
            mainForm.saveFileDialog1.FileName = "HardWare Info ";
            //Set the extention
            mainForm.saveFileDialog1.DefaultExt = ".txt";
            //Filters that can be used for the file
            mainForm.saveFileDialog1.Filter = "Text Files|*.txt";

            //Show the dialog
            mainForm.saveFileDialog1.ShowDialog();
            //Save the filename to the variable string location
            location = mainForm.saveFileDialog1.FileName;

            // create buffer for storing string data
            System.Text.StringBuilder buffer = new System.Text.StringBuilder();
            //Add the time to the top of the file and two lines 
            buffer.Append(System.DateTime.Now.ToString());
            buffer.Append(Environment.NewLine);
            buffer.Append(Environment.NewLine);
            // loop through each of the treeview's root nodes
            foreach (TreeNode rootNode in mainForm.treeHardwareInfo.Nodes)
                // call recursive function
                BuildTreeString(rootNode, buffer);
            // write data to file
            System.IO.File.WriteAllText(location, buffer.ToString());

        }

    }
}
