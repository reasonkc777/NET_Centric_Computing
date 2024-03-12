using System;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing Shape");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Rectangle");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape shape;

        shape = new Circle();
        shape.Draw();

        shape = new Rectangle();
        shape.Draw();
    }
}
