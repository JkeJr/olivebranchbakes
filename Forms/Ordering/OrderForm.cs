using OliveBranchBakes.Forms.Payment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OliveBranchBakes.Forms
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }



        // Closes the application if the form is closed.

        // Source - https://stackoverflow.com/a/8750673
        // Posted by competent_tech
        // Retrieved 2026-10-22, License - CC BY-SA 3.0
        private void OrderForm_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // something
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            new PaymentEntryForm().Show();
            this.Close();
        }
    }
}
