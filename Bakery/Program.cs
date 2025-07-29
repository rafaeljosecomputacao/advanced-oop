using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using Bakery.Models.Entities;

namespace Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Baker> bakers = new List<Baker>();

            string sourcePath = @"c:\temp\bakers.csv";

            try
            {
                using (StreamReader sr = File.OpenText(sourcePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        double salary = Double.Parse(line[1], CultureInfo.InvariantCulture);
                        bakers.Add(new Baker(name, salary));
                    }

                    bakers.Sort();

                    foreach (Baker baker in bakers)
                    {
                        Console.WriteLine(baker);
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
