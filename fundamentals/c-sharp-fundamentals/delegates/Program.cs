namespace Delegates
{
    /// <summary>
    /// A Delegate is an objecdt that knows how to call
    /// a method ( or a group of methods). Could also 
    /// be a reference to a function
    /// 
    /// Delegate are used when designing frameworks to 
    /// provide extensibility
    /// 
    /// Use a delegate when:
    ///     - an eventing design pattern is used
    ///     - The caller doesn't need to access other
    ///       properties or methods on the object 
    ///       implementing the method.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            
            // Use custom delegate to process a photo
            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;
            processor.Process("photo.jpg", filterHandler);

            // Use system delegate to process a photo
            Action<Photo> filterHandler2 = filters.ApplyBrightness;
            filterHandler2 += filters.ApplyContrast;
            filterHandler2 += RemoveRedEyeFilter;
            processor.Process("photo.jpg", filterHandler2);
        }
        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply remove red eye");
        }
    }
}


