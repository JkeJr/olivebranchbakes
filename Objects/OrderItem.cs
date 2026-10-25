using System;
using System.Collections.Generic;
using System.Text;

namespace OliveBranchBakes.Objects
{
    public class OrderItem
    {
        public string Name = "";
        public decimal Price;
        public string Allergens = "";

        public OrderItem()
        {
            Name = "unnamed";
            Price = 0;
            Allergens = "none";
        }

        public OrderItem(string name, decimal price, string allergens)
        {
            Name = name;
            Price = price;
            Allergens = allergens;
        }

        public string GetDisplayText()
        {
            return $"{Name} | {Price} | {Allergens}";
        }
    }
}
