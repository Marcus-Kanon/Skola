using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri.GeometricObjects
{
    public class GeometricCalculator
    {
        /// <summary>
        /// Calculates the combined area of an array of IGeometricObject-objects
        /// </summary>
        /// <param name="geoObjects"></param>
        /// <returns>The combined area</returns>
        public float GetArea(IGeometricObject[] geoObjects)
        {
            float sum = 0f;

            foreach (var geoObject in geoObjects)
            {
                sum += geoObject.GetArea();
            }

            return sum;
        }
        /// <summary>
        /// Calculates the combined perimeter of an array of IGeometricObject-objects
        /// </summary>
        /// <param name="geoObjects"></param>
        /// <returns>The combined perimeter</returns>
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
