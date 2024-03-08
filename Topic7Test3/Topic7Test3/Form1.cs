using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Topic7Test3
{
    public partial class Form1 : Form
    {
        // Person[] people;
        List<Person> people;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // people = new Person[]
            people = new List<Person>();

        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            int age = Int32.Parse(txtAge.Text);
            Person p = new Person(name, age);
            people.Add(p);
            txtName.Text = "";
            txtAge.Text = "";
            MessageBox.Show("Person is added");

        }

        private void cmdFind_Click(object sender, EventArgs e)
        {
            String name = txtSearch.Text;
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].Name.ToLower() == name.ToLower())
                {
                    MessageBox.Show(name + " is " + people[i].Age);
                }
            }
        }
    }
}
