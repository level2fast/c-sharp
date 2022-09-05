using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_and_lists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Example: Adding Elements in ArrayList
            // adding elements using ArrayList.Add() method
            var arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);

            // adding elements using object initializer syntax
            var arlist2 = new ArrayList()
                {
                    2, "Steve", " ", true, 4.5, null
                };



            // Example: Insert Collection in ArrayList
            ArrayList arlist3 = new ArrayList()
                {
                    100, 200, 600
                };

            ArrayList arlist4 = new ArrayList()
                {
                    300, 400, 500
                };
            arlist3.InsertRange(2, arlist4);

            // Example: Iterate ArrayList
            Console.WriteLine("arlist3:");
            foreach (var item in arlist3)
                Console.WriteLine(item); //output: 100, 200, 300, 400, 500, 600, 


            // Single dimensional array
            int[] students = { 75, 62, 94, 83, 87 };

            // Multi dimensional array
            int[,] grades = {
            { 75, 81, 86, 77, 67 },
            { 62, 71, 76, 68, 78 },
            { 94, 91, 95, 88, 87 },
            { 83, 88, 75, 71, 72 },
            { 87, 77, 79, 88, 81 }
            };


        }
    }
}
