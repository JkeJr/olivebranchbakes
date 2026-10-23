using OliveBranchBakes.Objects;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;

namespace OliveBranchBakes
{
    internal static class DataManagement
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
                if (columns.Length == 3)
                {
                    OrderItem item = null!;
                    /*      TODO: Add type specific checks in the first column of each row
                    if (columns[0] == nameof(Donut))
                    if (columns[0] == nameof(Cake))
                    */
                    item = new OrderItem(columns[0], 
                                            Convert.ToDecimal(columns[1]),
                                                columns[2]);

                    // add item to items list
                    if (item != null)
                        items.Add(item);
                }
            }

            // return the items list
            return items;
        }
    }
}
