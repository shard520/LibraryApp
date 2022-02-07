using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Library
{
    public class Book
    {
        public string Title { get; set; }
        public string Isbn { get; set; }
        public string Genre { get; set; }

        public Book(string title)
        {
            Title = title;
        }
    }
}
