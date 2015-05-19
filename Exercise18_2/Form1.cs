using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise18_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tmSwitch = new Timer(); 
            tmSwitch.Interval = 1000;
            tmSwitch.Tick += new EventHandler(tmSwitch_Tick);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (tmSwitch.Enabled)
            {
                tmSwitch.Stop();
            }
            else
            {
                tmSwitch.Start();
            }
        }

        private void tmSwitch_Tick(object sender, EventArgs e)
        {
            if (lblGreet.Text.Equals("Goodbye"))
            {
                lblGreet.Text = "Hello";                
            }
            else
            {
                lblGreet.Text = "Goodbye";
            }
        }
    }
}
