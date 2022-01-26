using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri.GeometricObjects
{
    public class GeometricCalculator
    {
        public float GetArea(IGeometricObject[] geoObjects)
        {
            float sum = 0f;

            foreach (var geoObject in geoObjects)
            {
                sum += geoObject.GetArea();
            }

            return sum;
        }

        public float GetPerimeter(IGeometricObject[] geoObjects)
        {
            float sum = 0f;

            foreach (var geoObject in geoObjects)
            {
                sum += geoObject.GetPerimeter();
            }

            return sum;
        }
    }
}
