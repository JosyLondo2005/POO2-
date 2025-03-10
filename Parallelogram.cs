using System;

namespace Geometry;

class Parallelogram : Rectangle
{
    private double height;
    public double Height => height;

    public Parallelogram(string name, double sideA, double sideB, double height) : base(name, sideA, sideB)
    {
        if (height <= 0)
            throw new ArgumentException("La altura debe ser positiva.");
        
        this.height = height;
    }

    public override double GetArea() => B * Height;
    public override double GetPerimeter() => 2 * (A + B);
}
