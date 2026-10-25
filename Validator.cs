using System;
using System.Collections.Generic;
using System.Text;

namespace OliveBranchBakes
{
    // Many methods from here are borrowed from ExtraStarts ch14 Inventory Maintenance
    internal static class Validator
    {
        public static string LineEnd { get; set; } = "\n";

        public static string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
                msg = $"{name} is a required field.{LineEnd}";
            return msg;
        }

        public static string IsDecimal(string value, string name)
        {
            string msg = "";
            if (!Decimal.TryParse(value, out _))
                msg = $"{name} must be a valid decimal value.{LineEnd}";
            return msg;
        }
    }
}
