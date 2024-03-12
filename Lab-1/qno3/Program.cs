using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        Array.Reverse(array);
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }
}
