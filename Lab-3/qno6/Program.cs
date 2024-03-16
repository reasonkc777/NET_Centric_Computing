using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class Score
    {
        public int StudentID { get; set; }
        public int Marks { get; set; }
    }

    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { ID = 1, Name = "Alice" },
            new Student { ID = 2, Name = "Bob" },
            new Student { ID = 3, Name = "Charlie" }
        };

        List<Score> scores = new List<Score>
        {
            new Score { StudentID = 1, Marks = 85 },
            new Score { StudentID = 2, Marks = 90 },
            new Score { StudentID = 3, Marks = 80 }
        };

        var studentScores = from student in students
                            join score in scores on student.ID equals score.StudentID
                            select new { student.Name, score.Marks };

        Console.WriteLine("Student Scores:");
        foreach (var item in studentScores)
        {
            Console.WriteLine($"{item.Name} : {item.Marks}");
        }
    }
}
