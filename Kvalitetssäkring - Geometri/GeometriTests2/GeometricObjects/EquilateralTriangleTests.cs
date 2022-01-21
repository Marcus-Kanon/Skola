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
    public class EquilateralTriangleTests
    {
        [TestMethod()]
        public void GetAreaTest(float a)
        {
            EquilateralTriangle geo = new() { a = a };

            var actual = geo.GetArea();
            var expected = (float)Math.Sqrt(3) / 4 * a * a;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPerimeterTest(float a)
        {
            EquilateralTriangle geo = new() { a = a };

            var actual = geo.GetPerimeter();
            var expected = 3 * a;

            Assert.AreEqual(expected, actual);
        }
    }
}