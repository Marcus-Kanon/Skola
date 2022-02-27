using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri.GeometricObjects
{
    /// <summary>
    /// Interface for geometric objects
    /// </summary>
    public interface IGeometricObject
    {
        /// <summary>
        /// Calculates the area of the object
        /// </summary>
        /// <returns>The area</returns>
        public float GetArea();
        /// <summary>
        /// Calculates the perimeter of the object
        /// </summary>
        /// <returns>The perimeter</returns>
        public float GetPerimeter();
    }
}
