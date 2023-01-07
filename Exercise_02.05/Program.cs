
Circle c1 = new Circle { Radius = 2.0 };
Circle c2 = new Circle { Radius = 3.0 };
Console.WriteLine(c1 + c2);
Console.WriteLine(2.0 + 3.0);

public struct Circle
{
    public double Radius;
    public double Area => Math.PI * Radius * Radius;
    public static double operator +(Circle c1, Circle c2)
    {
        return c1.Area + c2.Area;
    }
}
