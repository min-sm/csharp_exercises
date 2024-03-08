using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForTopic3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            int res;
            n1 = Int32.Parse(txtNum1.Text);
            n2 = int.Parse(txtNum2.Text);
            res = n1 + n2;
            MessageBox.Show("The Additional result is " + res);
        }

        private void cmdMinus_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            int res;
            n1 = Int32.Parse(txtNum1.Text);
            n2 = int.Parse(txtNum2.Text);
            res = n1 - n2;
            MessageBox.Show("The Subtraction result is " + res);
        }

        private void cmdMultiply_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            int res;
            n1 = Int32.Parse(txtNum1.Text);
            n2 = int.Parse(txtNum2.Text);
            res = n1 * n2;
            MessageBox.Show("The Multiplication result is " + res);
        }

        private void cmdDivision_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            int res;
            n1 = Int32.Parse(txtNum1.Text);
            n2 = int.Parse(txtNum2.Text);
            res = n1 / n2;
            MessageBox.Show("The Division result is " + res);
        }

        private void cmdModulus_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            int res;
            n1 = Int32.Parse(txtNum1.Text);
            n2 = int.Parse(txtNum2.Text);
            res = n1 % n2;
            MessageBox.Show("The Modulus result is " + res);
        }
    }
}
