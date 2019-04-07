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
            //assigning the book1 information
            Book book1 = new Book("Absurdity has become necessity", "Anonymous", 4);

            //creation of book 2
            //book2 information
            Book book2 = new Book("Morning Star v.1", "Some High Elf", 10);

            //if we want we can also change the properties of
            //the object from here
            book2.title = "Morning Star v.2";

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
