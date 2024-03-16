using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEWDELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
        char startChar = 'A';
        char endChar = 'M';
        var selectedCities = cities.Where(city => city.StartsWith(startChar) && city.EndsWith(endChar));
        Console.WriteLine($"Cities starting with '{startChar}' and ending with '{endChar}':");
        foreach (var city in selectedCities)
        {
            Console.WriteLine(city);
        }
    }
}
