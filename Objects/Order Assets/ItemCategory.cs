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

        public int Count => categoryList.Count;

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

        // Add to list
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

        // Remove 
        public void Remove(CategoryEnums category)
        {
            categoryList.Remove(category);
        }
        public void RemoveAt(int index)
        {
            categoryList.RemoveAt(index);
        }
        public void Clear()
        {
            categoryList.Clear();
        }

        // Indexing
        public CategoryEnums this[int i] => categoryList[i];
        public int IndexOf(CategoryEnums category)
        {
            for (int i = 0; i < Count; i++)
                if (categoryList[i] == category)
                    return i;

            return -1;
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
