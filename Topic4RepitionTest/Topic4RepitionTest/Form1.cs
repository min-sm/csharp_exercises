using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic4RepitionTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            int b;
            int p;
            int ans;
            b = Int32.Parse(txtBase.Text);
            p = Int32.Parse(txtPower.Text);
            ans = b;
            /*
            for (int counter = 1; counter < p; counter++)
            {
                ans = ans * b;
            }
            */
            int counter = 1;
            while (counter < p)
            {
                ans = ans * b;
                counter++;
            }

            MessageBox.Show(b + " power " + p + " is " + ans);

            
        }
    }
}
