using System;
using System.Globalization;
using System.Collections.Generic;
using ButcherShop.Models.Entities;
using ButcherShop.Services;

namespace ButcherShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] aux = Console.ReadLine().Split(',');
                string name = aux[0];
                double price = double.Parse(aux[1], CultureInfo.InvariantCulture);
                products.Add(new Product(name, price));
            }

            ProductService productService = new ProductService();
            Console.WriteLine("Most expensive: " + productService.MostExpensive(products));
        }
    }
}
