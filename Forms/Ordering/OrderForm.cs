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
                ListViewItem viewItem = new(item.Name);
                viewItem.SubItems.Add(item.Count.ToString());
                viewItem.SubItems.Add(item.Allergy.ToString());
                viewItem.SubItems.Add(item.Price.ToString());

                listviewOrder.Items.Add(viewItem);
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
                {
                    if (chkboxAllergy.Checked == true)
                        item.Allergy = new Allergen(cmbboxAllergy.SelectedItem.ToString());
                    item.Count = (int)numAmount.Value;
                    item.Price = item.Price * item.Count;
                    
                    order.Add(item);
                    numAmount.Value = 1;
                }
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            PaymentEntryForm paymentEntry = new();
            if (order.Count == 0)
            {
                MessageBox.Show("This order is empty. Add items to continue.", "Empty Order");
            }
            else if (paymentEntry.ConfirmOrder(order))
            {
                this.Close();
                new PaymentEntryForm().Show();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            WelcomeForm.Current.Show();
        }

        // Any time a new item is clicked, reset Allergy Check Box to unchecked
        private void listviewItems_SelectedIndexChanged(object sender, EventArgs e) => chkboxAllergy.Checked = false;

        // Fill Allergy Combo Box to have the correct values
        private void chkboxAllergy_CheckedChanged(object sender, EventArgs e)
        {
            cmbboxAllergy.Enabled = chkboxAllergy.Checked;
            if (chkboxAllergy.Checked)
            {
                cmbboxAllergy.Items.Clear();

                // gets the index of the selected item, and then copies the item
                int i = listviewItems.Items.IndexOf(listviewItems.SelectedItems[0]);
                OrderItem item = items[i];

                // for each Allergen in item's AllergenList, add that value as a stirng to cmbboxAllergy
                for (int n = 0; n < item.AllergenList.Count; n++)
                {
                    cmbboxAllergy.Items.Add(item.AllergenList[n].ToString());
                }
            }
        }
    }
}
