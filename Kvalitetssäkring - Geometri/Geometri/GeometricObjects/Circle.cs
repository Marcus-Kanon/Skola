namespace Geometri.GeometricObjects
{
    public class Circle : IGeometricObject
    {
        public float Radius { get; set; } = 0;
        public float GetArea() => (float) (Math.Pow(Radius, 2) * Math.PI);
        public float GetPerimeter() => (float)(2 * Math.PI * Radius);
    }
}
