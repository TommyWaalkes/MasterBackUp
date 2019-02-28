using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPICreation.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }

        public Book()
        {

        }

        public Book(int ID, string Title, int Pages, string Author, string Genre)
        {
            this.ID = ID;
            this.Title = Title;
            this.Pages = Pages;
            this.Author = Author;
            this.Genre = Genre;
        }
    }


}
