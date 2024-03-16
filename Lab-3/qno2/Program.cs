using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string inputString = "Hello World";
        var upperCaseLetters = inputString.Where(char.IsUpper);
        Console.WriteLine("Uppercase letters in the string:");
        foreach (var letter in upperCaseLetters)
        {
            Console.WriteLine(letter);
        }
    }
}
