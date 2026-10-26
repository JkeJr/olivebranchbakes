using OliveBranchBakes.Forms.Admin;
using OliveBranchBakes.Objects;
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
                if (item is OrderItem o)
                    message = $"{o.GetType().ToString()} type {o.Name} has been added.";

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
                    if (item is OrderItem o)
                        message = $"{o.GetType().ToString()} type {o.Name} has been edited.";

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

                // listviewItems.Items.Remove(listviewItems.SelectedItems[0]);
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
                ListViewItem viewItem = new(item.Name);
                viewItem.SubItems.Add(item.Price.ToString());
                viewItem.SubItems.Add(item.AllergenList.GetDisplayText(", "));
                
                // Shows which items are in season; Green if true, OrangeRed if false
                if (item.Seasonal)
                    viewItem.BackColor = (item.InSeason())? Color.Green : Color.OrangeRed;

                listviewItems.Items.Add(viewItem);
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
    }
}
