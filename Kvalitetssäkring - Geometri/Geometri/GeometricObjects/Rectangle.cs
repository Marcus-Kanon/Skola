namespace Geometri.GeometricObjects
{
    public class Rectangle : IGeometricObject
    {
        public float Height { get; set; } = 0;
        public float Width { get; set; } = 0;
        public float GetArea() => Height * Width;
        public float GetPerimeter() => Height * 2 + Width * 2;
    }
}
