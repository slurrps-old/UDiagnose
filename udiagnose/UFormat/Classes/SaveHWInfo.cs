using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO; //Used to list the drives

namespace UFormat.Classes
{
    class SaveHWInfo
    {
        private frmMain mainForm; //PDM


        public SaveHWInfo()
        {
            mainForm = new frmMain();

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

            mainForm.saveFileDialog1.FileName = "HardWare Info";
            mainForm.saveFileDialog1.DefaultExt = ".txt";

            mainForm.saveFileDialog1.Filter = "All Documents (*.docx;*.docm;*.doc;*.dotx;*.dotm;*.dot;*.htm;*.html;*.rtf;*.txt;*.pdf)|*.docx;*.docm;*.dotx;*.dotm;*.doc;*.dot;*.htm;*.html;*.rtf;*.txt;*.pdf|" +
                    "Word Documents (*.docx)|*.docx|" +
                    "Word Macro-Enabled Documents (*.docm)|*.docm|" +
                    "Word 97-2003 Documents (*.doc)|*.doc|" +
                    "Word Templates (*.dotx)|*.dotx|" +
                    "Word Macro-Enabled Templates (*.dotm)|*.dotm|" +
                    "Word 97-2003 Templates (*.dot)|*.dot|" +
                    "Web Pages (*.htm;*.html)|*.htm;*.html|" +
                    "Rich Text Format (*.rtf)|*.rtf|" +
                    "Text Files (*.txt)|*.txt|" +
                    "PDF Files (*.pdf)|*.pdf";


            mainForm.saveFileDialog1.ShowDialog();
            location = mainForm.saveFileDialog1.FileName;

            // create buffer for storing string data
            System.Text.StringBuilder buffer = new System.Text.StringBuilder();
            // loop through each of the treeview's root nodes
            foreach (TreeNode rootNode in mainForm.treeHardwareInfo.Nodes)
                // call recursive function
                BuildTreeString(rootNode, buffer);
            // write data to file

            System.IO.File.WriteAllText(location, buffer.ToString());
        }

    }
}
