using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic3Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdPressMe_Click(object sender, EventArgs e)
        {
            int price, age;
            price = Int32.Parse(txtPrice.Text);
            age = Int32.Parse(txtAge.Text);

            /*
            if (age < 18)
            {
                price = price / 2;
            }

            if (chkDiscount.Checked == true)
            {
                price = price / 2;
            }

            MessageBox.Show("The price is " + price);
            */

            if (chkDiscount.Checked == true && age >= 18 && age < 65)
            {
                price = price / 2;
            } 
            else
            {
                price = price * 2;
            }
            lblOutput.Text = "The price is " + price;
        }
    }
}
