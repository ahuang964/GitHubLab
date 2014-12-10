using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7_3
{
    class Book
    {
        public string Title;
        public string Author;
        public string Publisher;
        public string ISBN;

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            Publisher = "O'Reilly";
            ISBN = isbn;
        }

        public void DisplayBook()
        {
            Console.WriteLine("Book info:\nTitle: {0}\nAuthor: {1}\nPublisher: {2}\nISBN: {3}", Title, Author, Publisher, ISBN);
        }
    }
}
