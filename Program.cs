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
            string language = "C#";
            switch (language)
            {
                case "C#":
                case "Visual Basic":
                case "F#":
                    Console.WriteLine(".NET対応");
                    break;
                case "Python":
                case "Ruby":
                    Console.WriteLine("スクリプト言語");
                    break;
                default: 
                    Console.WriteLine("不明");
                    break;
            }
        }
    }
}
