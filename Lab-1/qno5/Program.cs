using System;

class A
{
    public void Display()
    {
        Console.WriteLine("Class A");
    }
}

class B : A
{
    public void Show()
    {
        Console.WriteLine("Class B");
    }
}

class C : B
{
    public void Print()
    {
        Console.WriteLine("Class C");
    }
}

class D
{
    public void Show()
    {
        Console.WriteLine("Class D");
    }
}

class E : D
{
    public void Print()
    {
        Console.WriteLine("Class E");
    }
}

class Program
{
    static void Main(string[] args)
    {
        C objC = new C();
        objC.Display();
        objC.Show();
        objC.Print();

        E objE = new E();
        objE.Show();
        objE.Print();
    }
}

