using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
namespace cs_.net4._7_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new FileInfo(@"C:\Users\juglans\dev\cs-.net4.7-playground\sample\SelfCSharp\Chap05\sample.txt");
            Console.WriteLine(file.Exists);
            Console.WriteLine(file.Name);
            Console.WriteLine(file.Name);
            Console.WriteLine(file.DirectoryName);

            Console.WriteLine(file.IsReadOnly);
            Console.WriteLine(file.LastAccessTime);
            Console.WriteLine(file.LastWriteTime);
            Console.WriteLine(file.Length);

            var file2 = file.CopyTo(@"C:\Users\juglans\dev\cs-.net4.7-playground\sample\SelfCSharp\Chap05\sample_copy.txt",overwrite: true);
            file2.MoveTo(@"C:\Users\juglans\sample_copy.txt");
            // file2.Delete();

        }
    }
}
