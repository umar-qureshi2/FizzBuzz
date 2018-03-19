using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class OddNumbers
    {
        static int[] oddNumbers(int l, int r)
        {
            List<int> oddNumbers = new List<int>();
            for (int i = l; i <= r; i++)
            {
                if (i % 2 == 1)
                {
                    oddNumbers.Add(i);
                    i++;
                }
            }
            return oddNumbers.ToArray();

        }

    }
}
