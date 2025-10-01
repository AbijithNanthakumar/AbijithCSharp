using System;

class Student
{
   private string name;
   public int ag;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
      //  Console.WriteLine(s.name);
        Console.WriteLine(s.age);
        s.Name = "Abijith";
        Console.WriteLine(s.Name);

    }
} 