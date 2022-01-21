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
        public void GetAreaTest(float a)
        {
            Circle geo = new Circle() { Radius = a };

            var expected = a * a * Math.PI;
            var actual = geo.GetArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPerimeterTest(float a)
        {
            Circle geo = new Circle() { Radius = a };

            var expected = 2*Math.PI * a;
            var actual = geo.GetPerimeter();

            Assert.AreEqual(expected, actual);
        }
    }
}