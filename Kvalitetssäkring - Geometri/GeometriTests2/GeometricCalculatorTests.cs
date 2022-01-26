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
        [DataRow(0, -0)]
        [DataRow(1, -4)]
        [DataRow(2, -3)]
        [DataRow(3, -2)]
        [DataRow(4, -1)]
        [DataRow(-0, 3)]
        [DataRow(-1, 2)]
        [DataRow(-2, 1)]
        [DataRow(-3, 0)]
        [DataRow(float.MaxValue, float.MaxValue)]
        [DataRow(float.MaxValue + 1.0f, float.MaxValue + 1.0f)]
        [DataRow(float.MinValue, float.MinValue)]
        [DataRow(float.MinValue - 1.0f, float.MinValue - 1.0f)]
        [DataRow(float.PositiveInfinity, float.PositiveInfinity)]
        [DataRow(float.NegativeInfinity, float.NegativeInfinity)]
        [DataRow(float.NaN, float.NaN)]
        [DataRow(float.Epsilon, float.Epsilon)]
        [DataRow(null, null)]
        public void GetAreaTest(float a, float b)
        {
            var calculator = new GeometricCalculator();

            IGeometricObject[] geos = {
                new Circle() {Radius = a},
                new EquilateralTriangle() {a = a},
                new IsoscelesTriangle() {a = a, b = b},
                new RightTriangle() {a = a, b = b},
                new Rectangle() {Height = a, Width = b},
                new Square() {Width = a}
            };

            float actual = calculator.GetArea(geos);
            float expected = 0f;
            geos.ToList().ForEach(geo => expected += geo.GetArea());

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(0, -0)]
        [DataRow(1, -4)]
        [DataRow(2, -3)]
        [DataRow(3, -2)]
        [DataRow(4, -1)]
        [DataRow(-0, 3)]
        [DataRow(-1, 2)]
        [DataRow(-2, 1)]
        [DataRow(-3, 0)]
        [DataRow(float.MaxValue, float.MaxValue)]
        [DataRow(float.MaxValue + 1.0f, float.MaxValue + 1.0f)]
        [DataRow(float.MinValue, float.MinValue)]
        [DataRow(float.MinValue - 1.0f, float.MinValue - 1.0f)]
        [DataRow(float.PositiveInfinity, float.PositiveInfinity)]
        [DataRow(float.NegativeInfinity, float.NegativeInfinity)]
        [DataRow(float.NaN, float.NaN)]
        [DataRow(float.Epsilon, float.Epsilon)]
        [DataRow(null, null)]
        public void GetPerimeterTest(float a, float b)
        {
            var calculator = new GeometricCalculator();

            IGeometricObject[] geos = {
                new Circle() {Radius = a},
                new EquilateralTriangle() {a = a},
                new IsoscelesTriangle() {a = a, b = b},
                new RightTriangle() {a = a, b = b},
                new Rectangle() {Height = a, Width = b},
                new Square() {Width = a}
            };

            float actual = calculator.GetPerimeter(geos);
            float expected = 0f;
            geos.ToList().ForEach(geo => expected += geo.GetPerimeter());

            Assert.AreEqual(expected, actual);
        }
    }
}