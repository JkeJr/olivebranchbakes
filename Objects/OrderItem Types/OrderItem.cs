using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace OliveBranchBakes.Objects
{
    public class OrderItem
    {
        public string Name = "";
        public decimal Price;
        public string Allergens = "";
        public AllergenList AllergenList;

        public bool Seasonal { get; init; } = false;

        public DateRange? Season;

        public OrderItem()
        {
            Name = "unnamed";
            Price = 0;
            Allergens = "none";
        }

        public OrderItem(string name, decimal price, string[] allergens)
        {
            Name = name;
            Price = price;
            AllergenList = new(allergens);
        }
        public OrderItem(string name, decimal price, string[] allergens, DateRange range)
        {
            Name = name;
            Price = price;
            AllergenList = new(allergens);

            Seasonal = true;
            Season = range;
        }
        public OrderItem(string name, decimal price, string[] allergens, string start, string end)
        {
            Name = name;
            Price = price;
            AllergenList = new(allergens);

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

        // return formatted string for writing seasonal info to file
        public string SeasonalInfo() => (this.Seasonal) ? $"s|{Season.Start}|{Season.End}" : "ns|null|null";

        public string GetDisplayText()
        {
            return $"{Name} | {Price} | {Allergens}";
        }
    }
}
