using OliveBranchBakes.Objects.Order_Assets;
using System;
using System.Collections.Generic;
using System.Text;

namespace OliveBranchBakes
{
    public static class RuleManagement
    {
        public static decimal GetDiscount(decimal subTotal)
        {
            decimal discount = 0;
            if (subTotal >= 100)
                discount = subTotal * 0.12m;
            else if (subTotal >= 50)
                discount = subTotal * 0.05m;

            return discount;
        }
        public static decimal GetTax(decimal subTotal) => subTotal * 0.085m;

        public static bool CanOperate(OrderItemGroup orderItemGroup) => true;
    }
}
