namespace Geometri.GeometricObjects
{
    /// <summary>
    /// A right triangle
    /// </summary>
    public class RightTriangle : IGeometricObject
    {
        public float a { get; set; } = 0;
        public float b { get; set; } = 0;
        /// <summary>
        /// Calculates the area of the object
        /// </summary>
        /// <returns>The area</returns>
        public float GetArea() => a*b/2;
        /// <summary>
        /// Calculates the perimeter of the object
        /// </summary>
        /// <returns>The perimeter</returns>
        public float GetPerimeter() => (float)(a+b+Math.Sqrt(a*a+b*b));
    }
}
