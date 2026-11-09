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
            if (IsValidData())
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
                    Account account = new()
                    {
                        UserName = txtUsername.Text,
                        Password = txtPassword.Text,
                        Email = $"{txtEmail.Text}@{cmbbEmail.Text}",
                        Firstname = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        AccountType = "Customer",
                        DateJoined = DateTime.Today
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

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += Validator.IsPresent(txtUsername.Text, "Username");
            errorMessage += Validator.IsPresent(txtPassword.Text, "Password");
            errorMessage += Validator.IsPresent(txtFirstName.Text, "First Name");
            errorMessage += Validator.IsPresent(txtLastName.Text, "Last Name");
            errorMessage += Validator.IsPresent(txtEmail.Text, "Email Username");
            errorMessage += Validator.IsPresent(cmbbEmail.Text, "Email Domain");

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }
    }
}
