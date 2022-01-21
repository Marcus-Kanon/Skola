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
    public class RectangleTests
    {
        [TestMethod()]
        [DataRow(1, 1, 1)]
        [DataRow(2, 2, 4)]
        [DataRow(3, 3, 9)]
        [DataRow(4, 4, 16)]
        [DataRow(5, 5, 25)]
        public void GetAreaTest(float a , float b, float expected)
        {
            Rectangle geo = new Rectangle() { Height = a, Width = b };

            var actual = geo.GetArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(1, 1, 1)]
        [DataRow(2, 2, 4)]
        [DataRow(3, 3, 9)]
        [DataRow(4, 4, 16)]
        [DataRow(5, 5, 25)]
        public void GetPerimeterTest(float a, float b, float expected)
        {
            Rectangle geo = new Rectangle() { Height = a, Width = b };

            var actual = geo.GetPerimeter();

            Assert.AreEqual(expected, actual);
        }
    }
}