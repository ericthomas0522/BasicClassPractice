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

            //creating 2 balls. Had to look up the fact that you can include a class like color as a private member of another class.
            //It is pretty cool that you can reuse the base color class to set a color for any object. Just needs to be a private instance in that class.
            Ball ballOne = new Ball(new Color(33, 25, 76), 4);
            Ball ballTwo = new Ball(new Color(44, 33, 44), 1);

            //throwing balls, popping balls, and displaying throw count. Balls that are popped should not increase.
            ballOne.Throw();
            ballOne.Throw();
            Console.WriteLine("Ball one has been thrown " + ballOne.TimesThrown() + " times");
            ballOne.Pop();
            Console.WriteLine("We popped ball one!");
            ballOne.Throw();
            Console.WriteLine("Ball one has been thrown " + ballOne.TimesThrown() + " times");
            ballTwo.Throw();
            Console.WriteLine("Ball two has been thrown " + ballTwo.TimesThrown() + " times");
            ballTwo.Throw();
            Console.WriteLine("Ball two has been thrown " + ballTwo.TimesThrown() + " times");
            ballTwo.Pop();
            Console.WriteLine("We popped ball two!");
            ballTwo.Throw();
            Console.WriteLine("Ball two has been thrown " + ballTwo.TimesThrown() + " times");
            Console.ReadLine();
        }
    }
}
