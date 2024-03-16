using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string inputString = Console.ReadLine();
        var charFrequency = inputString.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        Console.WriteLine("Character frequency:");
        foreach (var pair in charFrequency)
        {
            Console.WriteLine($"{pair.Key} : {pair.Value}");
        }
    }
}
