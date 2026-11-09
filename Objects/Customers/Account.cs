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

        public string GetName() => Firstname + " " + LastName;
        private static string GetPath(int accountID) => $@"{pathStart}{accountID}.txt";
        public void Save()
        {
            using StreamWriter textOut =
                new StreamWriter(
                new FileStream(GetPath(AccountID), FileMode.Create, FileAccess.Write));

            textOut.WriteLine(Firstname);
            textOut.WriteLine(LastName);
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

            Account account = new(accountID)
            {
                Firstname = lines[0],
                LastName = lines[1],
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
