using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Ram", "Shyam", "Hari", "Bikash", "Mahesh" };
        var sortedNames = names.OrderBy(name => name);
        foreach (var name in sortedNames)
        {
            Console.WriteLine(name);
        }
    }
}