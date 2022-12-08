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
            var str1 = "あいうえおaiueo";
            Console.WriteLine(str1.Length);

            var str2 = "😄";
            StringInfo str2Info = new StringInfo(str2);
            Console.WriteLine(str2Info.LengthInTextElements);
        }
    }
}
