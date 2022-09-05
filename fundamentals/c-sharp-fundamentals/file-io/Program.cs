using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file_io
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            // Example of File and FileInfo
            var path = @"c:\temp2\myfile.jpg";
            // some useful mehtods:
            // File.Encrypt, File.Copy
            // These static methods force the operating system to do security
            // checks when used. Could effect performance of the app.
            // Best to use these for short operations. 
            File.Copy("c:\\temp\\myfile.jpg", "e:\\temp\\myfile.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                // do something with it
            }
            else
            {
                Console.WriteLine("file does not exist");
            }
            var content = File.ReadAllText(path);
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {

            }

            // Directory and DirectoryInfo
            Directory.CreateDirectory(@"c:\\temp\\");
            // method below returns all files from the directory specified in the 1st parameter
            var files = Directory.GetFiles(@"c:\Github\c-sharp\c-sharp-fundamentals", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directoris = Directory.GetDirectories(@"c:\Github\c-sharp\c-sharp-fundamentals", "*.*", SearchOption.AllDirectories);
            foreach (var dir in directoris)
            {
                Console.WriteLine(dir);
            }
            Directory.Exists(@"c:\Github\c-sharp\c-sharp-fundamentals");

            var directoryInfo = new DirectoryInfo("...");

            // Path methods

            var path2 = @"c:\Github\c-sharp\c-sharp-fundamentals";
            var dotIndex = path2.IndexOf(".");
            var extension = path2.Substring(dotIndex);
            Console.WriteLine("Extension: " + Path.GetExtension(path2));
            Console.WriteLine("File Name: " + Path.GetFileName(path2));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path2));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path2));

#endif

        }
    }
}
