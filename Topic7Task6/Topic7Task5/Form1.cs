using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic7Task5
{
    public partial class Form1 : Form
    {
        Book[] library;
        public Form1()
        {
            InitializeComponent();
        }


        private void cmdFind_Click(object sender, EventArgs e)
        {
            int toFind = Int32.Parse(txtYear.Text);
            lblOutput.Text = "";
            lblOutput.Text = "Books released in " + toFind + " year are \n";
            for (int i = 0; i < library.Length; i++)
            {
                if (library[i].Year == toFind)
                {
                    // lblOutput.Text += "Books released in " + toFind + " year are " + library[i].Title + " " + library[i].Author + "\n";
                    lblOutput.Text += library[i].Title + " " + library[i].Author + "\n";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            library = new Book[5];
            library[0] = new Book(1, "Book1", "Author1", 1999);
            library[1] = new Book(2, "Book2", "Author2", 2001);
            library[2] = new Book(3, "Book3", "Author3", 1998);
            library[3] = new Book(4, "Book4", "Author4", 2001);
            library[4] = new Book(5, "Book5", "Author5", 2001);
        }
    }
}
