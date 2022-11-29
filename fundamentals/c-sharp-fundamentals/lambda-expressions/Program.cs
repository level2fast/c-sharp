using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Reflection;

namespace lambda_expressions
{
    public class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
    }
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book {Title="Title1", Price = 4},
                new Book {Title="Title2", Price = 7},
                new Book {Title="Title3", Price = 17}
            };
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1
            // normal way of computing the square using a function
            Console.WriteLine(Square(4));

            // Can use a delegate to handle this call, delegates are pointer
            // or reference to a method or group of methods
            // first arg represent argument to method, second rep data type
            Func<int, int> SquareDelegate = Square;
            Console.WriteLine(SquareDelegate(5));

            // lambda expression way of computing the square
            // number => number * number;
            // Equivalent result can be achieved using lambda. With this
            // mechanism we don't need the Square function below.
            Func<int, int> SquareLam = number => number * number;
            // now make call using lambda
            Console.WriteLine(SquareLam(6));

            // lambda expr syntax
            // No args
            //  () =>
            // 1 arg
            //  x =>
            // multiple args
            //  (x, y, z) =>

            // Exmaple 2
            const int factor = 5;
            /// create a method that takes a number and multiplies by
            // this number
            Func<int, int> multiplier = n => n * factor;

            var result = multiplier(10);

            Console.WriteLine(result);


            // Example 3
            // return list of books without lambda
            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(isCheaper); // Code will iterate the list of books and return the book that is cheaper
            foreach(var book in cheapBooks)
            {
                Console.WriteLine("Found without lambda expr 'books.FindAll(isCheaper);': " + book.Title);
            }

            // The code above can be done using lambda expressions
            var cheapBooks2 = books.FindAll(book => book.Price < 10);
            foreach (var book in cheapBooks2)
            {
                Console.WriteLine("Found using lambda expr 'books.FindAll(book => book.Price < 10);': " + book.Title);
            }
        }
        static bool isCheaper(Book book)
        {
            return book.Price < 10;
        }
        static int Square(int number)
        {
            return number*number;
        }
    }
}
