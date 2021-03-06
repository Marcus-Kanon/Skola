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
    public class CircleTests
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
            Circle geo = new Circle() { Radius = a };

            float expected = (float)(a * a * Math.PI);
            float actual = geo.GetArea();

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
            Circle geo = new Circle() { Radius = a };

            float expected = (float)(2*Math.PI * a);
            float actual = geo.GetPerimeter();

            Assert.AreEqual(expected, actual);
        }
    }
}