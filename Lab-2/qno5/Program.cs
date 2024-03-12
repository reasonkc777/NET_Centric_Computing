using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> customers = new Dictionary<int, string>();
        customers.Add(101, "Kartik Shrestha");
        customers.Add(102, "Elon Musk");
        customers.Add(103, "Petu Ambani");

        foreach (var customer in customers)
        {
            Console.WriteLine("Customer ID: " + customer.Key + ", Name: " + customer.Value);
        }
    }
}
