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
    public class SquareTests
    {
        [TestMethod()]
        [DataRow(1, 1, 1)]
        [DataRow(2, 2, 4)]
        [DataRow(3, 3, 9)]
        [DataRow(4, 4, 16)]
        [DataRow(5, 5, 25)]
        public void GetAreaTest(float a, float expected)
        {
            Square geo = new Square() { Width = a};
            var actual = geo.GetArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(1, 1, 4)]
        [DataRow(2, 2, 8)]
        [DataRow(3, 3, 12)]
        [DataRow(4, 4, 16)]
        [DataRow(5, 5, 20)]
        public void GetPerimeterTest(float a, float expected)
        {
            Square geo = new Square() { Width = a };
            var actual = geo.GetPerimeter();

            Assert.AreEqual(expected, actual);
        }
    }
}