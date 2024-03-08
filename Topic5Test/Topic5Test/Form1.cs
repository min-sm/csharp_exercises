using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic5Test
{
    public partial class Form1 : Form
    {
        Person p1,p2,p3;
        public Form1()
        {
            InitializeComponent();
        }

        private Person getDesiredPerson()
        {
            Person whichOne;
            int num;

            num = Int32.Parse(txtWhich.Text);

            if (num <= 1)
            {
                whichOne = p1;
            }
            else if (num >= 3)
            {
                whichOne = p3;
            }
            else
            {
                whichOne = p2;
            }
            return whichOne;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p1 = new Person();
            p2 = new Person();
            p3 = new Person();

        }

        private void cmdAdjust_Click(object sender, EventArgs e)
        {
            Person selected;
            selected = getDesiredPerson();

            int amount;
            amount = Int32.Parse(txtAmount.Text);
            selected.adjustAge(amount);
        }

        private void cmdStore_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            int age = Int32.Parse(txtAge.Text);

            Person selected;
            selected = getDesiredPerson();

            selected.Name = name;
            selected.Age = age;

            txtAge.Text = "";
            txtName.Text = "";
            txtWhich.Text = "";

        }

        private void cmdDisplay_Click(object sender, EventArgs e)
        {
            Person selected;
            selected = getDesiredPerson();
            txtYouTyped.Text = selected.Name + " " + selected.Age;
        }
    }
}
