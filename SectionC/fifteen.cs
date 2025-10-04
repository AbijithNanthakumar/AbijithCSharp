using System;


class Animal
{
    public void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

class Dog : Animal
{
    public new void Speak() // Method hiding using 'new'
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.Speak();               

        Animal a = new Dog();
        a.Speak();              
    }
}
