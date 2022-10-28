using System;
using System.Collections.Generic;

namespace Generics
{
    // Five types of constraints
    // where T: IComparable - contstraint to interface
    // where T: Product - constraint to an object
    // where T: struct  - constraint to a value type
    // where T: class   - constraint to a reference type
    // where T: new()   - constraint must have a default contstructor

    internal class Program
    {
        static void Main(string[] args)
        {
            // create a list of numbers, and a new BookList to hold our 
            // list of books
            var book = new Book { Isbn = "111", Title = "Hello World" };
            var numbers = new List<int>();
            numbers.Add(10);
            var books = new BookList();
            // books.Add(book);  // can add a book this way with non-generic book list

            // Use generic list to create a list of any objects
            var numbersList = new GenericList<int>();
            numbersList.Add(10);
            var booksList = new GenericList<Book>();
            booksList.Add(new Book());

            // Can also have a generic dictionary
            var genericDict = new GenericDictionary<string, Book>();
            genericDict.Add("new book", new Book());


            // Nullabe class test
            // Use Nullable type while giving int a value
            var number1 = new Nullable<int>(1);
            Console.WriteLine("Has Value ? " + number1.HasValue);
            Console.WriteLine("Value: " + number1.GetValueOrDefault());

            // Use Nullable type without giving int a value
            var number0 = new Nullable<int>();
            Console.WriteLine("Has Value ? " + number0.HasValue);
            Console.WriteLine("Value: " + number0.GetValueOrDefault());

            // Nullable is a part of .NET core, commented out here
            // just to demonstrate how to reference it
            // System.Nullable<>();

        }
    }
}