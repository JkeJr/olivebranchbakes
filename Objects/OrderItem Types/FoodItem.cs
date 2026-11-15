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
        public FoodItem(int calories, ItemCategories categories, string name, decimal price, AllergenList allergens, string start, string end, bool active) : base(categories, name, price, allergens, start, end, active)
        {
            Calories = calories;
        }
        public FoodItem(int calories, ItemCategories categories, string name, decimal price, AllergenList allergens, bool active) : base(categories, name, price, allergens, active)
        {
            Calories = calories;
        }

        // Used in ItemCreateForm
        public FoodItem(int calories, ItemCategories categories, string name, decimal price, AllergenList allergens, DateRange dateRange, bool active) : base(categories, name, price, allergens, dateRange, active)
        {
            Calories = calories;
        }
    }
}
