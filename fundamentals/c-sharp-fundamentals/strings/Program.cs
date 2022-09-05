using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 122;

            // Example of Format Specifiers
            string a = i.ToString();     // 122
            string b = i.ToString("C");  // $122.00
            string c = i.ToString("C0"); // $122

            // String builder
            var builder = new StringBuilder();
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            Console.WriteLine(builder);

            // prints: 
            //
            // ----------
            // Header
            // ----------

            // Cleaner way to call
            var builder2 = new StringBuilder();
            builder2.Append('-', 10)
            .AppendLine()
            .Append("Header")
            .AppendLine()
            .Append('-', 10);
            Console.WriteLine(builder2);
        }
    }
}
