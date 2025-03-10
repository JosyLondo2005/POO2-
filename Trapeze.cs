using System;

namespace Geometry;

class Trapeze : Triangle
{
    private double sideD;
    public double SideD => sideD;

    public Trapeze(string name, double sideA, double sideB, double sideC, double height, double sideD) : base(name, sideA, sideB, sideC, height)
    {
        if (sideD <= 0)
            throw new ArgumentException("El lado adicional debe ser positivo.");
        
        this.sideD = sideD;
    }

    public override double GetArea() => ((B + SideD) * H) / 2;
    public override double GetPerimeter() => A + B + C + SideD;
}
