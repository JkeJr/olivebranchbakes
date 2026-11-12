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

namespace OliveBranchBakes.Forms.Login
{
    public partial class CustomerHomeForm : Form
    {
        private readonly Account User;
        private Order? ActiveOrder;

        public CustomerHomeForm(Account user)
        {
            User = user;
            ActiveOrder = user.GetActiveOrder();
            InitializeComponent();
        }

        private void CustomerHomeForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {User.UserName}";
            lblName.Text = $"Name: {User.GetName()}";
            lblEmail.Text = $"E-Mail: {User.Email}";
            lblCreationDate.Text = $"Customer Since: {User.DateJoined.ToShortDateString()}";

            FillOrderListBox();
            FillCurOrderBox();
        }

        private void FillOrderListBox()
        {
            List<Order> orders = User.GetOwnedOrders();

            lstviewPrevOrders.Items.Clear();
            foreach (Order o in orders)
            {
                // Only completed orders will be listed in PrevOrders listview
                if (o.Status == StatusEnum.Completed)
                {
                    ListViewItem viewItem = new(o.Number.ToString("D8"));
                    viewItem.SubItems.Add(o.DateOrdered.ToShortDateString());
                    viewItem.SubItems.Add(o.DateScheduled.ToShortDateString());
                    viewItem.SubItems.Add(o.ItemCount.ToString());
                    viewItem.SubItems.Add(o.Total.ToString("C"));

                    lstviewPrevOrders.Items.Add(viewItem);
                }
            }
        }
        private void FillCurOrderBox()
        {
            if (ActiveOrder == null)
            {
                lstviewCurOrder.Items.Clear();
                lblOrderStatus.Text = "None";
                txtTotal.Clear();
            }
            else
            {
                OrderItemGroup group;

                lstviewCurOrder.Items.Clear();
                for (int i = 0; i < ActiveOrder!.Count; i++)
                {
                    group = ActiveOrder[i];
                    ListViewItem viewItem = new(group.Count.ToString());
                    viewItem.SubItems.Add(group.ItemType.Name);
                    viewItem.SubItems.Add(group.Allergy.type.ToString());
                    viewItem.SubItems.Add(group.Price.ToString("C"));

                    lstviewCurOrder.Items.Add(viewItem);
                }
                lblOrderStatus.Text = ActiveOrder.Status.ToString();
                txtTotal.Text = ActiveOrder.Total.ToString("C");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            WelcomeForm.Current!.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (ActiveOrder == null)
            {
                this.Close();
                new OrderForm(User).Show();
            }
            else
                MessageBox.Show("Users with a currently active order cannot make a new order.\n\n" +
                    $"Either cancel current order or allow active order ({ActiveOrder.Number.ToString("D8")}) to be completed.",
                    "Cannot Make Order");
        }

        // Mark the ActiveOrder with a status "cancelled", not deleting it, but
        // leaving it viewable to admins to delete themselves.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (ActiveOrder != null)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel this order?", "Confirm Cancelation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ActiveOrder.Status = StatusEnum.Cancelled;

                    // Replace order in globalOrder list
                    List<Order> globalOrders = DataManagement.GetOrders();
                    for (int i = 0; i < globalOrders.Count; i++)
                        if (ActiveOrder.Number == globalOrders[i].Number)
                            globalOrders[i] = ActiveOrder;

                    ActiveOrder.Save();
                    DataManagement.SaveOrders(globalOrders);

                    ActiveOrder = null;
                    FillOrderListBox();
                    FillCurOrderBox();
                }
            }
            else
            {
                MessageBox.Show("There is no active order to cancel.", "No Active Order");
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (lstviewPrevOrders.Items.Count == 0)
                MessageBox.Show("Order list is empty.", "No Orders");
            else if (lstviewPrevOrders.SelectedItems.Count == 0)
                MessageBox.Show("Please select an order to view.", "No order selected");
            else
            {
                List<Order> orders = DataManagement.GetOrders();
                int orderID = Convert.ToInt32(lstviewPrevOrders.SelectedItems[0].SubItems[0].Text);

                foreach (Order o in orders)
                    if (o.Number == orderID)
                        MessageBox.Show(o.GetDisplayText(), "Order Summary");
            }
        }

        private void btnReorder_Click(object sender, EventArgs e)
        {
            if (ActiveOrder == null)
            {
                if (lstviewPrevOrders.Items.Count == 0)
                    MessageBox.Show("Order list is empty.", "No Orders");
                else if (lstviewPrevOrders.SelectedItems.Count == 0)
                    MessageBox.Show("Please select an order.", "No order selected");
                else
                {
                    List<Order> orders = DataManagement.GetOrders();
                    int orderID = Convert.ToInt32(lstviewPrevOrders.SelectedItems[0].SubItems[0].Text);

                    foreach (Order o in orders)
                        if (o.Number == orderID)
                        {
                            this.Close();
                            new OrderForm(User, o).Show();
                        }
                }
            }
            else
                MessageBox.Show("Users with a currently active order cannot make a new order.\n\n" +
                    $"Either cancel current order or allow active order ({ActiveOrder.Number.ToString("D8")}) to be completed.",
                    "Cannot Make Order");
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete your account, {User.Firstname}?",
                                                    "Confirm Deletion",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                User.Delete();
                AccountManagement.SaveAccounts(AccountManagement.GetAccounts());

                this.Close();
                WelcomeForm.Current!.Show();
            }
        }
    }
}
