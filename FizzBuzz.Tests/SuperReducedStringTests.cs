using NUnit.Framework;
using FizzBuzz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Tests
{
    [TestFixture()]
    public class SuperReducedStringTests
    {
        [Test()]
        [TestCase("abba", "Empty String")]
        [TestCase("aa", "Empty String")]
        [TestCase("aaabccddd", "abd")]
        public void super_reduced_stringTest(string reduceMe, string reducedMe)
        {
            //setup
            var result = SuperReducedString.SuperReduceString(reduceMe);
            //assertion
            Assert.AreEqual(reducedMe, result);
        }
    }
}