using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic4RepitionTest2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAsk_Click(object sender, EventArgs e)
        {
            DialogResult response;
            int ans, baseNum;
            int times = 1;
            baseNum = Int32.Parse(txtBase.Text);
            ans = baseNum;
            /*
            response = MessageBox.Show("Should I raise to another power?", "Keep on Powering?", MessageBoxButtons.YesNo);

            while (response == DialogResult.Yes)
            {
                ans = ans * baseNum;
                times++;
                response = MessageBox.Show("Should I raise to another power? Currently " + baseNum + "^" + times, "Keep on Powering?", MessageBoxButtons.YesNo);
            }

            */

            do
            {
                response = MessageBox.Show("Should I raise to another power? Currently " + baseNum + "^" + times, "Keep on Powering?", MessageBoxButtons.YesNo);

                if (response == DialogResult.Yes)
                {
                    ans = ans * baseNum;
                    times++;
                }
            }
            while (response == DialogResult.Yes);
            MessageBox.Show("Raised " + baseNum + " to " + ans);
        }
    }
}
