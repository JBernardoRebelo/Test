using System;

namespace BasicClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //class tells us what the data type is
            //object is an instance of that class
            //creating an object from the class "Book"
            Book book1 = new Book();

            //creation of book 2
            Book book2 = new Book();

            //assigning the book1 information
            book1.title = "Absurdity has become necessity";
            book1.author = "Anonymous";
            book1.pages = 4;

            //book2 information
            book2.title = "Morning Star v.1";
            book2.author = "Some High Elf";
            book2.pages = 10;

            //print atributes of the book
            Console.WriteLine("Book 1");
            Console.WriteLine("Title: " + book1.title);
            Console.WriteLine("Author: " + book1.author);
            Console.WriteLine("Pages: " + book1.pages);

            //print atributes of 2nd book
            Console.WriteLine("Book 2");
            Console.WriteLine("Title: " + book2.title);
            Console.WriteLine("Author: " + book2.author);
            Console.WriteLine("Pages: " + book2.pages);

        }
    }
}
