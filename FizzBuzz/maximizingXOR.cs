using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class MaximizingXOR
    {
        static int maximizingXor(int l, int r)
        {
            var xor = l ^ r;
            int bits = 0;
            while (xor > 0)
            {
                xor = xor >> 1;
                bits++;
            }
            int output = 0;
            while (bits>0)
            {
                output = output << 1;
                output = output | 1;
                bits--;
            }
            return output;
            //old logic from thought process. does not work because of signed bit to the left
            //var reverseXor = ~xor;
            //var oneOr = xor | 1;
            //var max = xor | reverseXor;
            //return max;
        }

        static void _Main(String[] args)
        {
            int l = Convert.ToInt32(Console.ReadLine());
            int r = Convert.ToInt32(Console.ReadLine());
            int result = maximizingXor(l, r);
            Console.WriteLine(result);
        }
    }
}
