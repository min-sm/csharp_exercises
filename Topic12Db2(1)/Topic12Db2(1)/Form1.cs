using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // for sqlconnection
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic12Db2_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=MyData;Integrated Security=True");



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataDataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.myDataDataSet.People);

        }

        private void cmdView_Click(object sender, EventArgs e)
        {
            con.Open();
            String selString = "SELECT UserName FROM People";
            SqlCommand selcmd = new SqlCommand(selString, con);
            SqlDataReader rdr = selcmd.ExecuteReader();
            String name = "";
            while (rdr.Read())
            {
                name += rdr[0].ToString() + " ";
            }
            MessageBox.Show("Names are " + name);
            rdr.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String n = txtName.Text;
            String a = txtAddress.Text;
            String c = txtComments.Text;
            String d = dateTimePicker.Text;
            int id = Int16.Parse(txtID.Text);
            con.Open();
            String Ins = @"Insert into People(Id, UserName, Address, Comments, Birthday) values ('" + id + "', '" + n + "', '" + c + "', '" + d + "')";
            SqlCommand inscmd = new SqlCommand(Ins, con);
            inscmd.ExecuteNonQuery();
            MessageBox.Show("New Row added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtName.Text = "";
            txtAddress.Text = "";
            txtComments.Text = "";
            txtID.Text = "";
            txtName.Focus();
            con.Close();
        }
    }
}
