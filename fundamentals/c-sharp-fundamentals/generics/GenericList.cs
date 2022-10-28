namespace Generics
{ 
   public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue val)
        {
         // throw new NotImplementedException();    
        }
    }
    public class GenericList<T>
    {
        public void Add(T value)
        { }
        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}