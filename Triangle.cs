using System;

namespace Geometry;

class Triangle : Rectangle
{
    private double sideC, height;
    public double SideC => sideC;
    public double Height => height;

    public Triangle(string name, double sideA, double sideB, double sideC, double height) : base(name, sideA, sideB)
    {
        if (sideC <= 0 || height <= 0)
            throw new ArgumentException("Los lados y la altura deben ser positivos.");
        
        this.sideC = sideC;
        this.height = height;
    }

    public override double GetArea() => (B * Height) / 2;
    public override double GetPerimeter() => A + B + SideC;
}
