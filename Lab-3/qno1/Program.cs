using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] marks = { 78, 85, 90, 60, 88, 95, 75, 82 };
        var studentsWithHighMarks = marks.Count(mark => mark > 80);
        Console.WriteLine($"Number of students with marks greater than 80: {studentsWithHighMarks}");
    }
}
