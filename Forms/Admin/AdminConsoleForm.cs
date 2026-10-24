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
            items.Changed += new ItemList.ChangeHandler(HandleChange);
            items.Fill();
            FillItemListBox();
        }

        // Delete an Item from the list of available OrderItems
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //int i = listviewItems.SelectedIndices.IndexOf(0);
            int i = listviewItems.Items.IndexOf(listviewItems.SelectedItems[0]);


            if (listviewItems.Items.Count == 0)
                MessageBox.Show("Item list is already empty.", "No Items");
            else if (i == -1)
                MessageBox.Show("Please select an item to delete.", "No item selected");
            else
            {
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
                viewItem.SubItems.Add(item.Allergens);

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
