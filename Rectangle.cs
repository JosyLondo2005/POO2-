using System;

namespace Geometry;

class Rectangle : Square
{
    private double width;
    public double Width => width;

    public Rectangle(string name, double length, double width) : base(name, length)
    {
        if (width <= 0)
            throw new ArgumentException("El ancho debe ser positivo.");
        
        this.width = width;
    }

    public override double GetArea() => A * Width;
    public override double GetPerimeter() => 2 * (A + Width);
}
