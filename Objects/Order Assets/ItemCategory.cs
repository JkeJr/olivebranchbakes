using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace OliveBranchBakes.Objects.Order_Assets
{
    public enum Categories
    {
        Cookie,
        Pie,
        Cake,
        Bread,
        Pastry,
        Misc,
    }

    public class ItemCategories
    {
        private List<Categories> categoryList;

        public ItemCategories()
        {
            categoryList = new();
            categoryList.Add(Categories.Misc);
        }
        public ItemCategories(string[] values)
        {
            this.categoryList = new();
            foreach (string category in values)
            {
                this.Add(category);
            }
        }

        private void Add(string category)
        {
            categoryList.Add((Categories)Enum.Parse(typeof(Categories), category));
        }
    }
}
