using system;

namespace extension_methods
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            string post = "long post long post long post long post long post long post";
            var shortenedPost = post.Shorten(5);

            Console.WriteLine(shortenedPost);

            IEnumerable<int> numbers = new List<int>() { 1,2,3,5,8,9,77};
            var largest = numbers.Max();
            Console.WriteLine("Number list: { 1,2,3,5,8,9,77}");
            Console.WriteLine("Used Max() extension method to find the largest: " + largest);
        }
    }
}
