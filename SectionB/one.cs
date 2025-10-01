
using System;

// Constructor chaining and Method Overloading
public class Student
{
    string name;
    int age;
    int marks;

    public Student()
    {
        this.name = "Abijith";
        this.age = 22;
    }

    public Student(string name, int age) : this()
    {
        this.name = name;
        this.age = age;
    }

    public Student(string name, int age, int marks) : this(name, age)
    {
        this.marks = marks;


    }

    // method Overloading::::::::::

    public void display()
    {
        Console.WriteLine(name + "  " + age + "  " + marks);
    }

    public void display(string name, int age)
    {
        Console.WriteLine(name + " " + age);
    }
}


class Program
{
    static void Main()
    {
        Student student = new Student("Abijith", 20,65);
        student.display();
        student.display("Anirudh",21);
    }
}


