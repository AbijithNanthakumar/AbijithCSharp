using System;

//class Student
//{
//    public static void display()
//    {
//        Console.WriteLine("Displayed");
//        Student s = new Student();
//        s.Move();
//    }

//    public  void Move()
//    {
//        Console.WriteLine("Moving");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Student s = new Student();
//        Student.display();
//    }
//}

//class Student
//{
//    public string name;

//    public Student(string name)
//    {
//        this.name = name;
//    }

//    public virtual void display()
//    {
//        Console.WriteLine("Abijith");
//    }
//}

//class Abi : Student
//{
//    public int age;
//    public Abi(string name,int age) : base(name)
//     {
//        this.age = age;
//      }
//    public override void display()
//    {
//        Console.WriteLine(name);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Abi s = new Abi("Abijith",20);
//        s.display();
//    }
//}

abstract class Student
{
    public abstract void demo();

    //public virtual void demo()
    //{
    //    Console.WriteLine("Hello");
    //}
}

class Abi : Student
{
    public override void demo()
    {
        Console.WriteLine("Demo");
    }
}

class Program
{
    static void Main()
    {
        Student s = new Abi();
        s.demo();
    }
}