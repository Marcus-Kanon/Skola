namespace Geometri.GeometricObjects
{
    public class RightTriangle : IGeometricObject
    {
        public float a { get; set; } = 0;
        public float b { get; set; } = 0;
        public float GetArea() => a*b/2;
        public float GetPerimeter() => (float)(a+b+Math.Sqrt(a*a+b*b));
    }
}
