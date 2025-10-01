using System;

public partial class Student
{
    public string Name;

    partial void Greet();
    public Student(string name)
    {
        Name = name;
        Greet();  // Calls partial method
    }

     // Partial method declaration
}
