using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic5Task1
{
    public partial class Form1 : Form
    {
        StatisticalData s1, s2, s3, s4, s5;

        private StatisticalData selectedObj()
        {
            StatisticalData selected;
            int whichTxt = Int32.Parse(txtBxWhich.Text);

            if (whichTxt <= 1)
            {
                selected = s1;
            } 
            else if (whichTxt == 2)
            {
                selected = s2;
            } 
            else if (whichTxt == 3)
            {
                selected = s3;
            }
            else if (whichTxt == 4)
            {
                selected = s4;
            }
            else
            {
                selected = s5;
            }

            return selected;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            int n1, n2, n3;
            n1 = Int32.Parse(txtBx1.Text);
            n2 = Int32.Parse(txtBx2.Text);
            n3 = Int32.Parse(txtBx3.Text);

            StatisticalData selected;
            selected = selectedObj();

            selected.Num1 = n1;
            selected.Num2 = n2;
            selected.Num3 = n3;

            txtBx1.Text = "";
            txtBx2.Text = "";
            txtBx3.Text = "";
        }

        private void cmdSmallest_Click(object sender, EventArgs e)
        {
            StatisticalData selected;
            selected = selectedObj();

            txtBxRes.Text = "The largest is " + selected.findLargest().ToString() + ". The smallest is " + selected.findSmallest().ToString() + ". The average is " + selected.findAverage().ToString();

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            s1 = new StatisticalData();
            s2 = new StatisticalData();
            s3 = new StatisticalData();
            s4 = new StatisticalData();
            s5 = new StatisticalData();

        }
    }
}
