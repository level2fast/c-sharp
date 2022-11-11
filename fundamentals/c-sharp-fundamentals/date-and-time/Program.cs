using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_and_time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example: DateTime Object usage
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine("Hour:" + now.Hour);
            Console.WriteLine("Minute:" + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToShortTimeString()); 
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("MMMM"));

            // Time span
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            TimeSpan duration = start - end;

            Console.WriteLine("duration:" + duration);

            var start2 = DateTime.Now;
            var duration2 = DateTime.Now.Subtract(DateTime.Now);
            //TimeSpan duration2 = start2 - end2;
            Console.WriteLine("duration2:" + duration2);

            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            //Add 
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));

            //Subtract
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString
            Console.WriteLine("ToString: " + timeSpan.ToString());

            //Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
