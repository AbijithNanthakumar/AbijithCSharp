using System;

public partial class Student
{
    // Partial method implementation
    partial void Greet()
    {
        Console.WriteLine($"Hello, {Name}!");
    }
}
