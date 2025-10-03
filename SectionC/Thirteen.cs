using System;

public interface IShape
{
    double CalculateArea();

}

class Circle : IShape
{
    public double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }
    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}

class Rectangle : IShape
{
    public int length;
    public int breadth;

    public Rectangle(int length,int breadth)
    {
        this.length = length;
        this.breadth = breadth;
    }
    public double CalculateArea()
    {
        return length*breadth;
    }
}


class Program
{
    static void Main()
    {
        //IShape circle = new Circle(5);
        var c = new Circle(5);
        IShape rectangle = new Rectangle(12, 10);

        Console.WriteLine(c.CalculateArea());
    }
}