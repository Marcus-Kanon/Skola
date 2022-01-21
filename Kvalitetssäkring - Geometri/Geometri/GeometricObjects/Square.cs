using System.Security.AccessControl;

namespace Geometri.GeometricObjects
{
    public class Square : IGeometricObject
    {
        public float Width { get; set; } = 0;
        public float GetArea() => Width * Width;
        public float GetPerimeter() => Width * 2 + Width * 2;
    }
}
