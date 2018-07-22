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
            Console.ReadLine();

            //The homework section for this chapter is below.

            Ball ballOne = new Ball(new Color(33, 25, 76), 4);
            Ball ballTwo = new Ball(new Color(44, 33, 44), 1);

            ballOne.Throw();
            ballOne.Throw();
            Console.WriteLine(ballOne.TimesThrown());
            ballOne.Pop();
        }
    }
}
