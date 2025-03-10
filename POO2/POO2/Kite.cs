using System;

namespace Geometry;

class Kite : Rhombus
{
    private double sideB;
    public double SideB => sideB;

    public Kite(string name, double sideA, double diag1, double diag2, double sideB) : base(name, sideA, diag1, diag2)
    {
        if (sideB <= 0)
            throw new ArgumentException("El lado adicional debe ser positivo.");
        
        this.sideB = sideB;
    }

    public override double GetArea() => (Diagonal1 * Diagonal2) / 2;
    public override double GetPerimeter() => 2 * (A + SideB);
}
