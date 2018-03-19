using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class SuperReducedString
    {
        public static string SuperReduceString(string s)
        {
            Stack<char> characterStack = new Stack<char>();
            if (s.Length > 0)
            {
                characterStack.Push(s[0]);
            }

            for (int i = 1; i < s.Length; i++)
            {
                var peek = (char)0;
                if (characterStack.Count > 0)
                {
                    peek = characterStack.Peek();
                }

                if (peek == s[i])
                {
                    characterStack.Pop();
                }
                else
                {
                    characterStack.Push(s[i]);
                }
            }

            if (characterStack.Count == 0)
            {
                return "Empty String";
            }
            return string.Concat(characterStack.Reverse().ToList());
        }
    }
}
