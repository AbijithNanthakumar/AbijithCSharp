using System;

abstract class Shape
{
    
    public abstract  double CalculateArea();

}

class Circle : Shape
{
    public int radius;
    public Circle(int radius)
    {
        this.radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}

class Rectangle : Shape
{
    public int length;
    public int breadth;

    public Rectangle(int length,int breadth)
    {
        this.length = length;
        this.breadth = breadth;
       
    }

    public override double CalculateArea()
    {
        return length*breadth;
    }

}


class Program
{
    static void Main()
    {
        Circle c = new Circle(5);
        Console.WriteLine(c.CalculateArea());

        Rectangle r = new Rectangle(12,10);
        Console.WriteLine(r.CalculateArea());
       
    }
}