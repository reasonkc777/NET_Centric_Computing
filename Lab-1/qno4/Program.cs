using System;

class Students
{
    private string[] names = new string[5];

    public string this[int index]
    {
        get { return names[index]; }
        set { names[index] = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Students students = new Students();
        students[0] = "Alish";
        students[1] = "Swikar";
        students[2] = "Prakar";
        students[3] = "Prashanna";
        students[4] = "Saurav";

        Console.WriteLine("Student 2: " + students[1]);
    }
}
