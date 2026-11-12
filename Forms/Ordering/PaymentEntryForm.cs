using OliveBranchBakes.Objects;
using OliveBranchBakes.Objects.Customers;
using OliveBranchBakes.Objects.Order_Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OliveBranchBakes.Forms.Payment
{
    public partial class PaymentEntryForm : Form
    {
        public Order order;
        private bool confirmed = false;

        private void PaymentEntryForm_Load(object sender, EventArgs e)
        {
            dtpPickup.MinDate = DateTime.Today.AddDays(1);
            dtpPickup.MaxDate = DateTime.Today.AddMonths(3);

            rtbComments.Text = order.Comments;

            FillOrderBox();
            FillTotalBox();
        }

        public PaymentEntryForm()
        {
            InitializeComponent();
        }

        public bool ConfirmOrder(Order order)
        {
            this.order = order;
            this.ShowDialog();
            return confirmed;
        }

        private void FillOrderBox()
        {
            OrderItemGroup itemGroup;
            listviewOrder.Items.Clear();
            for (int i = 0; i < order.Count; i++)
            {
                // Gets itemGroup at i index of order.itemGroups
                itemGroup = order[i];
                ListViewItem viewItem = new(itemGroup.ItemType.Name);
                viewItem.SubItems.Add(itemGroup.Count.ToString());
                viewItem.SubItems.Add(itemGroup.Allergy.ToString());
                viewItem.SubItems.Add(itemGroup.Price.ToString());

                listviewOrder.Items.Add(viewItem);
            }

            //txtSubtotal.Text = $"${order.Subtotal}";
        }
        private void FillTotalBox()
        {
            listviewPricing.Items.Clear();

            ListViewItem viewItem;
            // subtotal
            viewItem = new("");
            viewItem.SubItems.Add("Subtotal:");
            viewItem.SubItems.Add($"{order.Subtotal.ToString("C")}");
            listviewPricing.Items.Add(viewItem);

            // discount
            viewItem = new("");
            viewItem.SubItems.Add("Discount:");
            viewItem.SubItems.Add($"- {RuleManagement.GetDiscount(order.Subtotal).ToString("C")}");
            listviewPricing.Items.Add(viewItem);

            // tax
            viewItem = new("");
            viewItem.SubItems.Add("Tax:");
            viewItem.SubItems.Add($"+ {RuleManagement.GetTax(order.Discounted).ToString("C")}");
            listviewPricing.Items.Add(viewItem);

            txtPriceTotal.Text = $"{order.Total.ToString("C")}";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                order.Status = StatusEnum.Recieved;
                if (order.CustomerAccount == null)
                    order.GuestName = txtNameFirst.Text.Trim() + " " + txtNameLast.Text.Trim();
                order.DateOrdered = DateTime.Today;
                order.DateScheduled = dtpPickup.Value;

                order.Save();
                List<Order> orders = DataManagement.GetOrders();
                orders.Add(order);

                DataManagement.SaveOrders(orders);

                confirmed = true;
                MessageBox.Show("Order has been made and received successfully.\n\n" +
                    order.GetDisplayText(), "Order Received");
                this.Close();
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += Validator.IsPresent(txtNameFirst.Text, "First Name");
            errorMessage += Validator.IsPresent(txtNameLast.Text, "Last Name");
            errorMessage += Validator.IsPresent(txtEmail.Text, "Email Username");
            errorMessage += Validator.IsPresent(cmmbEmail.Text, "Email Domain");

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        private void dtpPickup_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
