using System;
using System.Collections.Generic;
using System.Text;

namespace BasicClassesAndObjects
{
    class Book
    {
        //class atributes
        //describe what is the "Book"
        public string title;
        public string author;
        public int pages;

        //making a constructor
        //runs everytime that "new Book"
        public Book(string aTitle, string aAuthor, int aPages)
        {
            //constructing the books from this method
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }

        //empty constructer if you wanna
        //pass an object (book) with no parameters
        public Book()
        {

        }

    }
}
