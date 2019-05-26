using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            /*
             * This can be done in one line using LINQ: 
            var cheapBooks = new List<Book>();

            foreach(var book in books)
            {
                if(book.Price < 10)
                {
                    cheapBooks.Add(book);
                }
            }
            */

            // LINQ Extension methods
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Price)
                                .Select(b => b.Title);

            // LINQ Query operators
            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;

            foreach (var book in cheapBooks)
            {
                //Console.WriteLine(book.Title + " " + book.Price);
                Console.WriteLine(book);
            }

            Console.WriteLine();

            foreach (var book in cheaperBooks)
            {
                //Console.WriteLine(book.Title + " " + book.Price);
                Console.WriteLine(book);
            }

            Console.WriteLine();

            var book1 = books.SingleOrDefault(b => b.Title == "ASP.NET MVC+");
            Console.WriteLine(book1);

            var book2 = books.FirstOrDefault(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(book2.Title + " " + book2.Price);

            var book3 = books.LastOrDefault(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(book3.Title + " " + book3.Price);

            Console.WriteLine();

            var books4 = books.Skip(2).Take(3);
            foreach(var book in books4)
            {
                Console.WriteLine(book.Title);
            }

            Console.WriteLine();

            var count = books.Count();
            Console.WriteLine(count);

            Console.WriteLine();

            var maxPrice = books.Max(b => b.Price);
            Console.WriteLine(maxPrice);

            Console.WriteLine();

            var minPrice = books.Min(b => b.Price);
            Console.WriteLine(minPrice);

            Console.WriteLine();

            var totalPrice = books.Sum(b => b.Price);
            Console.WriteLine(totalPrice);
        }
    }
}
