﻿using System;
using System.Globalization;

namespace ButcherShop.Models.Entities
{
    internal class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException("Comparison error: argument isn't a product");
            }

            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return Name + ", $" + Price.ToString("F2", CultureInfo.InvariantCulture);
        }   
    }
}
