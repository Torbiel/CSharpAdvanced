using System;

namespace Generics
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var book = new Book { Isbn = "1111", Title = "C# Advanced" };

            /*
            When using generic list, we don't have to create many lists for different types, we simply pass the type and without any 
            casting or boxing, at runtime, our list is of the given type. We could use an object list, because object is a parent class
            for all the types in C#, but that requires boxing or casting which is heavy on performance.
            In practice we rarely have to create a generic.
            */

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(book);

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());

            var number = new Nullable<int>(5);
            Console.WriteLine("Has Value? " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());

            var number2 = new Nullable<int>();
            Console.WriteLine("Has Value? " + number2.HasValue);
            Console.WriteLine("Value: " + number2.GetValueOrDefault());
        }
    }
}
