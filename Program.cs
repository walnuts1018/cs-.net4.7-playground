using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;


namespace cs_.net4._7_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "仕事用はwings@example.jpです。 プライベート 用 は YAMA@example.com です。";
            var rgx = new Regex(@"[ a-z 0-9.!#$%&'*+/=?^_{|}~-]+@[ a-z 0-9-]+(?:\.[a-z 0-9-]+)*", RegexOptions.IgnoreCase);
            var result = rgx.Matches(str);
            foreach (Match m in result)
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}
