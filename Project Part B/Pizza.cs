﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Part_B
{
    public class Pizza : IComparable<Pizza>, ICloneable
    {
        public PizzaName Name { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }

        public Pizza(PizzaName name, string size, double price)
        {
            Name = name;
            Size = size;
            Price = price;
        }

        public int CompareTo(Pizza other)
        {
            return Price.CompareTo(other.Price);
        }

        public object Clone()
        {
            return new Pizza(Name, Size, Price);
        }
    }

}
