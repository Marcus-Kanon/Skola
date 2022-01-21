using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometri.GeometricObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri.GeometricObjects.Tests
{
    [TestClass()]
    public class RightTriangleTests
    {
        [TestMethod()]
        public void GetAreaTest(float a, float b)
        {
            RightTriangle geo = new() { a = a, b = b };

            var actual = geo.GetArea();
            var expected = a * b / 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPerimeterTest(float a, float b)
        {
            RightTriangle geo = new() { a = a, b = b };

            var actual = geo.GetArea();
            var expected = a * b + Math.Sqrt(a*a + b*b);

            Assert.AreEqual(expected, actual);
        }
    }
}