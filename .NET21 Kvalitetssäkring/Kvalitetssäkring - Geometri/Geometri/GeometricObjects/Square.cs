using System.Security.AccessControl;

namespace Geometri.GeometricObjects
{
    /// <summary>
    /// A Square
    /// </summary>
    public class Square : IGeometricObject
    {
        public float Width { get; set; } = 0;
        /// <summary>
        /// Calculates the area of the object
        /// </summary>
        /// <returns>The area</returns>
        public float GetArea() => Width * Width;
        /// <summary>
        /// Calculates the perimeter of the object
        /// </summary>
        /// <returns>The perimeter</returns>
        public float GetPerimeter() => Width * 4;
    }
}
