using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control_flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example: if statement
            Console.WriteLine("The if statement");
            Console.WriteLine("");

            int width = 20;
            int length = 20;

            if (width == length)
            {
                Console.WriteLine("A square is detected");
            }

            Console.Write("Press any key to continue...");
            Console.ReadKey(true);

            Console.WriteLine("The switch statement");
            Console.WriteLine("");

            // Example: switch statement
            int direction = 3;

            switch (direction)
            {
                case 1:
                    Console.WriteLine("Moving north");
                    break;
                case 2:
                    Console.WriteLine("Moving east");
                    break;
                case 3:
                    Console.WriteLine("Moving south");
                    break;
                case 4:
                    Console.WriteLine("Moving west");
                    break;
                default:
                    Console.WriteLine("Invalid direction");
                    break;
            }

            Console.Write("Press any key to continue...");
            Console.ReadKey(true);


            // Example: break statement
            Console.WriteLine("The break statement");
            Console.WriteLine("");

            for (int i = 1; i < 10; i++)
            {
                if (i % 7 == 0)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("");
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);


            // Example: continue statement
            Console.WriteLine("The continue statement");
            Console.WriteLine("");

            for (int i = 1; i < 10; i++)
            {
                if (i % 7 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("");
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);

        }
    }
}
