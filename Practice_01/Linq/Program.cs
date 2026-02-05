using System;
using System.Collections.Generic;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public double CGPA { get; set; }
}

class Program
{
    static void Main()
    {
        var students = new List<Student>()
        {
            new Student { Id = 01, Name = "Rahim", CGPA = 3.5 },
            new Student { Id = 02, Name = "Karim", CGPA = 2.9 },
            new Student { Id = 03, Name = "Hasan", CGPA = 3.2 },
            new Student { Id = 04, Name = "Sabbir", CGPA = 3.8 },
            new Student { Id = 05, Name = "Nayeem", CGPA = 2.7 },
            new Student { Id = 06, Name = "Arif", CGPA = 3.1 },
            new Student { Id = 07, Name = "Tanvir", CGPA = 3.6 },
            new Student { Id = 08, Name = "Fahim", CGPA = 3.9 },
            new Student { Id = 09, Name = "Sakib", CGPA = 2.5 },
            new Student { Id = 10, Name = "Imran", CGPA = 3.0 },

            new Student { Id = 11, Name = "Rafi", CGPA = 3.4 },
            new Student { Id = 12, Name = "Mahmud", CGPA = 2.8 },
            new Student { Id = 13, Name = "Jahid", CGPA = 3.3 },
            new Student { Id = 14, Name = "Shuvo", CGPA = 3.7 },
            new Student { Id = 15, Name = "Rakib", CGPA = 2.6 },
            new Student { Id = 16, Name = "Saiful", CGPA = 3.1 },
            new Student { Id = 17, Name = "Rasel", CGPA = 3.5 },
            new Student { Id = 18, Name = "Nazmul", CGPA = 3.9 },
            new Student { Id = 19, Name = "Mehedi", CGPA = 2.9 },
            new Student { Id = 20, Name = "Mamun", CGPA = 3.2 },

            new Student { Id = 21, Name = "Asif", CGPA = 3.6 },
            new Student { Id = 22, Name = "Sumon", CGPA = 2.4 },
            new Student { Id = 23, Name = "Alamin", CGPA = 3.0 },
            new Student { Id = 24, Name = "Parvez", CGPA = 3.8 },
            new Student { Id = 25, Name = "Shahin", CGPA = 2.7 },
            new Student { Id = 26, Name = "Biplob", CGPA = 3.3 },
            new Student { Id = 27, Name = "Tareq", CGPA = 3.5 },
            new Student { Id = 28, Name = "Kamal", CGPA = 2.6 },
            new Student { Id = 29, Name = "Jamil", CGPA = 3.1 },
            new Student { Id = 30, Name = "Sohel", CGPA = 3.7 },

            new Student { Id = 31, Name = "Hridoy", CGPA = 3.9 },
            new Student { Id = 32, Name = "Nabil", CGPA = 2.8 },
            new Student { Id = 33, Name = "Foysal", CGPA = 3.2 },
            new Student { Id = 34, Name = "Siam", CGPA = 3.6 },
            new Student { Id = 35, Name = "Anik", CGPA = 2.5 },
            new Student { Id = 36, Name = "Riad", CGPA = 3.4 },
            new Student { Id = 37, Name = "Zahid", CGPA = 3.0 },
            new Student { Id = 38, Name = "Nadim", CGPA = 3.8 },
            new Student { Id = 39, Name = "Amin", CGPA = 2.9 },
            new Student { Id = 40, Name = "Shakil", CGPA = 3.3 },

            new Student { Id = 41, Name = "Omar", CGPA = 3.5 },
            new Student { Id = 42, Name = "Farhan", CGPA = 3.1 },
            new Student { Id = 43, Name = "Rayhan", CGPA = 2.6 },
            new Student { Id = 44, Name = "Munir", CGPA = 3.7 },
            new Student { Id = 45, Name = "Irfan", CGPA = 3.9 },
            new Student { Id = 46, Name = "Kawsar", CGPA = 2.8 },
            new Student { Id = 47, Name = "Adnan", CGPA = 3.2 },
            new Student { Id = 48, Name = "Touhid", CGPA = 3.6 },
            new Student { Id = 49, Name = "Rony", CGPA = 2.7 },
            new Student { Id = 50, Name = "Sajid", CGPA = 3.4 }
        };


        //var student = students.Select(s => new Student {
        //    Id = s.Id,
        //    Name = s.Name,
        //    CGPA = s.CGPA
        //});

        //foreach (var s in student)
        //{
        //    Console.WriteLine($"Id: {s.Id}, Name: {s.Name}, CGPA: {s.CGPA}");
        //}

        //var goodStudents = students.Where(s => s.CGPA >= 3.5);
        //var goodStudents = from student in students
        //                    where student.CGPA >= 3.5
        //                    select student;

        //var ordered = students.OrderByDescending(x => x.CGPA);

        var ordered = students
                       .OrderByDescending(s => s.CGPA)
                       .ThenBy(s => s.Id);

        foreach (var s in ordered)
        {
            Console.WriteLine($"Id: {s.Id}, Name: {s.Name}, CGPA: {s.CGPA}");
        }

        var groups = students.GroupBy(s => s.CGPA >= 3.0 ? "Good" : "Average");

        foreach (var g in groups)
        {
            Console.WriteLine(g.Key);
            foreach (var s in g)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();
        }


    }
}
