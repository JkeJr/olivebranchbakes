using System;
using System.Collections.Generic;
using System.Text;

namespace OliveBranchBakes.Objects
{
    internal class ItemList
    {
        private List<OrderItem> items;

        // Change Event
        public delegate void ChangeHandler(ItemList invItems);
        public event ChangeHandler ItemListChanged = null!;

        public ItemList() => items = new();

        // Methods for Adding
        public void Add(OrderItem item)
        {
            items.Add(item);
            if (ItemListChanged != null)
                ItemListChanged(this);
        }
        public static ItemList operator + (ItemList list, OrderItem item)
        {
            list.Add(item);
            return list;
        }

        // Methods for Removing
        public void Remove(OrderItem item)
        {
            items.Remove(item);
            if (ItemListChanged != null)
                ItemListChanged(this);
        }
        public static ItemList operator - (ItemList list, OrderItem item)
        {
            list.Remove(item);
            return list;
        }

        public int Count => items.Count();

        // Method for indexer
        public OrderItem this[int i]
        {
            get
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                else if (i > items.Count)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                else
                    return items[i];
            }
            set
            {
                items[i] = value;
                if (ItemListChanged != null)
                    ItemListChanged(this);
            }
        }
        public int IndexOf(string name)
        {
            for (int i = 0; i < Count; i++)
                if (items[i].Name == name)
                    return i;
            return -1;
        }
        
        public void Fill() => items = DataManagement.GetItems();
        public void Save() => DataManagement.SaveItems(items);
    }
}
