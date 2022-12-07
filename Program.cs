using System;
using System.Collections.Generic;
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
            var score = 75;
            if (score >= 90)
            {
                Console.WriteLine("優"); 
            }
            else if (score >=70)
            {
                Console.WriteLine("良");
            }
            else if (score >= 50)
            {
                Console.WriteLine("可");
            }
            else
            {
                Console.WriteLine("不可");
            }
        }
    }
}
