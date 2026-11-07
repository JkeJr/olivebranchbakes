using OliveBranchBakes.Objects.Order_Assets;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading.Channels;

namespace OliveBranchBakes.Objects
{
    public class Order
    {
        private List<OrderItemGroup> itemGroups;
        public int Count => itemGroups.Count;
        public int Number { get; init; }
        public string Name { get; set; } = "";
        public string Comments { get; set; } = "";

        public decimal Subtotal
        {
            get
            {
                decimal subtotal = 0.00m;
                foreach (OrderItemGroup itemGroup in itemGroups)
                    subtotal += itemGroup.Price;

                return subtotal;
            }
        }
        public decimal Discounted => Subtotal - (RuleManagement.GetDiscount(Subtotal));
        public decimal Total => Discounted + (RuleManagement.GetTax(Discounted));

        // Change Event
        public delegate void ChangeHandler(Order order);
        public event ChangeHandler OrderChanged = null!;

        public Order()
        {
            itemGroups = new();

            // Set Number to a random integer, check every order on file to check for duplicate order numbers.
            // If there's a matching number, repeat the process. Otherwise, end the loop.
            bool unique = true;
            do
            {
                Number = new Random().Next(99999999);

                List<Order> orders = DataManagement.GetOrders();
                foreach (Order order in orders)
                    unique = !(order.Number == this.Number);
            } while (!unique);
        }
        public Order(int num, string name)
        {
            itemGroups = new();
            Number = num;
            Name = name;
        }
        public Order(List<OrderItemGroup> items, string comments)
        {
            this.itemGroups = items;
            this.Comments = comments;
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

        public int CategoryCount(CategoryEnums category)
        {
            int amount = 0;
            for (int i = 0; i < this.Count; i++)
            {
                if (this[i].ItemType.Categories.IndexOf(category) != -1)
                {
                    amount += this[i].Count;
                }
            }

            return amount;
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
        public void RemoveAt(int index)
        {
            this.Remove(itemGroups[index]);
        }
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
        public void Clear()
        {
            itemGroups.Clear();
            if (OrderChanged != null)
                OrderChanged(this);
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
