using OliveBranchBakes.Objects.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace OliveBranchBakes.Forms.Login
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        public void CreateAccount()
        {
            this.ShowDialog();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool exists = false;
            foreach (Account a in AccountManagement.GetAccounts())
                if (txtUsername.Text == a.UserName)
                    exists = true;

            if (exists)
            {
                MessageBox.Show($"Account, {txtUsername.Text}, already exists.", "Creation Error");
            }
            else
            {
                Account account;
                if (cmbbEmail.Text == "" || cmbbEmail.Text.IsWhiteSpace() || cmbbEmail.Text == null)
                {
                    MessageBox.Show("Please select a valid domain", "Invalid Email");
                }
                else
                {
                    account = new()
                    {
                        UserName = txtUsername.Text,
                        Password = txtPassword.Text,
                        Email = $"{txtEmail.Text}@{cmbbEmail.Text}",
                        Firstname = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        AccountID = new Random().Next(99999999),
                        AccountType = "Customer"
                    };
                    account.Save();

                    List<Account> accounts = AccountManagement.GetAccounts();
                    accounts.Add(account);
                    AccountManagement.SaveAccounts(accounts);

                    MessageBox.Show($"Your account has been created, {account.Firstname}.\n" +
                        "Please login with your new credentials.", "Account Created");
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
