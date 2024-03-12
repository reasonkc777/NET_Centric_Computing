using System;

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Divide(int a, int b)
    {
        if (b != 0)
            return a / b;
        else
        {
            Console.WriteLine("Cannot divide by zero.");
            return 0;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        Console.WriteLine("Addition: " + calculator.Add(5, 7));
        Console.WriteLine("Subtraction: " + calculator.Subtract(10, 3));
        Console.WriteLine("Multiplication: " + calculator.Multiply(4, 6));
        Console.WriteLine("Division: " + calculator.Divide(20, 4));
    }
}
