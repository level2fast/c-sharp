namespace Generics
{
    // where T: IComparable - contstraint to interface
    // where T: new()
    public class Utilities<T> where T: IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public void DoSomethign(T value)
        {
            var obj = new T();
        }

        /// <summary>
        /// This function finds the max of two numbers 
        /// using generics. Need to apply a constraint here because
        /// the compiler does not know the type of
        /// a and b beforehand and therefore can not
        /// compare the two. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public T Max(T a, T b)
        {

            return a.CompareTo(b) > 0 ? a : b;
        }

        // Example of function template. Could also apply the
        // template directly to the function and avoid using
        // class template
        // public T Max<T>(T a, T b) where T : IComparable
        // {
        //     return a.CompareTo(b) > 0 ? a : b;
        // }
    }
}