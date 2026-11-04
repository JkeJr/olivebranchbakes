using System;
using System.Collections.Generic;
using System.Text;

namespace OliveBranchBakes.Objects.Order_Assets
{
    public class OrderItemGroup
    {
        public required OrderItem ItemType;
        public required Allergen Allergy { get; init; }

        public required int Count { get; set; }

        public decimal Price => ItemType.Price * Count;
    }
}
