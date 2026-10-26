using OliveBranchBakes.Objects;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;

namespace OliveBranchBakes
{
    public static class DataManagement
    {
        private const string Path = @"..\..\..\Documents\ItemStorage.txt";
        private const string Delimiter = "|";

        // Heavily borrowed from ExtraStarts ch14
        //
        // Accesses ItemStorage.txt 
        public static List<OrderItem> GetItems()
        {
            // create the object for the input stream for a text file
            using StreamReader textIn =
                new StreamReader(
                new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read));

            // create the list
            List<OrderItem> items = new();

            // read the data from the file and store it in the list
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine() ?? "";
                string[] columns = row.Split(Delimiter); //split the row into an array using Delimiter

                // Check if each row has been split correctly. Update whenever I add new pieces of info
                // Name|Price|Allergens|Seasonal?|Start|End
                if (columns.Length == 6)
                {
                    OrderItem item = null!;
                    /*      TODO: Add type specific checks in the first column of each row
                    if (columns[0] == nameof(Donut))
                    if (columns[0] == nameof(Cake))
                    */

                    string[] allergens = columns[2].Split(",");
                    // if the item is seasonal
                    if (columns[3] == "s")
                    {
                        item = new OrderItem(
                                    columns[0],
                                    Convert.ToDecimal(columns[1]),
                                    allergens,
                                    columns[4],
                                    columns[5]);
                    }
                    else
                    {
                        item = new OrderItem(
                                    columns[0],
                                    Convert.ToDecimal(columns[1]),
                                    allergens);
                    }

                    // add item to items list
                    if (item != null!)
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
                new FileStream(Path, FileMode.Create, FileAccess.Write));

            // loop through each OrderItem in List<OrderItem>
            foreach (OrderItem item in items)
            {
                // This will be needed when multiple child instances of OrderItem exists
                // textOut.Write(item.GetType().Name + Delimiter);
                WriteBase(item, textOut);
            }
        }

        // Write main chunk of the item data
        private static void WriteBase(OrderItem item, StreamWriter textOut)
        {
            textOut.Write(item.Name + Delimiter);
            textOut.Write(item.Price.ToString() + Delimiter);
            textOut.Write(item.AllergenList.GetDisplayText(",") + Delimiter);
            textOut.WriteLine(item.SeasonalInfo());
        }
    }
}
