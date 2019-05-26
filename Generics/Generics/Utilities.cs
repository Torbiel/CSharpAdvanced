using System;

namespace Generics
{
    public class Utilities
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        // constraint to a default constructor
        public void DoSomething<T>() where T : new() 
        {
            var obj = new T();
        }

        /*
        Generic method can be inside non-generic class. This generic is with applied constraint. We can apply the constraint to the class,
        like this:
        public class Utilities<T> where T : IComparable
        Then we don't need to repeat that in the method.
        Compiler doesn't know the type of T, so it cannot apply comparison between a and b, that's why we make a and b implement
        IComparable interface.
        */
        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
