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
            int sum = 0;
            for (int i = 100; i<=200; i++)
            {
                if (i%2==0)
                { continue; }
                sum += i;
                
            }
            Console.WriteLine(sum);
        }
    }
}
