using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;


namespace UDiagnose.Popups
{
    public partial class frmWipe : KryptonForm
    {
        public int numPasses = 0;

        public bool canceled = false;
        public frmWipe()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            //set numPasses to the converted number from the numUpDown control
            numPasses = Convert.ToInt32(numUpDown.Value);
            //set canceled to false
            canceled = false;

            //Check that numPasses is not 0
            if(numPasses == 0)
            {
                //Error message
                MessageBox.Show("Please select a number.");
            }
            else
            {
                //Close this form
                this.Close();
            }
        }//End kryptonButton1_Click

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Set canceled to true
            canceled = true;
            //Close this form
            this.Close();
        }//End btnCancel_Click
    }
}
