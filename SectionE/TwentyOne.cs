using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public int Salary { get; set; }
    
    public override string ToString()
    {
        return $"Id is {Id},Name is {Name}";
    }
}

class Program
{
    static void Main()
    {
        List<Employee> list = new List<Employee>
        {
             new Employee { Id = 1, Name = "Alice", Department = "HR", Salary = 50000 },
                new Employee { Id = 2, Name = "Bob", Department = "IT", Salary = 70000 },
                new Employee { Id = 3, Name = "Charlie", Department = "IT", Salary = 80000 },
                new Employee { Id = 4, Name = "Diana", Department = "Finance", Salary = 60000 },
                new Employee { Id = 5, Name = "Eve", Department = "HR", Salary = 55000 },
        };

        // Filter
        var highearner = list.Where(e => e.Salary > 50000);

        Console.WriteLine("High Earners");
        foreach (var emp in highearner)
        {
            Console.WriteLine(emp);
        }

        // Group
        var groupingbyDepartment = list
            .GroupBy(e => e.Department);

        foreach (var group in groupingbyDepartment)
        {
            Console.WriteLine(group.Key);
            foreach (var emp in group)
            {
                Console.WriteLine(emp);
            }
        }


        //OrderBy
        var orderedBySalary = list
                       .OrderByDescending(e => e.Salary);

        Console.WriteLine("\nEmployees ordered by salary (descending):");
        foreach (var emp in orderedBySalary)
        {
            Console.WriteLine(emp);
        }

        // 4?? Select: Name and Salary only
        var nameAndSalary = list
            .Select(e => new { e.Name, e.Salary });

        Console.WriteLine("\nEmployee Name and Salary:");
        foreach (var emp in nameAndSalary)
        {
            Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary}");
        }

       // Console.WriteLine("\nPress any key to exit...");
       //Console.ReadKey();
    }
}