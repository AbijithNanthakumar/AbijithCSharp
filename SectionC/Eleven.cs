using System;

class Vehicle
{
    public string color;

    public virtual void Ride()
    {
        Console.WriteLine("This can be ridden");
    }

    public virtual void Move()
    {
        Console.WriteLine("When riding vehicle moves");
    }
}

class Bike : Vehicle
{
    public override void Ride()
    {
        Console.WriteLine("Bike ride");
    }

    public sealed override void Move()
    {
        Console.WriteLine("When riding bike moves");

    }
}

class Car : Bike
{
    public override void Move()
    {
        Console.WriteLine("Car moves in the road");
    }
}

public class Program
{
    static void Main()
    {
        Bike b = new Bike();
        b.Ride();
        b.Move();

        Car c = new Car();
        c.Move();
    }
}