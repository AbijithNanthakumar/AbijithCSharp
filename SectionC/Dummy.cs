using System;

class Student
{
    public static void display()
    {
        Console.WriteLine("Displayed");
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        Student.display();
    }
}