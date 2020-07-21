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
    public partial class frmWait : KryptonForm
    {
        public frmWait()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void btnAccept_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }//End btnAccept_Click
=======
        private void frmWait_Load(object sender, EventArgs e)
        {
            
        }

        private void lblMessage_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
>>>>>>> 8cb8c2ec58b2543b9e2be8ebfd9c6eea673b9272
    }
}
