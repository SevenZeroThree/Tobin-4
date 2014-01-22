/* Project:     Assignment 4
 * Programmer:  Chris Tobin
 * Due Date:    4.23.2010
 * Description: A program to record the call in orders of customers for old time pizza parlor 
 *
 * Class:       Splash Form
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tobin_4
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Close the splash form when the timer ticks
            this.Close();
        }
    }
}
