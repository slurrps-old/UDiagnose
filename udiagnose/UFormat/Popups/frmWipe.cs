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

        private void frmSecurepopup_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            numPasses = Convert.ToInt32(numUpDown.Value);
            canceled = false;

            if(numPasses == 0)
            {
                MessageBox.Show("Please select a number.");
            }
            else
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            canceled = true;
            this.Close();
        }
    }
}
