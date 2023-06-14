using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog
{
    public class Book
    {
        public string Title { get; set; }
        public string ISBN { get; set; }
        public DateTime Date { get; set; }
        public bool IsAvailable { get; set; }

        public Book(string title, string isbn, DateTime date)
        {
            Title = title;
            ISBN = isbn;
            Date = date;
        }

        public Book()
        {
        }
    }
}