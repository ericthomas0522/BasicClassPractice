using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassPractice
{
    class Book
    {
        private string title;
        private string author;
        private int pages;
        private int wordCount;

        //Constructor for the class. Must share the same name as the class.
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        //Overloading constructor for when you know the pages and wordcount.
        public Book(string title, string author, int pages, int wordCount)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.wordCount = wordCount;
        }

        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public void AssignWordCountFromText(string text)
        {
            wordCount = text.Split(' ').Length;
        }
    }
}
