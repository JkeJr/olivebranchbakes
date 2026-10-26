using OliveBranchBakes.Forms.Admin;
using OliveBranchBakes.Forms.Payment;
using OliveBranchBakes.Objects;
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
        private ItemList items = new();
        private Order order = new();

        // Source - https://stackoverflow.com/a/8750673
        // Posted by competent_tech
        // Retrieved 2026-10-22, License - CC BY-SA 3.0
        private void OrderForm_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
            order.OrderChanged += new Order.ChangeHandler(HandleChange);

            items.Fill();
            FillItemListBox();
        }

        public OrderForm()
        {
            InitializeComponent();
        }

        // Event handler for changing order
        private void HandleChange(Order order)
        {
            FillOrderBox();
        }

        // Fills listviewItems with values from items
        private void FillItemListBox()
        {
            OrderItem item;
            listviewItems.Items.Clear();
            for (int i = 0; i < items.Count; i++)
            {
                item = items[i];

                if (item.InSeason())
                {
                    ListViewItem viewItem = new(item.Name);
                    viewItem.SubItems.Add(item.Price.ToString());
                    viewItem.SubItems.Add(item.AllergenList.GetDisplayText(", "));

                    listviewItems.Items.Add(viewItem);
                }
            }
        }

        // Fills listviewOrder with values from order
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // something
        }

        // Add selected item to order
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // checks if selected item exists and is valid
            if (listviewItems.Items.Count == 0)
                MessageBox.Show("Item list is empty.", "No Items");
            else if (listviewItems.SelectedItems.Count == 0)
                MessageBox.Show("Please select an item to edit.", "No item selected");
            else
            {
                // gets the index of the selected item, and then copies the item
                int i = listviewItems.Items.IndexOf(listviewItems.SelectedItems[0]);
                OrderItem item = items[i];
                if (item != null)
                    order.Add(item);
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            new PaymentEntryForm().Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            WelcomeForm.Current.Show();
        }
    }
}
