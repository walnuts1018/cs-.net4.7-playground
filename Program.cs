using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace cs_.net4._7_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var args2 = new string[] {"3", "10"};
            foreach (var tmp in args2)
            {
                int i =Int32.Parse(tmp);
                Console.WriteLine(i * 1.5);
            }
        }
    }
}
