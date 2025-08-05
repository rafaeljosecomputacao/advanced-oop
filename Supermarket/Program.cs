using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using Supermarket.Models.Entities;

namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            { 
                new Product("Roast chicken", 10.00),
                new Product("Loin", 5.00),
                new Product("Cookies", 3.00),
                new Product("Pepperoni", 2.00),
                new Product("Cheese", 14.00),
                new Product("Cake", 4.00),
                new Product("Apple pie", 6.00),
                new Product("Orange juice", 2.00)
            };

            var average = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average product prices:");
            Console.WriteLine("$" + average.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Products sorted by name:");
            var names = products.Where(p => p.Price < average).OrderBy(p => p.Name).Select(p => p.Name);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
