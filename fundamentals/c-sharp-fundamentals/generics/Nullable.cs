namespace Generics
{
    // where T: struct  - constraint to a value type
    
    /// <summary>
    /// Value types can not be null, but we can use
    /// this class to make valuetypes nullable
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Nullable<T> where T: struct
    {
        // value types cannot be NULL
        private object _value;

        /// <summary>
        /// Need default constructor in 
        /// case the value is not set
        /// </summary>
        public Nullable()
        { }

        public Nullable(T value) 
        {
            _value = value; 
        }
        
        public bool HasValue
        {
            get { return _value != null; }  
        }
        public T GetValueOrDefault()
        {
            if (HasValue) 
                return (T)_value; // unboxing here
            
            return default(T);
        }
    }
}