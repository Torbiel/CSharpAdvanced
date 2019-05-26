using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Delegate is an object that knows how to call a method or a group of methods and is also a reference to a function.
            */

            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.Resize;
            filterHandler += RemoveRedEyesFilter;

            processor.Process("photo.jpeg", filterHandler);
        }

        static void RemoveRedEyesFilter(Photo photo)
        {
            Console.WriteLine("Removing red eyes...");
        }
    }
}
