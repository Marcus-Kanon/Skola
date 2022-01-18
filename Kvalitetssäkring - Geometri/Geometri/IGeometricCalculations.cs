namespace Geometri.GeometricObjects;

internal interface IGeometricCalculations
{
    public float GetArea(Circle geoObject);
    public float GetPerimeter(Circle geoObject);
    public float GetArea(Rectangle geoObject);
    public float GetPerimeter(Rectangle geoObject);
    public float GetArea(Square geoObject);
    public float GetPerimeter(Square geoObject);
    public float GetArea(Triangle geoObject);
    public float GetPerimeter(Triangle geoObject);
    public float GetPerimeter(GeometricObject[] geoObjects);

}