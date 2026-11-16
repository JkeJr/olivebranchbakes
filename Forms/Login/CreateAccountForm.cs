using OliveBranchBakes.Objects;
using OliveBranchBakes.Objects.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace OliveBranchBakes.Forms.Login
{
    public partial class CreateAccountForm : Form
    {
        Account User;

        public CreateAccountForm()
        {
            InitializeComponent();
        }

        public void CreateAccount()
        {
            this.ShowDialog();
        }

        public void EditAccount(Account userAccount)
        {
            this.Name = "Edit Account";

            User = userAccount;
            txtUsername.Text = User.UserName;
            txtPassword.Text = User.Password;
            txtPassword.ReadOnly = true;

            txtFirstName.Text = User.Firstname;
            txtLastName.Text = User.LastName;

            // email@domain.com
            string email = User.Email;
            string emailName = email.Substring(0, email.LastIndexOf('@'));
            string emailDomain = email.Substring(email.LastIndexOf('@') + 1);
            txtEmail.Text = emailName;
            cmbbEmail.Text = emailDomain;

            this.ShowDialog();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                // If creating account
                if (User == null)
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
                        User = new()
                        {
                            UserName = txtUsername.Text,
                            Password = txtPassword.Text,
                            Email = $"{txtEmail.Text}@{cmbbEmail.Text}",
                            Firstname = txtFirstName.Text,
                            LastName = txtLastName.Text,
                            Type = AccountType.Customer,
                            DateJoined = DateTime.Today
                        };

                        User.Save();
                        List<Account> accounts = AccountManagement.GetAccounts();
                        accounts.Add(User);
                        AccountManagement.SaveAccounts(accounts);

                        MessageBox.Show($"Your account has been created, {User.Firstname}.\n" +
                                        "Please login with your new credentials.", "Account Created");
                    }
                }
                // If editing account
                else
                {
                    User.UserName = txtUsername.Text;
                    User.Firstname = txtFirstName.Text;
                    User.LastName = txtLastName.Text;
                    User.Email = $"{txtEmail.Text}@{cmbbEmail.Text}";
                    User.Save();

                    AccountManagement.SaveAccounts(AccountManagement.GetAccounts());

                    MessageBox.Show($"Your new info has been saved, {User.Firstname}.", "Info Edited");
                }
                this.Close();
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

        private void btnEye_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }
    }
}
