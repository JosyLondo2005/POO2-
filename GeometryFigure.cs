using System;

namespace Geometry;

abstract class GeometricFigure
{
    public string Name { get; private set; }

    // Constructor para inicializar el nombre
    public GeometricFigure(string name)
    {
        Name = string.IsNullOrWhiteSpace(name) ? "Unnamed Figure" : name;
    }

    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        string areaFormatted = GetArea() >= 1000 ? GetArea().ToString("#,0.00000") : GetArea().ToString("F5");
        string perimeterFormatted = GetPerimeter().ToString("F5");

        return $"{Name,-15} => Area: {areaFormatted,12}  Perimeter: {perimeterFormatted,12}";
    }
}
