using System;
using System.Collections.Generic;
using System.Text;

namespace OliveBranchBakes.Objects
{
    public class OrderItem
    {
        public string Name = "";
        public decimal Price;
        public string Allergens = "";
        private bool seasonal { get; init; } = false;

        private string? seasonStart;    // mm/dd/yyyy
        private string? seasonEnd;      // mm/dd/yyyy

        public OrderItem()
        {
            Name = "unnamed";
            Price = 0;
            Allergens = "none";
        }

        public OrderItem(string name, decimal price, string allergens)
        {
            Name = name;
            Price = price;
            Allergens = allergens;
        }
        public OrderItem(string name, decimal price, string allergens, string start, string end)
        {
            Name = name;
            Price = price;
            Allergens = allergens;
            seasonal = true;

            seasonStart = $"{start}/{GetYear()}"; // mm/dd + yyyy

            // if end == mm/dd+, set the end DateTime to be set for the next year
            if (end[end.Length - 1] == '+')
                seasonEnd = $"{end.Substring(end.Length - 1)}/{GetYear() + 1}"; // mm/dd + (yyyy + 1)
            else
                seasonEnd = $"{end}/{GetYear()}"; // mm/dd + yyyy
        }

        public bool InSeason()
        {
            if (this.seasonal)
            {
                if (DateTime.Today < ConvertToDateTime(seasonStart))
                    return false;
                else if (DateTime.Today > ConvertToDateTime(seasonEnd))
                    return false;
                else 
                    return true;
            }
            return true;
        }

        private static DateTime ConvertToDateTime(string date)
        {
            int[] intValues = new int[3];
            string[] strValues = date.Split("/");
            foreach (string value in strValues)
            {
                intValues[strValues.IndexOf(value)] = Convert.ToInt16(value);
            }

            DateTime dateTime = new(intValues[0], intValues[1], intValues[2]);
            return dateTime;
        }
        private static int GetYear()
        {
            // mm/dd/yyyy
            string date = DateTime.Today.ToString();
            string year = date.Substring(date.Length - 4, 4); // yyyy

            return Convert.ToInt16(year);
        }

        public string GetDisplayText()
        {
            return $"{Name} | {Price} | {Allergens}";
        }
    }
}
