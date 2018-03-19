using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class ClassicFizzBuzz
    {
        //it is intended that these were never assigned
        static string s;
        static DateTime d;
        static void _Main(string[] args)
        {
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(FizzBuzz(i));
            //}
            //RecusrsiveFor(1, 100);


            Console.WriteLine(s == null ? "null" : s);
            Console.WriteLine(d == null ? "null" : d.ToString());
            Console.WriteLine(default(DateTime).ToString());

        }

        static void RecusrsiveFor(int i, int max = 100)
        {
            if (i > max)
            {
                return;
            }
            Console.WriteLine(FizzBuzz(i));
            RecusrsiveFor(i + 1, max);
        }

        static string FizzBuzz(int i)
        {
            string result = string.Empty;
            if (i % 3 == 0)
            {
                result += "Fizz";
            }
            if (i % 5 == 0)
            {
                result += "Buzz";
            }
            return !string.IsNullOrEmpty(result) ? result : i.ToString();
        }
    }
}
