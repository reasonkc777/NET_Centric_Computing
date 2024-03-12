using System;

delegate int AddDelegate(int a, int b);

class Program
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static void Main(string[] args)
    {
        AddDelegate addDelegate = new AddDelegate(Add);
        Console.WriteLine("Sum: " + addDelegate(5, 7));
    }
}
