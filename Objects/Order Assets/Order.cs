using OliveBranchBakes.Objects.Order_Assets;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace OliveBranchBakes.Objects
{
    public class Order
    {
        private List<OrderItemGroup> itemGroups;
        public int Count => itemGroups.Count;
        public decimal Subtotal
        {
            get
            {
                decimal subtotal = Convert.ToDecimal("0.00");
                foreach (OrderItemGroup itemGroup in itemGroups)
                    subtotal += itemGroup.Price;

                return subtotal;
            }
        }

        // Change Event
        public delegate void ChangeHandler(Order order);
        public event ChangeHandler OrderChanged = null!;

        public string comments;

        public Order() => itemGroups = new();
        public Order(List<OrderItemGroup> items, string comments)
        {
            this.itemGroups = items;
            this.comments = comments;
        }

        // Finds the index of an OrderItem in items that matches the name and allergy
        // Returns -1 if not found
        public int IndexOf(OrderItem item, Allergen allergen)
        {
            // loop through each itemGroup
            foreach (OrderItemGroup itemGroup in itemGroups)
            {
                if (item.Name == itemGroup.ItemType.Name && allergen == itemGroup.Allergy)
                {
                    return itemGroups.IndexOf(itemGroup);
                }
            }

            return -1;
        }

        /*public void Group(OrderItem item, int amnt)
        {
            this[IndexOf(item)].Count += amnt;
            this[IndexOf(item)].Price += item.Price * amnt;
            if (OrderChanged != null)
                OrderChanged(this);
        }*/
        
        // Adding to the list
        public void Add(OrderItemGroup itemGroup)
        {
            /*int i = IndexOf(item);
            if (i == -1)
                items.Add(item);
            else
                this[i].Add(item);
            */
            itemGroups.Add(itemGroup);
            if (OrderChanged != null)
                OrderChanged(this);
        }
        // Adding count to itemGroups at index
        public void Add(int index, int count)
        {
            this[index].Count += count;
            if (OrderChanged != null)
                OrderChanged(this);
        }

        public static Order operator + (Order order, OrderItemGroup itemGroup)
        {
            order.Add(itemGroup);
            return order;
        }

        // Deleting from the list
        public void Remove(OrderItemGroup itemGroup)
        {
            itemGroups.Remove(itemGroup);
            if (OrderChanged != null)
                OrderChanged(this);
        }
        public static Order operator - (Order order, OrderItemGroup itemGroup)
        {
            order.Remove(itemGroup);
            return order;
        }

        // Method for indexer
        public OrderItemGroup this[int i]
        {
            get
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                else if (i > itemGroups.Count)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                else
                    return itemGroups[i];
            }
            set
            {
                itemGroups[i] = value;
                if (OrderChanged != null)
                    OrderChanged(this);
            }
        }
    }
}
