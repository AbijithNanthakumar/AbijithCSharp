using System;
using System.Collections;
using System.Collections.Generic;

namespace YieldReturnExample
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Student[Id={Id}, Name={Name}]";
        }
    }

    public class StudentCollection : IEnumerable<Student>
    {
        private List<Student> _students = new List<Student>();

        public void Add(Student student)
        {
            _students.Add(student);
        }


        public IEnumerator<Student> GetEnumerator()
        {
            foreach (var student in _students)
            {
                yield return student;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var students = new StudentCollection();

            students.Add(new Student { Id = 1, Name = "Alice" });
            students.Add(new Student { Id = 2, Name = "Bob" });
            students.Add(new Student { Id = 3, Name = "Charlie" });

            Console.WriteLine("Iterating over students:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
