using TDD___Övningar_20220113;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TDD___Övningar_20220113.Metoder;

namespace TDD___Övningar_20220113.Tests
{
    [TestClass()]
    public class MetoderTests
    {
        [TestMethod()]
        public void HighAndLowTest()
        {
            List<(int[], int, int)> list = new List<(int[], int, int)>();


            list.Add((new int[] { 1, 2, 3, 4, 890890, 6, 7, 8, 9, 10 }, 890890, 1));
            list.Add((new int[] { 1, 2, 3, 4, 5, 6, -12, 8, 9, 10 }, 10, -12));
            list.Add((new int[] { 1, 2, 3, 4, 5, 6, -244, 8, 9, 10 }, 10, -244));

            foreach (var array in list)
            {

                int?[] testResult = HighAndLow(array.Item1);
                Assert.AreEqual(testResult, new int?[] { array.Item2, array.Item3 });

            }

        
        }
    }
}

namespace Tests
{
    [TestClass()]
    public class MetoderTests
    {
        [TestMethod()]
        public void FibonacciTest()
        {
            Assert.AreEqual(7, Fibonacci(34));
            Assert.AreNotEqual(8, Fibonacci(34));
        }
    }
}