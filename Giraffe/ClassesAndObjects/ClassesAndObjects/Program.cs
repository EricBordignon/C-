using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // ... Actual object that uses the class specification
            Book book1 = new Book();

            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);

            Book book2 = new Book();

            book2.title = "Lord of the Rings";
            book2.author = "Tolkein";
            book2.pages = 700;

            Console.WriteLine(book2.title);
            Console.WriteLine(book2.author);
            Console.WriteLine(book2.pages);
        }
    }
}
