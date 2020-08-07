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

namespace UDiagnose
{
    public partial class splashScreen : KryptonForm
    {
        //Set counter to 0
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
            //Start the timer
            splashTimer.Start();
        }//End splashScreen_Load

        private void splashTimer_Tick(object sender, EventArgs e)
        {
            //Increment the counter
            counter++;
            //Set the value of the splash bar to equal the counter
            progSplashBar.Value = counter;
            //Check if the progress bar value equals 70
            if(progSplashBar.Value == 70)
            {
                //Start the background worker
                backgroundWorker1.RunWorkerAsync();
            }
            //Check of the progress bar equals 100
            if (progSplashBar.Value == 100)
            {
                //Stop the timer
                splashTimer.Stop();
                //Hide this form
                this.Hide();
               //Show the main form frmMain
                mainForm.Show();
            }
        }//End splashTimer_Tick

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //Stop the timer
            splashTimer.Stop();
            //Call the loadUpData method from the frmMain
            mainForm.loadUpData();

        }//End backgroundWorker1_DoWork

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Start the timer again
            splashTimer.Start();

            //Dispose of the worker
            backgroundWorker1.Dispose();
        }//End backgroundWorker1_RunWorkerCompleted
    }
}
