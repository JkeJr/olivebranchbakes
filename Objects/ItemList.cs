using System;
using System.Collections.Generic;
using System.Text;

namespace OliveBranchBakes.Objects
{
    internal class ItemList
    {
        private List<OrderItem> items;

        public ItemList() => items = new();

        public int Count => items.Count();
        public OrderItem this[int i]
        {
            get { return items[i]; }
        }
        
        public void Fill() => items = DataManagement.GetItems();
    }
}
