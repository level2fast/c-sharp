
namespace linq
{
    internal partial class Program
    {
        /// <summary>
        /// LINQ stands for Language Integrated Query
        /// It gives you the ability to query objects!
        /// You can query:
        ///     -Objects in memory, ex. colelctions(LINQ to objects)
        ///     -Databases (LINQ to Entities)
        ///     -XML (LINQ to XML)
        ///     -ADO.NET Data Sets (LINQ to Data Sets)
        /// </summary>
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();


            // Now lets say we want to find the cheap books.
            // Without LINQ we'd have to do the following
            var cheapBooks = new List<Book>();
            foreach (var book in books) 
            {
                if(book.Price<10)
                    cheapBooks.Add(book);
            }
            foreach (var book in cheapBooks)
                Console.WriteLine("No LINQ - " + book.Title + ", Price: " + book.Price);

            // Using LINQ the code above now becomes
            // Where() is an extension method used to filter collections.
            // It takes a delegate that specifies a predicate. Whever we see
            // func as a delegat we can use a lambda expression. 
            // On the left side of the lambda operator we have an argument
            // and on the right side we have an actual expression.
            var cheapBooksUsingLinq = books.Where(book => book.Price < 10).OrderBy(book=>book.Title);
            foreach (var book in cheapBooksUsingLinq)
                Console.WriteLine("LINQ - " + book.Title+ ", Price: " + book.Price);

            // Select method lets us specify which property we want from the object. 
            // The line below grabs only the title from the object which is a list of
            // strings. No need for "book.Title" anymore.
            var cheapBooksSelect = books.Where(book => book.Price < 10).OrderBy(book => book.Title).Select(book=> book.Title);
            foreach (var book in cheapBooksSelect)
                Console.WriteLine(book);


            // Common convention for laying out LINQ methods.
            var cheapBooksSelectClean = books
                                            .Where(book => book.Price < 10)
                                            .OrderBy(book => book.Title)
                                            .Select(book => book.Title);

            // LINQ Query operator equivalent
            // LINQ Query Operators
            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;

            foreach (var book in cheaperBooks)
                Console.WriteLine(book);

            // LINQ Extension Methods
            var singlebook = books.SingleOrDefault(book => book.Title == "ASP.NET MVC++");
            Console.WriteLine(singlebook == null);

            var firstbook = books.First(book => book.Title == "C# Advanced Topics");
            Console.WriteLine("First book: " +firstbook.Title + ": " + firstbook.Price);

            var lasttordbook = books.LastOrDefault(book => book.Title == "C# Advanced Topics");
            Console.WriteLine("Last book: " + lasttordbook.Title + ": " + lasttordbook.Price);


            var pagedBooks = books.Skip(2).Take(3);
            foreach(var pagedBook in pagedBooks)
            {
                Console.WriteLine(pagedBook.Title);
            }

            // Count the number of books
            var countBooks = books.Count();
            Console.WriteLine("Total # of Books: " + countBooks);

            // find highest priced book
            var maxPrice = books.Max(b => b.Price);
            Console.WriteLine("Highest Price: " + maxPrice);

            // find lowest priced book
            var minPrice = books.Min(b => b.Price);
            Console.WriteLine("Lowest Price: " + minPrice);

            // find sum of books
            var sumPrice = books.Sum(b => b.Price);
            Console.WriteLine("Sum Price: " + sumPrice);
            
            // find average of books
            var avgPrice = books.Average(b => b.Price);
            Console.WriteLine("Avg Price: " + avgPrice);
        }
    }
}
