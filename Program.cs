﻿using System;
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
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write($"{i * j} ");
                }
                Console.WriteLine();
            }
            #if DEBUG
                Console.WriteLine("DEBUG");
            #endif
        }
    }
}
