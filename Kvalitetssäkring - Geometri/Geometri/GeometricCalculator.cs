using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri.GeometricObjects
{
    public class GeometricCalculator : IGeometricCalculations
    {
        public float GetArea(Circle geoObject) => (float)(Math.Pow(geoObject.Radius, 2) * Math.PI);

        public float GetPerimeter(Circle geoObject) => (float)(2 * Math.PI * geoObject.Radius);

        public float GetArea(Rectangle geoObject) => geoObject.Height * geoObject.Width;

        public float GetPerimeter(Rectangle geoObject) => geoObject.Height * 2 + geoObject.Width * 2;

        public float GetArea(Square geoObject) => geoObject.Height * geoObject.Width;

        public float GetPerimeter(Square geoObject) => geoObject.Height * 2 + geoObject.Width * 2;

        public float GetArea(Triangle geoObject) => throw new NotImplementedException();

        public float GetPerimeter(Triangle geoObject) => throw new NotImplementedException();

        public float GetPerimeter(GeometricObject[] geoObjects) => throw new NotImplementedException();
    }
}
