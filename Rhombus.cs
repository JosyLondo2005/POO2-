using System;

namespace Geometry;

class Rhombus : Square
{
    private double diagonal1, diagonal2;
    public double Diagonal1 => diagonal1;
    public double Diagonal2 => diagonal2;

    public Rhombus(string name, double side, double diag1, double diag2) : base(name, side)
    {
        if (diag1 <= 0 || diag2 <= 0)
            throw new ArgumentException("Las diagonales deben ser valores positivos.");
        
        diagonal1 = diag1;
        diagonal2 = diag2;
    }

    public override double GetArea() => (Diagonal1 * Diagonal2) / 2;
    public override double GetPerimeter() => 4 * A;
}
