using System;
using System.Collections.Generic;

namespace ListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Kitab-1","kitabca",100,"programming");
            Book book1 = new Book("Kitab-2","kitab",200,"backend");
            Library lib = new Library();
            List<Book> bk = lib.FindAllBookByName(book.Name);
            bk.Add(book);
            bk.Add(book1);
            foreach (var item in bk)
            {
                Console.WriteLine(item.Code);
            }
            //foreach (var item in bk)
            //{
            //    Console.WriteLine(item.Name);
            //}
            Console.WriteLine(book.Code);
            List<Book> books = new List<Book> { book, book1 };
            foreach (var item in books)
            {
                Console.WriteLine("Name: " + item.Name + " " + "AuthorName: " + item.AuthorName + " " + "Code: " + item.Code + " " + "PageCount: " + item.PageCount);

            }
        }
    }
}
