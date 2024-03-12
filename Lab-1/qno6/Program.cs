using System;

interface IArea
{
    double CalculateArea();
}

class Rectangle : IArea
{
    protected double length;
    protected double width;

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public double CalculateArea()
    {
        return length * width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle(5, 6);
        Console.WriteLine("Area of Rectangle: " + rect.CalculateArea());
    }
}
