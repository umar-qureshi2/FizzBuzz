using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class StockMax
    {

        static long stockmax(int[] prices)
        {
            long profit = 0;
            long maxPrice = 0;
            for (int i = prices.Length - 1; i >= 0; i--)
            {
                if (prices[i] >= maxPrice)
                {
                    maxPrice = prices[i];
                }
                profit += maxPrice - prices[i];
            }
            return profit;
        }

        static void _Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string[] prices_temp = Console.ReadLine().Split(' ');
                int[] prices = Array.ConvertAll(prices_temp, Int32.Parse);
                long result = stockmax(prices);
                Console.WriteLine(result);
            }
        }
    }

}