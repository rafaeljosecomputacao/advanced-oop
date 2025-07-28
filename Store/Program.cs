using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using Store.Models.Entities;

namespace Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            try
            {
                string sourcePath = @"c:\temp\items.csv";

                using (StreamReader sr = File.OpenText(sourcePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        double price = double.Parse(line[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(line[2]);
                        products.Add(new Product(name, price, quantity));
                    }
                }

                Directory.CreateDirectory(@"c:\temp\out");
                string targetPath = @"c:\temp\out\summary.csv";

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (Product product in products)
                    {
                        sw.WriteLine(product);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error occurred: " + e.Message);
            }
        }
    }
}
