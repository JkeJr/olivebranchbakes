using OliveBranchBakes.Objects.Order_Assets;
using System;
using System.Collections.Generic;
using System.Text;

namespace OliveBranchBakes.Objects.OrderItem_Types
{
    internal class DrinkItem : OrderItem
    {
        public int Ounces { get; init; }

        // Used in DataManagement
        public DrinkItem(int ounces, ItemCategories categories, string name, decimal price, AllergenList allergens, string start, string end, bool active) : base(categories, name, price, allergens, start, end, active)
        {
            Ounces = ounces;
        }
        public DrinkItem(int ounces, ItemCategories categories, string name, decimal price, AllergenList allergens, bool active) : base(categories, name, price, allergens, active)
        {
            Ounces = ounces;
        }

        // Used in ItemCreateForm
        public DrinkItem(int ounces, ItemCategories categories, string name, decimal price, AllergenList allergens, DateRange dateRange, bool active) : base(categories, name, price, allergens, dateRange, active)
        {
            Ounces = ounces;
        }
    }
}
