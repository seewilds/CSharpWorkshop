// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var isEnough1 = Solution.IsEnough(0, new IShape[0]);
var isEnough2 = Solution.IsEnough(1, new[] { new Rectangle(1, 1) });
var isEnough3 = Solution.IsEnough(100, new IShape[] { new Circle(5) });
var isEnough4 = Solution.IsEnough(5, new IShape[]
{
    new Rectangle(1, 1), new Circle(1), new Rectangle(1.4,1)
});
Console.WriteLine($"IsEnough1 = {isEnough1}, " +
$"IsEnough2 = {isEnough2}, " +
$"IsEnough3 = {isEnough3}, " +
$"IsEnough4 = {isEnough4}.");



interface IShape
{
    double Area { get; }
}

class Rectangle : IShape
{
    private readonly double _width;
    private readonly double _height;
    public double Area
    {
        get
        {
            return _width * _height;
        }
    }
    public Rectangle(double width, double height)
    {
    }
}

class Circle : IShape
{
    private readonly double _radius;
    public double Area
    {
        get { return Math.PI * _radius * _radius; }
    }
    public Circle(double radius)
    {
        _radius = radius;
    }

}

static class Solution
{
    public static bool IsEnough(double mosaicArea, IShape[] tiles)
    {
        double totalArea = 0;
        foreach (var tile in tiles)
        {
            totalArea += tile.Area;
        }
        const double tolerance = 0.0001;
        return totalArea - mosaicArea >= -tolerance;
    }
}
