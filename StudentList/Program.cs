using System;
using System.Collections.Generic;

namespace School
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student() { Name = "Sally", GradeLevel = 3 },
                new Student() { Name = "Bob", GradeLevel = 3 },
                new Student() { Name = "Sally", GradeLevel = 2 }
            };
            
            SchoolRoll schoolRoll = new SchoolRoll();
            schoolRoll.AddStudents(students);
          
          schoolRoll.Students.RemoveAt(0);
          schoolRoll.Students.Sort();
          
          schoolRoll.Students.AddRange(students);
            
            foreach(Student student in schoolRoll.Students)
            {
                Console.WriteLine($"{student.Name} is in grade {student.GradeLevel}");
            }
        }
    }
}