namespace Geometri.GeometricObjects
{
    /// <summary>
    /// An isosceles triangle
    /// </summary>
    public class IsoscelesTriangle : IGeometricObject
    {
        public float a { get; set; } = 0;
        public float b { get; set; } = 0;
        /// <summary>
        /// Calculates the area of the object
        /// </summary>
        /// <returns>The area</returns>
        public float GetArea() => (float)(b/4*Math.Sqrt(4*(a*a)-(b*b)));
        /// <summary>
        /// Calculates the perimeter of the object
        /// </summary>
        /// <returns>The perimeter</returns>
        public float GetPerimeter() => (float)(2*a+b);
    }
}
