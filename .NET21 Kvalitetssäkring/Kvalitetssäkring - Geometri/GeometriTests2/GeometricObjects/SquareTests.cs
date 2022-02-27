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
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(-1)]
        [DataRow(-2)]
        [DataRow(-3)]
        [DataRow(-4)]
        [DataRow(float.MaxValue)]
        [DataRow(float.MaxValue + 1.0f)]
        [DataRow(float.MinValue)]
        [DataRow(float.MinValue - 1.0f)]
        [DataRow(float.PositiveInfinity)]
        [DataRow(float.NegativeInfinity)]
        [DataRow(float.NaN)]
        [DataRow(float.Epsilon)]
        [DataRow(null)]
        public void GetAreaTest(float a)
        {
            Square geo = new Square() { Width = a};

            float actual = geo.GetArea();
            float expected = a * a;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(-1)]
        [DataRow(-2)]
        [DataRow(-3)]
        [DataRow(-4)]
        [DataRow(float.MaxValue)]
        [DataRow(float.MaxValue + 1.0f)]
        [DataRow(float.MinValue)]
        [DataRow(float.MinValue - 1.0f)]
        [DataRow(float.PositiveInfinity)]
        [DataRow(float.NegativeInfinity)]
        [DataRow(float.NaN)]
        [DataRow(float.Epsilon)]
        [DataRow(null)]
        public void GetPerimeterTest(float a)
        {
            Square geo = new Square() { Width = a };

            float actual = geo.GetPerimeter();
            float expected = a * 4;

            Assert.AreEqual(expected, actual);
        }
    }
}