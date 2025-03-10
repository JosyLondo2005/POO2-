using System;

namespace Geometry;

class Square : GeometricFigure
{
    private double side;
    public double Side => side;

    public Square(string name, double side)
    {
        if (side <= 0)
            throw new ArgumentException("El lado debe ser positivo.");
        
        Name = name;
        this.side = side;
    }

    public override double GetArea() => Side * Side;
    public override double GetPerimeter() => 4 * Side;
}
