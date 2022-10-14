using System;
using System.Collections;
using System.Collections.Generic;

namespace Homework
{
    class Program
    {
        public static void Main(string[] args)
        {
            ex1();
        }
        class Student
        {
            public string Family { get; set; }
            public string Name { get; set; }
            public DateTime DOB { get; set; }
            public int EntranceMark { get; set; }
            public int Mark { get; set; }
            public Student(string n, string d, int e = 0, int m = 0)
            {
                Name = n;
                DOB = DateTime.Parse(d);
                EntranceMark = e;
                Mark = m;
            }
        }
        
        public static void ex1()
        {
            

            Dictionary<int, Student> students = new Dictionary<int, Student>();
            {
                { 1 new() Student("Петров", "10.10.2000", 100, 150) },
            };


            Console.WriteLine("Choose needed option");
            Console.WriteLine();
            Console.WriteLine("If you need to add a new student, enter 'New Student' ");
            Console.WriteLine("If you need to delete a student enter 'Delete'");
            Console.WriteLine("If you need to sort be points enter 'Sort'");
            Console.ReadLine();
        }
    
    }
}
