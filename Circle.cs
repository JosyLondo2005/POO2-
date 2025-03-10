using System;

namespace Geometry;

class Circle : GeometricFigure
{
    private double radius;
    
    public double Radius => radius;

    public Circle(string name, double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("El radio debe ser positivo.");
        
        Name = name;
        this.radius = radius;
    }

    public override double GetArea() => Math.PI * Math.Pow(Radius, 2);
    public override double GetPerimeter() => 2 * Math.PI * Radius;
}
