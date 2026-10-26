using System;
using System.Collections.Generic;
using System.Text;

namespace OliveBranchBakes.Objects
{
    internal class Order
    {
        private List<OrderItem> items;
        public string comments;

        public Order(List<OrderItem> items, string comments)
        {
            this.items = items;
            this.comments = comments;
        }

        public OrderItem this[int i] => items[i];
    }
}
