using hw8;

List<Shape> shapes = new List<Shape>();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Enter name of {i + 1} circle: ");
    string nameC = Console.ReadLine();
    Console.WriteLine($"Enter radius of {i + 1} circle: ");
    double radius = Convert.ToDouble( Console.ReadLine() );
    shapes.Add(new Circle(nameC, radius));

    Console.WriteLine($"Enter name of {i + 1} square: ");
    string nameS = Console.ReadLine();
    Console.WriteLine($"Enter side of {i + 1} square: ");
    double side = Convert.ToDouble(Console.ReadLine());
    shapes.Add(new Square(nameS, side));
}

foreach (Shape shape in shapes)
{
    if(shape.GetType() == typeof(Circle))
        Console.WriteLine($"Circle name: {shape.Name}, area: {shape.Area()}, perimeter: {shape.Perimeter()}");
    if (shape.GetType() == typeof(Square))
        Console.WriteLine($"Square name: {shape.Name}, area: {shape.Area()}, perimeter: {shape.Perimeter()}");
}

double maxPerimeter = double.MinValue;
string nameMaxPerimeter = string.Empty;

foreach (Shape shape in shapes)
{
    double perimeter = shape.Perimeter();
    if(perimeter > maxPerimeter)
    {
        maxPerimeter = perimeter;
        nameMaxPerimeter = shape.Name;
    }
}

Console.WriteLine($"Shape with the largest perimeter: {nameMaxPerimeter}");

shapes.Sort();
Console.WriteLine("After sorting shapes by area:");
foreach (Shape shape in shapes)
{
    Console.WriteLine($"Name: {shape.Name}, area: {shape.Area()}, perimeter: {shape.Perimeter()}");
}
