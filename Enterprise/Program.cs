using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Enterprise.Models.Entities;

namespace Enterprise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            string sourcePath = @"c:\temp\employees.csv";

            using(StreamReader sr = File.OpenText(sourcePath))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    string name = line[0];
                    double salary = double.Parse(line[1], CultureInfo.InvariantCulture);
                    employees.Add(new Employee(name, salary));
                }
            }

            Console.Write("Enter a salary amount: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Names of employees whose salary is higher than the amount entered:");
            var names = employees.Where(e => e.Salary > amount).OrderBy(e => e.Name).Select(e => e.Name);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            double sum = employees.Where(e => e.Name[0] == 'M').Select(e => e.Salary).DefaultIfEmpty(0.0).Sum();
            Console.WriteLine("Sum of salary of employees whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
