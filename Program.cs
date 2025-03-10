using Geometry;

var shapes = new List<GeometricFigure>
{
    new Circle("Circle", 5),
    new Square("Square", 10),
    new Rhombus("Rhombus", 5, 7, 10),
    new Kite("Kite", 7, 6, 5, 8),
    new Rectangle("Rectangle", 4.57, 67.79),
    new Parallelogram("Parallelogram", 14.65, 54.67, 23.09),
    new Triangle("Triangle", 45.56, 12.34, 27.09, 15),
    new Trapeze("Trapeze", 10, 20, 30, 40, 20)
};

foreach (var shape in shapes)
{
    Console.WriteLine($"{shape.Name}: Area = {shape.GetArea()}, Perimeter = {shape.GetPerimeter()}");
}
