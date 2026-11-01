using OliveBranchBakes.Objects.Order_Assets;
using System;
using System.Collections.Generic;
using System.Text;

namespace OliveBranchBakes.Objects.OrderItem_Types
{
    internal class FoodItem : OrderItem
    {
        public int Calories { get; init; }
        
        // Used in DataManagement
        public FoodItem(int calories, ItemCategories categories, string name, decimal price, AllergenList allergens, string start, string end) : base(categories, name, price, allergens, start, end)
        {
            Calories = calories;
        }
        public FoodItem(int calories, ItemCategories categories, string name, decimal price, AllergenList allergens) : base(categories, name, price, allergens)
        {
            Calories = calories;
        }

        // Used in ItemCreateForm
        public FoodItem(int calories, ItemCategories categories, string name, decimal price, AllergenList allergens, DateRange dateRange) : base(categories, name, price, allergens, dateRange)
        {
            Calories = calories;
        }
    }
}
