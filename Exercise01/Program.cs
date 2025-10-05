using System;
using System.Collections.Generic;
using System.Linq;


namespace Exercise01
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString() => $"{Name} (Age: {Age})";
    }


    class Student : Person
    {
        public string StudentId { get; set; }
        public double GPA { get; set; }


        public void Study() => Console.WriteLine($"{Name} is studying...");


        public override string ToString() => $"{base.ToString()}, ID: {StudentId}, GPA: {GPA}";
    }


    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
{
new Student { Name = "An", Age = 20, StudentId = "S001", GPA = 3.4 },
new Student { Name = "Binh", Age = 21, StudentId = "S002", GPA = 3.8 },
new Student { Name = "Cuong", Age = 19, StudentId = "S003", GPA = 2.9 }
};


            Console.WriteLine("All students:");
            students.ForEach(s => Console.WriteLine(s));


            var top = students.OrderByDescending(s => s.GPA).First();
            Console.WriteLine($"\nTop student: {top}\n");


            top.Study();


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}