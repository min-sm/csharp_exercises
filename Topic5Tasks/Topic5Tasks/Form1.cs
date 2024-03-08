using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Topic5Tasks
{
    public partial class Form1 : Form
    {
        Book b1, b2, b3, b4;

        private void cmdDisplay_Click(object sender, EventArgs e)
        {
            // MessageBox.Show((string)comboBxGenre.SelectedItem);
            // MessageBox.Show((string)comboBxWhichOne.SelectedItem);
            lblDisplayBookNo.Text = "Book No: ";
            lblDisplayTitle.Text = "Title: ";
            lblDisplayAuthor.Text = "Author: ";
            lblDisplayIsbn.Text = "ISBN: ";
            lblDisplayGenre.Text = "Genre: ";

            Book selected;
            selected = selectedBook();

            if (comboBxWhichOne.SelectedValue.ToString().Equals('1'))
            {
                lblDisplayBookNo.Text += '1';
            } else if (comboBxWhichOne.SelectedValue.ToString().Equals('2'))
            {
                lblDisplayBookNo.Text += '2';
            } else if (comboBxWhichOne.SelectedValue.ToString().Equals('3'))
            {
                lblDisplayBookNo.Text += '3';
            } else
            {
                lblDisplayBookNo.Text += '4';
            }
            lblDisplayTitle.Text += selected.Title;
            lblDisplayAuthor.Text += selected.AuthorName;
            lblDisplayIsbn.Text += selected.ISBN;
            lblDisplayGenre.Text += selected.Genre;
        }

        

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {

            String title, author, isbn, genre;

            title = txtTitle.Text;
            author = txtAuthor.Text;
            isbn = txtIsbn.Text;
            genre = comboBxGenre.SelectedValue.ToString();

            Book selected;
            selected = selectedBook();

            selected.Title = title;
            selected.AuthorName = author;
            selected.ISBN = isbn;
            selected.Genre = genre;

            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtIsbn.Text = "";
            comboBxGenre.DataSource = genreData;
        }

        string[] genreData = { "Action & Adventure", "Drama", "Fantasy" };
        string[] whichOneData = { "1", "2", "3" };

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBxGenre.DataSource = genreData;
            comboBxWhichOne.DataSource = whichOneData;
            b1 = new Book();
            b2 = new Book();
            b3 = new Book();
            b4 = new Book();
        }

        private Book selectedBook()
        {
            Book selected;
            string whichTxt = (string) comboBxWhichOne.SelectedItem;

            if (whichTxt.Equals('1'))
            {
                selected = b1;
            }
            else if (whichTxt.Equals('2'))
            {
                selected = b2;
            }
            else if (whichTxt.Equals('3'))
            {
                selected = b3;
            }
            else 
            {
                selected = b4;
            }

            return selected;
        }
    }
}
