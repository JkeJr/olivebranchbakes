using OliveBranchBakes.Objects.Order_Assets;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;

namespace OliveBranchBakes.Objects
{
    public abstract class OrderItem
    {
        public string Name = "";
        public ItemCategories Categories;
        public decimal Price { get; set; }
        //public Allergen Allergy { get; set; } = new(AllergenIngredients.None);
        public AllergenList AllergenList;

        public int Count { get; set; }
        public bool Seasonal { get; init; } = false;
        public bool Active { get; set; } = true;
        public DateRange? Season;

        public OrderItem(ItemCategories categories, string name, decimal price, AllergenList allergens, bool active)
        {
            Categories = categories;
            Name = name;
            Price = price;
            AllergenList = allergens;
            Count = 1;
            Active = active;
        }
        public OrderItem(ItemCategories categories, string name, decimal price, AllergenList allergens, DateRange range, bool active)
        {
            Categories = categories;
            Name = name;
            Price = price;
            AllergenList = allergens;
            Count = 1;
            Active = active;

            Seasonal = true;
            Season = range;
        }
        public OrderItem(ItemCategories categories, string name, decimal price, AllergenList allergens, string start, string end, bool active)
        {
            Categories = categories;
            Name = name;
            Price = price;
            AllergenList = allergens;
            Count = 1;
            Active = active;

            Seasonal = true;
            Season = new(start, end);
        }

        public bool InCategory(string category)
        {
            bool result = false;

            if (category == "None")
                result = true;
            else
            {
                CategoryEnums categoryEnum = (CategoryEnums)Enum.Parse(typeof(CategoryEnums), category);
                if (Categories.IndexOf(categoryEnum) != -1)
                    result = true;
            }
            return result;
        }
        public void ToggleActive() => Active = !Active;
        public bool InSeason()
        {
            if (this.Seasonal)
            {
                if (DateTime.Today < Season![0])
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

        
        // return formatted string for writing seasonal info to file
        public string SeasonalInfo() => (this.Seasonal) ? $"s|{Season!.Start}|{Season.End}" : "ns|null|null";

        public string GetDisplayText()
        {
            return $"{Name} | {Price} | {Count} | {AllergenList.ToString(", ")}";
        }
    }
}
