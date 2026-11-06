using OliveBranchBakes.Objects;
using OliveBranchBakes.Objects.Customers;
using System;
using System.Collections.Generic;
using System.Text;

namespace OliveBranchBakes
{
    public static class AccountManagement
    {
        private const string PathAccounts = @"..\..\..\Documents\AccountStorage.txt";
        private const string Delimiter = "|";

        public static List<Account> GetAccounts()
        {
            // create the object for the input stream for a text file
            using StreamReader textIn =
                new StreamReader(
                new FileStream(PathAccounts, FileMode.OpenOrCreate, FileAccess.Read));

            // create the list
            List<Account> accounts = new();

            // read the data from the file and store it in the list
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine() ?? "";
                string[] columns = row.Split(Delimiter); //split the row into an array using Delimiter

                // number|customer/admin|username|password
                if (columns.Length == 3)
                {
                    Account a = new()
                    {
                        AccountID = Convert.ToInt32(columns[0]),
                        UserName = columns[1],
                        Password = columns[2],
                    };
                    a.Load();
                    accounts.Add(a);
                }
            }

            return accounts;
        }
        public static void SaveAccounts(List<Account> accounts)
        {
            // create the output stream for a text file that exists
            using StreamWriter textOut =
                new StreamWriter(
                new FileStream(PathAccounts, FileMode.Create, FileAccess.Write));

            // loop through each Order in List<Order>
            // accountID|customer/admin|username|email|password
            foreach (Account account in accounts)
            {
                textOut.Write(account.AccountID + Delimiter);
                textOut.Write(account.UserName + Delimiter);
                textOut.WriteLine(account.Password);
            }
        }
    }
}
