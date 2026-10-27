using System;
using System.Collections.Generic;
using System.Text;

namespace OliveBranchBakes.Objects.Order_Assets
{
    public class OrderItemGroup
    {
        public required OrderItem ItemType;
        public required Allergen Allergy { get; init; }

        private int count;
        public required int Count
        {
            get { return count; }
            set
            {
                count = value;
            }
        }
        public decimal Price => ItemType.Price * Count;
    }
}
