using System;
using System.Collections.Generic;
using System.Linq;

public class Student<T> where T : class
{
    private readonly List<T> _list = new List<T>();
    
    public void Add(T item)
    {
        _list.Add(item);
        Console.WriteLine("Item added Successfully");
    }

    public void Update(T olditem,T newitem)
    {
        int index = _list.IndexOf(olditem);
        
        if(index >= 0)
        {
            _list[index] = newitem;
            Console.WriteLine("updated Successfully");
        }
        else
        {
            Console.WriteLine("No update Done");
        }
    }

    public void Delete(T item)
    {
        _list.Remove(item);
        Console.WriteLine("Delete Successfully");
    }

    public List<T> getAll()
    {
        return new List<T>(_list);
    }

}

class StudentDetails()
{
    public int Id { get; set; }
    public string Name { get; set; }  

    public override string ToString()
    {
        return $"Product[Id={Id}, Name={Name}]";
    }
}

class Program
{
    static void Main()
    {
        Student<StudentDetails> rs = new Student<StudentDetails> ();

        var s = new StudentDetails { Id = 1, Name = "Abijith" };
        var s2 = new StudentDetails { Id = 2, Name = "Anumidha" };

        rs.Add(s);
        rs.Add(s2);

        rs.Update(s, new StudentDetails { Id = 1, Name = "Aaryan" }); 

        rs.Delete(s);


        foreach (var p in rs.getAll())
        {
            Console.WriteLine(p);
        }
    }
}