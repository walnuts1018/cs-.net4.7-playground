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
            string str = "鈴木\t太郎\t男\t50歳\t広島県";
            var data = str.Split('\t');
            foreach (var i in data)
            {
                Console.WriteLine(i);
            }
        }
    }
}
