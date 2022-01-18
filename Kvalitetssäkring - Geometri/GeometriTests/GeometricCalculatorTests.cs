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
    public class GeometricCalculatorTests
    {
        [TestMethod()]
        public void GetAreaTest()
        {
            var circle = new Circle();
            circle.Radius = 10;

            var calculator = new GeometricCalculator();

            var expected=calculator.GetArea(circle);
            var actual = 314.0f;

            Assert.AreEqual(expected, actual);
        }
    }
}