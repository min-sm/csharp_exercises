using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic4Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdBtn_Click(object sender, EventArgs e)
        {
            lblAns.Text = "";
            int upper, div;
            upper = Int32.Parse(txtBxFirst.Text);
            div = Int32.Parse(txtBxSec.Text);

            for (int i = 0; i <= upper; i++)
            {
                if (i % div == 0)
                {
                    lblAns.Text += i + " is divisible by " + div + "\n";
                }
            }
        }
    }
}
