using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OliveBranchBakes.Objects.Customers
{
    public class Account
    {
        private static string pathStart => $@"..\..\..\Documents\Accounts\";

        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int AccountID { get; init; }
        public string AccountType { get; set; }
        public DateTime DateJoined { get; set; }

        public Account()
        {
            bool unique = true;
            do
            {
                AccountID = new Random().Next(99999999);

                List<Account> accounts = AccountManagement.GetAccounts();
                foreach (Account account in accounts)
                    unique = !(account.AccountID == this.AccountID);
            } while (!unique);
        }
        public Account(int accountID)
        {
            AccountID = accountID;
        }

        // Look through all orders and return a list of orders attatched to the user
        public List<Order> GetOwnedOrders()
        {
            List<Order> result = new();
            List<Order> ordersAll = DataManagement.GetOrders();
            foreach (Order o in ordersAll)
            {
                if (o.CustomerAccount != null && o.CustomerAccount.AccountID == this.AccountID)
                {
                    result.Add(o);
                }
            }

            return result;
        }
        public Order? GetActiveOrder()
        {
            foreach (Order o in GetOwnedOrders())
                if (o.Status != StatusEnum.Completed && o.Status != StatusEnum.Cancelled)
                    return o;

            return null;
        }

        public string GetName() => Firstname + " " + LastName;
        private static string GetPath(int accountID) => $@"{pathStart}{accountID.ToString("D8")}.txt";
        public void Save()
        {
            using StreamWriter textOut =
                new StreamWriter(
                new FileStream(GetPath(AccountID), FileMode.Create, FileAccess.Write));

            textOut.Write(Firstname + "|");
            textOut.WriteLine(LastName + "|");
            textOut.WriteLine(DateJoined.ToShortDateString());
            textOut.WriteLine(AccountType);
            textOut.WriteLine(Email);
            textOut.WriteLine(UserName);
            textOut.WriteLine(Password);
        }

        public static Account Load(int accountID)
        {
            using StreamReader textIn =
                new StreamReader(
                new FileStream(GetPath(accountID), FileMode.OpenOrCreate, FileAccess.Read));

            List<string> lines = new();
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine() ?? "";

                lines.Add(row);
            }

            string[] name = lines[0].Split("|");
            string[] dateJoined = lines[1].Split("/");
            Account account = new(accountID)
            {
                Firstname = name[0],
                LastName = name[1],
                DateJoined = new DateTime(Convert.ToInt16(dateJoined[2]), Convert.ToInt16(dateJoined[0]), Convert.ToInt16(dateJoined[1])),
                AccountType = lines[2],
                Email = lines[3],
                UserName = lines[4],
                Password = lines[5],
            };

            return account;
        }

        public bool Equals(Account account)
        {
            bool result = false;
            if (UserName == account.UserName && Password == account.Password)
                result = true;
            return result;
        }
    }
}
