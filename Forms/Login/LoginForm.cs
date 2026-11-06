using OliveBranchBakes.Forms.Login;
using OliveBranchBakes.Objects.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OliveBranchBakes.Forms
{
    public partial class LoginForm : Form
    {
        private string? AccountType { get; set; }
        private int AccountID { get; set; }

        private Account account;

        public LoginForm()
        {
            InitializeComponent();
        }

        public Account Login()
        {
            this.ShowDialog();

            return account;
        }

        // Login
        private void btnEnter_Click(object sender, EventArgs e)
        {
            List<Account> accounts = AccountManagement.GetAccounts();

            bool found = false;
            foreach (Account account in accounts)
                if (txtUsername.Text == account.UserName && txtPassword.Text == account.Password)
                {
                    account.Load();
                    this.account = account;
                    found = true;
                }

            if (found)
                this.Close();
            else
                MessageBox.Show("Incorrect Username or Password","Login Error");
        }
        // Sign Up
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccountForm createAccountForm = new();
            createAccountForm.CreateAccount();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
