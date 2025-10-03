using System;

class Student
{
    // Compile-Time polymorphism
    public virtual void display()
    {
        Console.WriteLine("The display");
    }

    public void display(string name)
    {
        Console.WriteLine(name);
    }
}
class Abi : Student
{
    // Run-time polymorphism...
    public override void display()
    {
        Console.WriteLine("Iam Abijith");
    }
}
class Program
{
    static void Main()
    {
        Student s = new Abi();
        s.display();
    }
}