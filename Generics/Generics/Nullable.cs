namespace Generics
{
    // this class is in System.Nullable
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable() { }
        public Nullable(T value)
        {
            // boxing (converting a value type instance to an object reference), the value is stored in the heap insted of stack
            _value = value; 
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if(HasValue)
            {
                return (T)_value; // unboxing
            }

            return default;
        }
    }
}
