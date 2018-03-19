using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LonelyInteger
{

    static int lonelyinteger(int[] a)
    {
        int result = default(int);
        for (int i = 0; i < a.Length; i++)
        {
            result ^= a[i];
        }
        return result;
        //return a.AsParallel().GroupBy(x => x).FirstOrDefault(x => x.Count() == 1)?.Key ?? -1;
    }

    static void _Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        int result = lonelyinteger(a);
        Console.WriteLine(result);
    }
}
