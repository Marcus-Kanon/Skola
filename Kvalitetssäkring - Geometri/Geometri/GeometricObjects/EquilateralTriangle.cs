namespace Geometri.GeometricObjects
{
    public class EquilateralTriangle : IGeometricObject
    {
        public float a = 0;
        public float GetArea() => (float)Math.Sqrt(3)/4*a*a;
        public float GetPerimeter() => 3*a;
    }
}
