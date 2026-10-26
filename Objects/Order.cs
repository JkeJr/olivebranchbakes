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

        //public OrderItem this[int i] => items[i];
        
        // Adding to the list
        public void Add(OrderItem item)
        {
            items.Add(item);
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
