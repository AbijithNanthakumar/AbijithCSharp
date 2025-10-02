using System;

class Vehicle {
    public int wheels = 2;
    private string engine = "V8";
    protected int mileage = 25;
    internal int year = 2025;

    public string Engine
    {
        get { return engine; }
        set { engine = value; }
    }
    
    public void display()
    {
        Console.WriteLine(wheels);
        Console.WriteLine(engine);
        Console.WriteLine(mileage);
        Console.WriteLine(year);
    }

}

class Bike : Vehicle
{
    public void show()
    {
        Console.WriteLine(wheels);
       // Console.WriteLine(engine); ---> Not Accesable as it is private
        Console.WriteLine(mileage);
        Console.WriteLine(year);
    }
}

public class Program
{
    public static void Main()
    {
        Vehicle v = new Vehicle();
        Console.WriteLine(v.wheels); // public
       // Console.WriteLine(v.engine); // private ---> Not Accessable
       // Console.WriteLine(v.mileage); // protected ---> Not Accessable 
        Console.WriteLine(v.year);// internal 
        Console.WriteLine(v.Engine);
    }
}