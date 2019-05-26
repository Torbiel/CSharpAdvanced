using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value types cannot be null in C#, that's why we use Nullable type 

            DateTime? date = null;
            DateTime date2 = date.GetValueOrDefault();
            DateTime? date3 = date2;

            /*
             * This can be shortened with null coalescing operator "??"
            if (date != null)
            {
                date2 = date.GetValueOrDefault();
            }
            else
            {
                date2 = DateTime.Today;
            }
            */

            date2 = date ?? DateTime.Today;
        }
    }
}
