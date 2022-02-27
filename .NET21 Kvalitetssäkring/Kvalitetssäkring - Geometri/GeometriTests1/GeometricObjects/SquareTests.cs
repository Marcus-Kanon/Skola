using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometri.GeometricObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri.GeometricObjects.Tests
{
    public enum GeometricObjectType
    {
        Circle,
        Rectangle,
        Square,
        Triangle
    }

    [TestClass()]
    public class GeoObjectTests
    {
        private static Circle test;

        [TestInitialize]
        public void Setup()
        {
            test = new Circle();
        }

        [TestMethod()]
        [DataRow(test, 5.5f)]
        public void GetAreaTest(IGeometricObject geo, float expected)
        {
            test.Radius = 5.5f;
            var actual = geo.GetArea();


            Assert.AreEqual(actual, expected);
        }
    }
}