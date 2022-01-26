namespace Geometri.GeometricObjects
{
    public class IsoscelesTriangle : IGeometricObject
    {
        public float a { get; set; } = 0;
        public float b { get; set; } = 0;
        public float GetArea() => (float)(b/4*Math.Sqrt(4*(a*a)-(b*b)));
        public float GetPerimeter() => (float)(2*a+b);
    }
}
