using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise18_3
{
    public partial class v : Form
    {
        private double amt = 0.00;
        private double taxPercenage = 0.00;
        private double taxAmt = 0.00;
        private double total = 0.00;
 
        public v()
        {
            InitializeComponent();
            txt_Amount.Text = "0";
            numUpDow_Tax.Text = "0.00";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Amount.Text = "0";
            lbl_Result.Text = "";
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            amt = Convert.ToDouble(txt_Amount.Text);
            taxPercenage = Convert.ToDouble(numUpDow_Tax.Text);
            taxAmt = amt*(taxPercenage/100);
            total = amt + taxAmt;

            string result = string.Format("Tax on ${0:F2} at {1:F2}% is ${2:F2}\nThe total is ${3:F2}", amt, taxPercenage, taxAmt, total);
            lbl_Result.Text = result;
        }
    }
}
