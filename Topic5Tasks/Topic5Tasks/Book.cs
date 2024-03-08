using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic5Tasks
{
    internal class Book
    {
        private String title;
        private String author_name;
        private String isbn;
        private String genre;

        public String Title
        {
            get
            {
                return title;
            }
            set 
            { 
                title = value; 
            }

        }

        public String AuthorName
        {
            get
            {
                return author_name;
            }
            set
            {
                author_name = value;
            }
        }


        public String ISBN
        {
            get
            {
                return isbn;
            }
            set
            {
                isbn = value;
            }
        }

        public String Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
            }
        }
    }
}
