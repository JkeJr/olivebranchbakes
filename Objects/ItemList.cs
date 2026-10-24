using System;
using System.Collections.Generic;
using System.Text;

namespace OliveBranchBakes.Objects
{
    internal class ItemList
    {
        private List<OrderItem> items;

        // Event handler
        public delegate void ChangeHandler(ItemList invItems);
        public event ChangeHandler Changed = null!;

        public ItemList() => items = new();

        // Methods for Removing
        public void Remove(OrderItem item)
        {
            items.Remove(item);
            if (Changed != null)
                Changed(this);
        }
        public static ItemList operator - (ItemList list, OrderItem item)
        {
            list.Remove(item);
            return list;
        }

        public int Count => items.Count();
        public OrderItem this[int i]
        {
            get { return items[i]; }
        }
        
        public void Fill() => items = DataManagement.GetItems();
        public void Save() => DataManagement.SaveItems(items);
    }
}
