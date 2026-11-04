using OliveBranchBakes.Objects;
using OliveBranchBakes.Objects.Order_Assets;
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
            OrderItemGroup itemGroup;

            listviewOrder.Items.Clear();
            for (int i = 0; i < order.Count; i++)
            {
                itemGroup = order[i];

                listviewOrder.Items.Add(itemGroup.ItemType.Name);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            order.Name = txtNameFirst.Text.Trim() + txtNameLast.Text.Trim();
            
            List<Order> orders = DataManagement.GetOrders();
            orders.Add(order);

            DataManagement.SaveOrders(orders);

            MessageBox.Show("Order has been made and received successfully.","Order Received");
            this.Close();
        }
    }
}
