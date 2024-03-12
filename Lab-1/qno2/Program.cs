using System;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.Id = 101;
        student.Name = "Either Man";

        Console.WriteLine("Student ID: " + student.Id);
        Console.WriteLine("Student Name: " + student.Name);
    }
}
