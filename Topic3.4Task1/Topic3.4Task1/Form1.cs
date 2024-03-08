using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic3._4Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean add, sub, mult, div;
        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            if (txtBxNum1.Text == "")
            {
                MessageBox.Show("You have to enter Num1.");
            } else if (txtBxNum2.Text == "")
            {
                MessageBox.Show("You have to enter Num2.");
            }
            else
            {
                int num1, num2;
                int res;

                num1 = Int32.Parse(txtBxNum1.Text);
                num2 = Int32.Parse(txtBxNum2.Text);
                res = 0;

                if (optAdd.Checked)
                {
                    if (add == true)
                    {
                        MessageBox.Show("Choose other");

                    }
                    res = num1 + num2;
                    add = true;
                    sub = false;
                    mult = false;
                    div = false;

                }
                else if (optSub.Checked)
                {
                    if (sub == true)
                    {
                        MessageBox.Show("Choose other");

                    }
                    res = num1 - num2;
                    add = false;
                    sub = true;
                    mult = false;
                    div = false;
                }
                else if (optMultiply.Checked)
                {
                    if (mult == true)
                    {
                        MessageBox.Show("Choose other");

                    }
                    res = num1 * num2;
                    add = false;
                    sub = false;
                    mult = true;
                    div = false;
                }
                else if (optDivision.Checked)
                {
                    if (div == true)
                    {
                        MessageBox.Show("Choose other");

                    }
                    res = num1 / num2;
                    add = false;
                    sub = false;
                    mult = false;
                    div = true;
                }
                lblAns.Text = "The calculation result is " + res;
                MessageBox.Show("hellow world");
                MessageBox.Show("" + res, "The calculation result is", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                

                if (num1 > num2)
                {
                    lblLargest.Text = "The largest number is Num1, " + num1;
                } else
                {
                    lblLargest.Text = "The largest number is Num2, " + num2;
                }

                if (num1 > res)
                {
                    lblFirstNumIs.Text = "The indicated sum is smaller than the first number";
                } else
                {
                    lblFirstNumIs.Text = "The indicated sum is greater than the first number";
                }

                if (num2 > res)
                {
                    lblSecNumIs.Text = "The indicated sum is smaller than the second number";
                }
                else
                {
                    lblSecNumIs.Text = "The indicated sum is greater than the second number";
                }

            }
        }
    }
}
