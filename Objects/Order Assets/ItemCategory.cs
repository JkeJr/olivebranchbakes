using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace OliveBranchBakes.Objects.Order_Assets
{
    public enum CategoryEnums
    {
        Cookie,
        Pie,
        Cake,
        Bread,
        Pastry,
        Muffin,
        Misc,
    }

    public class ItemCategories
    {
        private List<CategoryEnums> categoryList;

        public ItemCategories()
        {
            categoryList = new();
            categoryList.Add(CategoryEnums.Misc);
        }
        public ItemCategories(string[] values)
        {
            this.categoryList = new();
            foreach (string category in values)
            {
                this.Add(category);
            }
        }

        public void Add(string category)
        {
            if (category.IsWhiteSpace() || category == "")
                categoryList.Add(CategoryEnums.Misc);
            else
                categoryList.Add((CategoryEnums)Enum.Parse(typeof(CategoryEnums), category));
        }

        public void Add(CategoryEnums category)
        {
            categoryList.Add(category);
        }

        public string ToString(string separator)
        {
            string[] items = new string[categoryList.Count];
            for (int i = 0; i < categoryList.Count; i++)
                items[i] = categoryList[i].ToString();
            return DataManagement.DisplayListText(items, separator);
        }
    }
}
