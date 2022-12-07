using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace cs_.net4._7_playground
{
    /// <summary>
    ///  人物情報
    /// </summary>
    class Person
    {
        ///<summary>苗字</summary>
        public string firstName;
        /// <summary>
        /// 名前
        /// </summary>
        public string lastName;

        ///<summary>指名表示</summary>
        ///<param name="Age">年齢</param>
        ///<returns>使命と年齢から整形された文字</returns>
        public void Show(int Age)
        {
            Console.WriteLine( firstName + " " + lastName + "(" + Age + ")");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var value = 10d;
            string name = "名前";
            Console.WriteLine($"こんにちは、{ name }さん！");

            int? iNull = null;

            var data1 = new int[5, 4];

            var data = new int[3][];
            data[0] = new[] { 2, 3, 5};
            data[1] = new[] { 1, 2};
            data[2] = new[] { 10, 11, 12, 13 };

            for (int i = 0; i<3; i++)
                for (int j = 0;  j < data[i].Length;  j++)
                {
                    Console.WriteLine(data[i][j]);
                }

        }
    }
}
