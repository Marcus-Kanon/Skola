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
    public class IsoscelesTriangleTests
    {
        [TestMethod()]
        public void GetAreaTest(float a, float b)
        {
            IsoscelesTriangle geo = new() { a = a, b = b };

            var actual = geo.GetArea();
            var expected = (float)(b / 4 * Math.Sqrt(4 * (a * a) - (b * b)));

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPerimeterTest(float a , float b)
        {
            IsoscelesTriangle geo = new() { a = a, b = b };

            var actual = geo.GetPerimeter();
            var expected = (float)2 * a + b;

            Assert.AreEqual(expected, actual);
        }
    }
}