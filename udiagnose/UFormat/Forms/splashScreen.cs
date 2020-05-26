using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UFormat;
using System.Threading;
using HardwareDisplay;
using ComponentFactory.Krypton.Toolkit;

namespace UFormat
{
    public partial class splashScreen : KryptonForm
    {
        int counter = 0;

        /// <summary>
        /// Brandons public initialization for frmMain that allows the program to show and hide the form without 
        /// having to create new instances every time it is called.
        /// </summary>
        public static frmMain mainForm = new frmMain();

        public splashScreen()
        {
            InitializeComponent();
        }

        private void splashScreen_Load(object sender, EventArgs e)
        {
            splashTimer.Start();


        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {

            counter++;

            progSplashBar.Value = counter;
            
            if(progSplashBar.Value == 70)
            {
                backgroundWorker1.RunWorkerAsync();
            }

            if (progSplashBar.Value == 100)
            {
                splashTimer.Stop();
                
                
                this.Hide();
               
                mainForm.Show();
                
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            splashTimer.Stop();

            mainForm.loadUpData();
           
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            splashTimer.Start();
        }
    }
}
