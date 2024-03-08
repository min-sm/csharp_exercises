using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic7Task5
{
    internal class Book
    {
        String title;
        String author;
        int year;
        Boolean checkedOut;
        int id;
        public Book(int i, string tit, string aut, int y)
        {
            id = i;
            title = tit;
            author = aut;
            year = y;
            checkedOut = false;
        }

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public String Title
        {
            get
            {
                return title;
            }
            set
            {
                title=value;
            }
        }

        public String Author
        {
            get
            {
                return author;
            }
            set
            {
                author=value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year=value;
            }
        }
    }
}
