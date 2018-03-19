using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FindNumber
    {
        static string findNumber(int[] arr, int k)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == k)
                {
                    return "YES";
                }
            }
            return "NO";
        }
    }
}
