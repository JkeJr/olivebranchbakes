using OliveBranchBakes.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OliveBranchBakes
{
    public partial class WelcomeForm : Form
    {
        public static WelcomeForm Current;
        
        public WelcomeForm()
        {
            InitializeComponent();
            Current = this;
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            new OrderForm().Show();
            this.Hide();
        }

        private void btnLoginGo_Click(object sender, EventArgs e)
        {
            //LoginForm loginForm = new();
            //loginForm.ShowDialog();
            new AdminConsoleForm().Show();
            this.Hide();
        }
    }
}
