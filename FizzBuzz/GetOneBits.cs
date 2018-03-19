using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class GetOneBits
    {
        static int[] getOneBits(int n)
        {
            int bitsCount = 0;
            //int oneBits = 0;
            List<int> oneBitIndexes = new List<int>();
            while (n > 0)
            {
                bitsCount++;
                var isOneBit = (n & 1);
                //oneBits += isOneBit;
                if (isOneBit > 0)
                {
                    oneBitIndexes.Add(bitsCount - 1);
                }
                n = n >> 1;
            }
            //return new int[5];// tempResult.ToArray();
            var result = new List<int>() { oneBitIndexes.Count };
            result.AddRange(oneBitIndexes.AsParallel().OrderByDescending(x=>x).Select(x => bitsCount - x).ToList());
            return result.ToArray();
        }
    }
}
