using System;
using System.Globalization;

namespace Bakery.Models.Entities
{
    internal class Baker : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Baker(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return Name + "," + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Baker))
            {
                throw new ArgumentException("Comparing error: argument isn't a Baker");
            }

            Baker other = obj as Baker;
            return Salary.CompareTo(other.Salary);
        }
    }
}
