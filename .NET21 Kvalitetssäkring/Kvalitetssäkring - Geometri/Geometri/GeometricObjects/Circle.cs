namespace Geometri.GeometricObjects
{
    /// <summary>
    /// A circle
    /// </summary>
    public class Circle : IGeometricObject
    {
        public float Radius { get; set; } = 0;
        /// <summary>
        /// Calculates the area of the object
        /// </summary>
        /// <returns>The area</returns>
        public float GetArea() => (float) (Math.Pow(Radius, 2) * Math.PI);
        public float GetPerimeter() => (float)(2 * Math.PI * Radius);
    }
}
