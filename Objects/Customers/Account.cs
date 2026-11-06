using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace OliveBranchBakes.Objects.Customers
{
    public class Account
    {
        private string Path => $@"..\..\..\Documents\Accounts\{AccountID}.txt";

        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int AccountID { get; init; }
        public string AccountType { get; set; }

        public void Save()
        {
            using StreamWriter textOut =
                new StreamWriter(
                new FileStream(Path, FileMode.Create, FileAccess.Write));

            textOut.WriteLine(Firstname);
            textOut.WriteLine(LastName);
            textOut.WriteLine(AccountType);
            textOut.WriteLine(Email);
            textOut.WriteLine(UserName);
            textOut.WriteLine(Password);
        }

        public void Load()
        {
            using StreamReader textIn =
                new StreamReader(
                new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read));

            List<string> lines = new();
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine() ?? "";

                lines.Add(row);
            }

            //string[] lines = textIn.ReadToEnd().Split('\n');
            Firstname = lines[0];
            LastName = lines[1];
            AccountType = lines[2];
            Email = lines[3];
            UserName = lines[4];
            Password = lines[5];
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
