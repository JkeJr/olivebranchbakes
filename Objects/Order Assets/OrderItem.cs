using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;

namespace OliveBranchBakes.Objects
{
    public class OrderItem
    {
        public string Name = "";
        public decimal Price { get; set; }
        public Allergen Allergy { get; set; } = new(AllergenIngredients.None);
        public AllergenList AllergenList;

        public int Count { get; set; }
 
        public bool Seasonal { get; init; } = false;

        public DateRange? Season;

        public OrderItem()
        {
            Name = "unnamed";
            Price = 0;
            AllergenList = new(Allergy);
        }

        public OrderItem(string name, decimal price, string[] allergens)
        {
            Name = name;
            Price = price;
            AllergenList = new(allergens);
            Count = 1;
        }
        public OrderItem(string name, decimal price, string[] allergens, DateRange range)
        {
            Name = name;
            Price = price;
            AllergenList = new(allergens);
            Count = 1;

            Seasonal = true;
            Season = range;
        }
        public OrderItem(string name, decimal price, string[] allergens, string start, string end)
        {
            Name = name;
            Price = price;
            AllergenList = new(allergens);
            Count = 1;

            Seasonal = true;
            Season = new(start, end);
        }

        public bool InSeason()
        {
            if (this.Seasonal)
            {
                if (DateTime.Today < Season[0])
                    return false;
                else if (DateTime.Today > Season[1])
                    return false;
                else 
                    return true;
            }
            return true;
        }

        // Adding two OrderItems
        public void Add(OrderItem item)
        {
            this.Count += item.Count;
            this.Price += item.Price;
        }
        public static OrderItem operator +(OrderItem item1, OrderItem item2)
        {
            item1.Add(item2);
            return item1;
        }

        // Equality method, based on Name and Allergy
        public bool Equals(OrderItem item)
        {
            if (item == null!)
            {
                if (this == null!)
                {
                    return true;
                }
                else
                    return false;
            }
            else if (this.Name == item.Name && this.Allergy == item.Allergy)
                return true;
            else
                return false;
        }
        /*public static bool operator ==(OrderItem item1, OrderItem item2)
        {
            return item1.Equals(item2);
        }
        public static bool operator !=(OrderItem item1, OrderItem item2)
        {
            return !(item1.Equals(item2));
        }*/

        // return formatted string for writing seasonal info to file
        public string SeasonalInfo() => (this.Seasonal) ? $"s|{Season.Start}|{Season.End}" : "ns|null|null";

        public string GetDisplayText()
        {
            return $"{Name} | {Price} | {Count} | {AllergenList.GetDisplayText(", ")}";
        }
    }
}
