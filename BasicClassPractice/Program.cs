using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a new book.
            Book book = new Book("Harry Potter", "J.K. Rowling");

            //Updates the title of the book
            book.SetTitle("Harry Potter and the Half-Blood Prince");

            //returns the title of the book
            Console.WriteLine(book.GetTitle());
        }
    }
}
