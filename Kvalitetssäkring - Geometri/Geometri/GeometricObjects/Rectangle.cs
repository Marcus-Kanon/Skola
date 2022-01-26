namespace Geometri.GeometricObjects
{
    /// <summary>
    /// A rectangle
    /// </summary>
    public class Rectangle : IGeometricObject
    {
        public float Height { get; set; } = 0;
        public float Width { get; set; } = 0;
        /// <summary>
        /// Calculates the area of the object
        /// </summary>
        /// <returns>The area</returns>
        public float GetArea() => Height * Width;
        /// <summary>
        /// Calculates the perimeter of the object
        /// </summary>
        /// <returns>The perimeter</returns>
        public float GetPerimeter() => Height * 2 + Width * 2;
    }
}
