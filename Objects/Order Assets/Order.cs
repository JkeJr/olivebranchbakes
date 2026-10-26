using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace OliveBranchBakes.Objects
{
    public class Order
    {
        private List<OrderItem> items;
        public int Count => items.Count;

        // Change Event
        public delegate void ChangeHandler(Order order);
        public event ChangeHandler OrderChanged = null!;

        public string comments;

        public Order() => items = new();
        public Order(List<OrderItem> items, string comments)
        {
            this.items = items;
            this.comments = comments;
        }

        // Finds the index of an OrderItem in items that matches the name and allergy
        // Returns -1 if not found
        public int IndexOf(OrderItem item)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this[i].Equals(item))
                    return items.IndexOf(item);
            }

            return -1;
        }
        
        // Adding to the list
        public void Add(OrderItem item)
        {
            int i = IndexOf(item);
            if (i == -1)
                items.Add(item);
            else
                this[i].Add(item);

            if (OrderChanged != null)
                OrderChanged(this);
        }
        public void Add(OrderItem item, int count)
        {
            item.Count = count;
            items.Add(item);
            if (OrderChanged != null)
                OrderChanged(this);
        }
        public static Order operator + (Order order, OrderItem item)
        {
            order.Add(item);
            return order;
        }

        // Deleting from the list
        public void Remove(OrderItem item)
        {
            items.Remove(item);
            if (OrderChanged != null)
                OrderChanged(this);
        }
        public static Order operator - (Order order, OrderItem item)
        {
            order.Remove(item);
            return order;
        }

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
                if (OrderChanged != null)
                    OrderChanged(this);
            }
        }
    }
}
