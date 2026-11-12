using OliveBranchBakes.Forms.Admin;
using OliveBranchBakes.Objects;
using OliveBranchBakes.Objects.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OliveBranchBakes.Forms
{
    public partial class AdminConsoleForm : Form
    {
        private ItemList items = new();

        public AdminConsoleForm()
        {
            InitializeComponent();
        }
        private void AdminConsoleForm_Load(object sender, EventArgs e)
        {
            items.ItemListChanged += new ItemList.ChangeHandler(HandleChange);
            items.Fill();
            FillItemListBox();
            FillOrderListBox();
            FillAccountListBox();

            cmbbOrderStatus.Enabled = false;
            cmbbOrderStatus.Items.Add(StatusEnum.Recieved);
            cmbbOrderStatus.Items.Add(StatusEnum.InProgress);
            cmbbOrderStatus.Items.Add(StatusEnum.Ready);
            cmbbOrderStatus.Items.Add(StatusEnum.Completed);
            cmbbOrderStatus.Items.Add(StatusEnum.Cancelled);
            cmbbOrderStatus.ResetText();
            lblDate.Text = DateRange.FormatDate(DateTime.Today);
        }

        // Add an Item to the list of available OrderItems
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ItemCreateForm itemCreateFrm = new();
            OrderItem item = itemCreateFrm.GetNewItem();
            if (item != null)
            {
                items += item;

                // Will add more options for type of item. For now, generic message
                string message = "";
                //if (item is OrderItem o)
                message = $"{item.GetType().Name} type, {item.Name}, has been added.";

                MessageBox.Show(message, "Success!");
            }
        }

        // Select and edit an item
        private void btnEdit_Click(object sender, EventArgs e) => EditItem();
        //private void listviewItems_SelectedIndexChanged(object sender, EventArgs e) => EditItem();

        private void EditItem()
        {
            // checks if selected item exists and is valid
            if (listviewItems.Items.Count == 0)
                MessageBox.Show("Item list is empty.", "No Items");
            else if (listviewItems.SelectedItems.Count == 0)
                MessageBox.Show("Please select an item to edit.", "No item selected");
            else
            {
                // gets the index of the selected item
                int i = listviewItems.Items.IndexOf(listviewItems.SelectedItems[0]);

                ItemCreateForm itemCreateFrm = new();
                OrderItem item = itemCreateFrm.EditItem(items[i]);
                if (item != null)
                {
                    items[i] = item;

                    // Will add more options for type of item. For now, generic message
                    string message = "";

                    message = $"{item.GetType().Name} type, {item.Name}, has been edited.";

                    MessageBox.Show(message, "Success!");
                }
            }
        }

        // Delete an Item from the list of available OrderItems
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listviewItems.Items.Count == 0)
                MessageBox.Show("Item list is already empty.", "No Items");
            else if (listviewItems.SelectedItems.Count == 0)
                MessageBox.Show("Please select an item to delete.", "No item selected");
            else
            {
                // gets the index of the selected item
                int i = listviewItems.Items.IndexOf(listviewItems.SelectedItems[0]);

                OrderItem item = items[i];

                string message = $"Are you sure you want to delete {item.Name}?";
                DialogResult result =
                    MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    items -= item;
                }
            }
        }

        // Fills listviewItems with values from items
        private void FillItemListBox()
        {
            OrderItem item;
            listviewItems.Items.Clear();
            for (int i = 0; i < items.Count; i++)
            {
                item = items[i];
                ListViewItem viewItem = new(item.Categories.ToString(", "));
                viewItem.SubItems.Add(item.Name);
                viewItem.SubItems.Add(item.Price.ToString());
                viewItem.SubItems.Add(item.AllergenList.ToString(", "));

                // Shows which items are in season; Green if true, OrangeRed if false
                if (item.Seasonal)
                    viewItem.BackColor = (item.InSeason()) ? Color.Green : Color.OrangeRed;

                listviewItems.Items.Add(viewItem);
            }
        }
        private void FillOrderListBox()
        {
            cmbbOrderStatus.Enabled = false;

            List<Order> orders = DataManagement.GetOrders();
            listviewOrders.Items.Clear();
            foreach (Order order in orders)
            {
                ListViewItem viewItem = new(order.Number.ToString("D8"));
                if (order.CustomerAccount == null)
                    viewItem.SubItems.Add($"G({order.GuestName})");
                else
                    viewItem.SubItems.Add(order.CustomerAccount.GetName());
                viewItem.SubItems.Add(order.Status.ToString());
                viewItem.SubItems.Add(order.DateScheduled.ToShortDateString());
                viewItem.SubItems.Add(order.Total.ToString("C"));

                listviewOrders.Items.Add(viewItem);
            }
        }
        private void FillAccountListBox()
        {
            List<Account> accounts = AccountManagement.GetAccounts();
            listviewAccounts.Items.Clear();
            foreach (Account account in accounts)
            {
                ListViewItem viewItem = new(account.AccountID.ToString("D8"));
                viewItem.SubItems.Add(account.GetName());
                viewItem.SubItems.Add(account.DateJoined.ToShortDateString());
                viewItem.SubItems.Add(account.AccountType);

                listviewAccounts.Items.Add(viewItem);
            }
        }

        // Event that handles the Changed event
        private void HandleChange(ItemList invItems)
        {
            invItems.Save();
            FillItemListBox();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            WelcomeForm.Current.Show();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (listviewOrders.Items.Count == 0)
                MessageBox.Show("Order list is empty.", "No Orders");
            else if (listviewOrders.SelectedItems.Count == 0)
                MessageBox.Show("Please select an order to view.", "No order selected");
            else
            {
                List<Order> orders = DataManagement.GetOrders();
                int i = listviewOrders.Items.IndexOf(listviewOrders.SelectedItems[0]);

                Order order = orders[i];
                MessageBox.Show(order.GetDisplayText(), "Order Summary");
            }
        }

        private void listviewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listviewOrders.SelectedItems.Count == 0)
            {
                cmbbOrderStatus.Text = "";
                cmbbOrderStatus.Enabled = false;
            }
            else
            {
                List<Order> globalOrders = DataManagement.GetOrders();
                int i = listviewOrders.Items.IndexOf(listviewOrders.SelectedItems[0]);

                cmbbOrderStatus.Enabled = true;
                cmbbOrderStatus.Text = globalOrders[i].Status.ToString();
            }
        }

        private void cmbbOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Order> globalOrders = DataManagement.GetOrders();
            int i = listviewOrders.Items.IndexOf(listviewOrders.SelectedItems[0]);

            globalOrders[i].Status = (StatusEnum)Enum.Parse(typeof(StatusEnum), cmbbOrderStatus.Text);
            globalOrders[i].Save();

            DataManagement.SaveOrders(globalOrders);

            listviewOrders.Items[i].SubItems[2].Text = cmbbOrderStatus.Text;
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (listviewOrders.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select valid order to delete","Deletion Error");
            }
            else
            {
                List<Order> globalOrders = DataManagement.GetOrders();
                int i = listviewOrders.Items.IndexOf(listviewOrders.SelectedItems[0]);

                globalOrders.RemoveAt(i);
                DataManagement.SaveOrders(globalOrders);

                cmbbOrderStatus.Enabled = false;
                FillOrderListBox();
            }
        }
    }
}
