using OliveBranchBakes.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OliveBranchBakes.Forms.Payment
{
    public partial class PaymentEntryForm : Form
    {
        public Order order;
        
        private void PaymentEntryForm_Load(object sender, EventArgs e)
        {
            FillOrderBox();
        }

        public PaymentEntryForm()
        {
            InitializeComponent();
        }

        public bool ConfirmOrder(Order order)
        {
            this.order = order;
            this.ShowDialog();
            return false;
        }

        private void FillOrderBox()
        {
            OrderItem item;
            listviewOrder.Items.Clear();
            for (int i = 0; i < order.Count; i++)
            {
                item = order[i];

                listviewOrder.Items.Add(item.Name);
            }
        }
    }
}
