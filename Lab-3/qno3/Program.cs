using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        var squares = numbers.Select(num => new { Number = num, Square = num * num });
        Console.WriteLine("Numbers and their squares:");
        foreach (var item in squares)
        {
            Console.WriteLine($"{item.Number} : {item.Square}");
        }
    }
}
