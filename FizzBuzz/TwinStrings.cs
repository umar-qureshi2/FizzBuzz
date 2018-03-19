using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class TwinStrings
    {
        static string[] twins(string[] a, string[] b)
        {
            string[] result = new string[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length != b[i].Length)
                {
                    //length not equal
                    result[i] = "No"; 
                    continue;
                }
                //store odd and even chars and later check if these are present in set
                HashSet<char> evenChars = new HashSet<char>();
                HashSet<char> oddChars = new HashSet<char>();
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        evenChars.Add(a[i][j]);
                    }
                    else
                    {
                        oddChars.Add(a[i][j]);
                    }
                }

                for (int j = 0; j < b[i].Length; j++)
                {
                    if (j % 2 == 0 && !evenChars.Contains(b[i][j]))
                    {
                        result[i] = "No";
                        break;
                    }
                    else if (j % 2 == 1 && !oddChars.Contains(b[i][j]))
                    {
                        result[i] = "No";
                        break;
                    }
                }
                if (string.IsNullOrEmpty(result[i]))
                {
                    result[i] = "Yes";
                }
            }
            return result;
        }
    }
}
