using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primitive_types_and_expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring and initialzing variables
            int number = 0;
            int secondNumber = 1;

            // floats need "f" appended to number, 4 bytes
            const float Pi = 3.14f;

            // decimals need "m" 16 bytes
            decimal deciNum = 1.2m;

            // in C# local variables use camel case
            int myNumber;
            // in C# for constants: Pascal Case
            const int MaxNumber = 12;

            // Overflow concepts

            // byte can only hold 255 values
            byte overflownum = 255;
            byte one = 1;
            overflownum = (byte)(overflownum + one); //creates overflow.

            // use checked instead
            checked
            {
                byte checkedNum = 255;
                checkedNum = (byte)(checkedNum + one);
            }

        }
    }
}
