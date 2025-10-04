using System;

abstract class Student
{
    public string name;
    public int age;
    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
        Console.WriteLine(this.name);
    }

    public abstract void display();
}


class Abi : Student
{
    int year;
    public Abi(string name, int age, int year) : base(name, age)
    {
        this.year = year;
    }

    public override void display()
    {
        Console.WriteLine(base.name);
        Console.WriteLine(age);
        Console.WriteLine(year);

    }
}

class Program
{
    static void Main()
    {
        Student s = new Abi("Abijith", 22, 2003);
        s.display();
    }
}


//using System;

//class Student
//{
//    public string name;

//    public Student(string name)
//    {
//        this.name = name;
//    }

//}

//class Abi : Student
//{
//    int age;
//    public Abi(string name,int age) : base(name)
//    {
//        this.age = age;
//    } 

//    public  void display()
//    {
//        Console.WriteLine(base.name);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Abi a = new Abi("Abijith",22);
//        a.display();        
//    }
//}