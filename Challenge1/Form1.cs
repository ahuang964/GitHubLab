using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int below = Convert.ToInt32(textBox4.Text);
            int answer = calculatechallenge1(num1, num2, below);
            textBox3.Text = answer.ToString();
        }

        private int calculatechallenge1(int num1, int num2, int below)
        {
            int sum = 0;
            int baseNum1 = num1;
            int baseNum2 = num2;
            int counter = 1;
            while (num1 < below || num2 < below)
            {
                num1 = baseNum1 * counter;
                num2 = baseNum2 * counter;

                if (num1 < below)
                {
                    sum += num1;
                }
                if (num2 < below)
                {
                    sum += num2;
                }

                counter++;
            } 

            return sum;
        }
    }
}
