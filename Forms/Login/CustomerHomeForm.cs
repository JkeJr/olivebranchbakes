using OliveBranchBakes.Objects.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OliveBranchBakes.Forms.Login
{
    public partial class CustomerHomeForm : Form
    {
        Account User;

        public CustomerHomeForm(Account user)
        {
            User = user;
            InitializeComponent();
        }

        private void CustomerHomeForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {User.UserName}";
        }
    }
}
