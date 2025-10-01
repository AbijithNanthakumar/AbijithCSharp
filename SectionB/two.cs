using System;

class Program
{
    public const int age2 = 5; // Cannot be changed 
    public readonly int age = 10; //Can be changed in the construtor 

    public Program(int age)
    {
        this.age = age;
    }
}

class Student
{
    static void Main()
    {
        Program p = new Program(20);
        Console.WriteLine(p.age);
    }
}