using OliveBranchBakes.Objects;
using OliveBranchBakes.Objects.Order_Assets;
using OliveBranchBakes.Objects.OrderItem_Types;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;

namespace OliveBranchBakes
{
    public static class DataManagement
    {
        private const string PathItems = @"..\..\..\Documents\ItemStorage.txt";
        private const string PathOrders = @"..\..\..\Documents\OrderListStorage.txt";
        private const string Delimiter = "|";

        // Heavily borrowed from ExtraStarts ch14
        //
        // Accesses ItemStorage.txt 
        public static List<OrderItem> GetItems()
        {
            // create the object for the input stream for a text file
            using StreamReader textIn =
                new StreamReader(
                new FileStream(PathItems, FileMode.OpenOrCreate, FileAccess.Read));

            // create the list
            List<OrderItem> items = new();

            // read the data from the file and store it in the list
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine() ?? "";
                string[] columns = row.Split(Delimiter); //split the row into an array using Delimiter

                // Check if each row has been split correctly. Update whenever I add new pieces of info
                // Type|measurement|categories|Name|Price|Allergens|Seasonal?|Start|End
                if (columns.Length == 9)
                {
                    OrderItem item = null!;
                    /*      TODO: Add type specific checks in the first column of each row
                    if (columns[0] == nameof(Donut))
                    if (columns[0] == nameof(Cake))
                    */

                    string[] categories = columns[2].Split(",");
                    string[] allergens = columns[5].Split(",");

                    // if the item is seasonal
                    if (columns[6] == "s")
                    {
                        // if item is DrinkItem
                        if (columns[0] == nameof(DrinkItem))
                            item = new DrinkItem(
                                        Convert.ToInt16(columns[1]),
                                        new ItemCategories(categories),
                                        columns[3],
                                        Convert.ToDecimal(columns[4]),
                                        new AllergenList(allergens),
                                        columns[7],
                                        columns[8]);
                        // if item is FoodItem
                        else if (columns[0] == nameof(FoodItem))
                            item = new FoodItem(
                                        Convert.ToInt16(columns[1]),
                                        new ItemCategories(categories),
                                        columns[3],
                                        Convert.ToDecimal(columns[4]),
                                        new AllergenList(allergens),
                                        columns[7],
                                        columns[8]);
                    }
                    else
                    {
                        // if item is DrinkItem
                        if (columns[0] == nameof(DrinkItem))
                            item = new DrinkItem(
                                    Convert.ToInt16(columns[1]),
                                    new ItemCategories(categories),
                                    columns[3],
                                    Convert.ToDecimal(columns[4]),
                                    new AllergenList(allergens));
                        // if item is FoodItem
                        else if (columns[0] == nameof(FoodItem))
                            item = new FoodItem(
                                    Convert.ToInt16(columns[1]),
                                    new ItemCategories(categories),
                                    columns[3],
                                    Convert.ToDecimal(columns[4]),
                                    new AllergenList(allergens));
                    }

                    // add item to items list
                    if (item != null)
                        items.Add(item);
                }
            }

            // return the items list
            return items;
        }

        // Saves the list of available OrderItems and writes to a file
        public static void SaveItems(List<OrderItem> items)
        {
            // create the output stream for a text file that exists
            using StreamWriter textOut =
                new StreamWriter(
                new FileStream(PathItems, FileMode.Create, FileAccess.Write));

            // loop through each OrderItem in List<OrderItem>
            foreach (OrderItem item in items)
            {
                // Type|Amount|
                textOut.Write(item.GetType().Name + Delimiter);
                if (item is DrinkItem drinkItem)
                    textOut.Write(drinkItem.Ounces + Delimiter);
                else if (item is FoodItem foodItem)
                    textOut.Write(foodItem.Calories + Delimiter);

                WriteBase(item, textOut);
            }
        }

        public static List<Order> GetOrders()
        {
            // create the object for the input stream for a text file
            using StreamReader textIn =
                new StreamReader(
                new FileStream(PathOrders, FileMode.OpenOrCreate, FileAccess.Read));

            // create the list
            List<Order> orders = new();

            // read the data from the file and store it in the list
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine() ?? "";
                string[] columns = row.Split(Delimiter); //split the row into an array using Delimiter

                // number|name|status
                if (columns.Length == 3)
                {
                    Order order = Order.Load(Convert.ToInt32(columns[0]));
                    orders.Add(order);
                }
            }

            return orders;
        }
        public static void SaveOrders(List<Order> orders)
        {
            // create the output stream for a text file that exists
            using StreamWriter textOut =
                new StreamWriter(
                new FileStream(PathOrders, FileMode.Create, FileAccess.Write));

            // loop through each Order in List<Order>
            foreach (Order order in orders)
            {
                textOut.Write(order.Number.ToString("D8") + Delimiter);

                if (order.CustomerAccount == null)
                    textOut.Write(order.GuestName + Delimiter);
                else 
                    textOut.Write(order.CustomerAccount.GetName() + Delimiter);
                textOut.WriteLine(order.Status.ToString());
            }
        }

        // Write main chunk of the item data
        private static void WriteBase(OrderItem item, StreamWriter textOut)
        {
            textOut.Write(item.Categories.ToString(",") + Delimiter);
            textOut.Write(item.Name + Delimiter);
            textOut.Write(item.Price.ToString() + Delimiter);
            textOut.Write(item.AllergenList.ToString(",") + Delimiter);
            textOut.WriteLine(item.SeasonalInfo());
        }

        public static string DisplayListText(string[] List, string separator)
        {
            string result = "";
            foreach (Object o in List)
            {
                result += o.ToString();
                if (List.IndexOf(o) < List.Length - 1)
                    result += separator;
            }
            return result;
        }
    }
}
