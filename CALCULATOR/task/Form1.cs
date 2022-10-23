using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int i = 0;
        private void one_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                result.Text = "1";
                i = 1;
            }
            else
            {
                result.Text += "1";
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                result.Text = "2";
                i = 1;
            }
            else
            {
                result.Text += "2";
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                result.Text = "3";
                i = 1;
            }
            else
            {
                result.Text += "3";
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                result.Text = "4";
                i = 1;
            }
            else
            {
                result.Text += "4";
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                result.Text = "5";
                i = 1;
            }
            else
            {
                result.Text += "5";
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                result.Text = "6";
                i = 1;
            }
            else
            {
                result.Text += "6";
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                result.Text = "7";
                i = 1;
            }
            else
            {
                result.Text += "7";
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                result.Text = "8";
                i = 1;
            }
            else
            {
                result.Text += "8";
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                result.Text = "9";
                i = 1;
            }
            else
            {
                result.Text += "9";
            }
        }

        private void buttonzero_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                result.Text = "0";
                i = 1;
            }
            else
            {
                result.Text += "0";
            }
        }

        private void point_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                result.Text = ".";
                i = 1;
            }
            else if(!result.Text.Contains("."))
            {
                result.Text += ".";
            }
        }
        double num1 = 0.0, num2 = 0.0;
        string op = "";

        private void buttonminus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(result.Text))
            {
                num1 = Convert.ToDouble(result.Text);
                op = "-";
                i = 0;
            }
        }

        private void buttonmultiplication_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(result.Text))
            {
                num1 = Convert.ToDouble(result.Text);
                op = "*";
                i = 0;
            }
        }

        private void buttondivision_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(result.Text))
            {
                num1 = Convert.ToDouble(result.Text);
                op = "/";
                i = 0;
            }
        }
        double res = 0.0;
        private void equal_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(result.Text) && op!="" && result.Text != ".")
            {
                num2 = Convert.ToDouble(result.Text);
                if (op == "+")
                { 
                    res = num1 + num2; 
                }
                else if (op == "-")
                {
                    res = num1 - num2;
                }
                else if (op == "*")
                {
                    res = num1 * num2;
                }
                else if (op == "/")
                {
                    res = num1 / num2;
                }
                result.Text = res.ToString();

            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(result.Text))
            {
                result.Text = result.Text.Remove(result.Text.Length - 1);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            result.Text = null;
            num1 = 0.0;
            num2 = 0.0;
            i = 0;
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(result.Text) && result.Text !=".")
                {
                num1 = Convert.ToDouble(result.Text);
                op = "+";
                i = 0;
            }
        }
    }
}
