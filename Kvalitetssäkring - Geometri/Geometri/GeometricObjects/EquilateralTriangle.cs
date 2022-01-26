namespace Geometri.GeometricObjects
{
    /// <summary>
    /// An equilateral Triangle
    /// </summary>
    public class EquilateralTriangle : IGeometricObject
    {
        public float a = 0;
        /// <summary>
        /// Calculates the area of the object
        /// </summary>
        /// <returns>The area</returns>
        public float GetArea() => (float)Math.Sqrt(3)/4*a*a;
        /// <summary>
        /// Calculates the perimeter of the object
        /// </summary>
        /// <returns>The perimeter</returns>
        public float GetPerimeter() => 3*a;
    }
}
