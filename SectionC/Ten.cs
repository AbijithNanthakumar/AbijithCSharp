using System;

class Vehicle
{
    public int wheels;
    public string color;

    public Vehicle(int wheels,string color)
    {
        this.wheels = wheels;
        this.color = color;
    }
}

class Bike : Vehicle
{
    public string type;
    public Bike(int wheels,string color,string type) : base(wheels,color)
    {
        this.type = type;
    }
 }

class Program
{
    static void Main()
    {
        Bike b = new Bike(2,"Black","Electric");
        Console.WriteLine(b.wheels);
    }
}