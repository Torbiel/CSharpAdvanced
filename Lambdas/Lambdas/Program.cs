using System;

namespace Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lambda expression is an anonymous method with no access modifier, name and return statement.
             * We use them for convenience (less code, more readable)
             */

            /*
             * () => ...
             * x => ...
             * (x, y, z) => ...
             */

            // We create a delegate for a lambda expression:
            Func<int, int> square = number => number * number;

            Console.WriteLine(Square(5));
            Console.WriteLine(square(5));

            const int factor = 5;

            Func<int, int> multiplier = n => n * factor;

            var result = multiplier(10);

            Console.WriteLine(result);

            //--------------------------------

            var books = new BookRepository().GetBooks();

            //var cheapBooks = books.FindAll(IsCheaperThan10Dollars);

            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach(var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        static int Square(int number)
        {
            return number * number;
        }

/*
        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
*/
    }
}
