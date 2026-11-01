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
        public DrinkItem(int ounces, ItemCategories categories, string name, decimal price, AllergenList allergens, string start, string end) : base(categories, name, price, allergens, start, end)
        {
            Ounces = ounces;
        }
        public DrinkItem(int ounces, ItemCategories categories, string name, decimal price, AllergenList allergens) : base(categories, name, price, allergens)
        {
            Ounces = ounces;
        }

        // Used in ItemCreateForm
        public DrinkItem(int ounces, ItemCategories categories, string name, decimal price, AllergenList allergens, DateRange dateRange) : base(categories, name, price, allergens, dateRange)
        {
            Ounces = ounces;
        }
    }
}
