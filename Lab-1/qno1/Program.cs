using System;

class AddTwoDigits
{
    private int num1;
    private int num2;

    public AddTwoDigits(int a, int b)
    {
        num1 = a;
        num2 = b;
    }

    public int Add()
    {
        return num1 + num2;
    }

    static void Main(string[] args)
    {
        AddTwoDigits adder = new AddTwoDigits(5, 7);
        Console.WriteLine("Sum: " + adder.Add());
    }
}
