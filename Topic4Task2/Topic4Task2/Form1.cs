using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic4Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            int input_multiplicand, input_multiplier;
            input_multiplicand = Int32.Parse(txtMultiplicand.Text);
            input_multiplier = Int32.Parse(txtMultiplier.Text);
            for (int i = 1; i <= input_multiplier; i++)
            {
                int ans = input_multiplicand * i;
                lblAns.Text += input_multiplicand + " * " + i + " = " + ans;
                lblAns.Text += '\n';
            }
        }
    }
}
