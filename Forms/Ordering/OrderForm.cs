using OliveBranchBakes.Forms.Admin;
using OliveBranchBakes.Forms.Payment;
using OliveBranchBakes.Objects;
using OliveBranchBakes.Objects.Order_Assets;
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
            chkboxAllergy.Enabled = false;

            cmbboxAllergy.Enabled = false;
            cmbboxAllergy.Items.Clear();
            cmbboxAllergy.Text = "";

            cmbboxFilter.Items.Clear();
            cmbboxFilter.Items.Add("None");
            foreach (string category in Enum.GetNames(typeof(CategoryEnums)))
                cmbboxFilter.Items.Add(category);
            cmbboxFilter.SelectedIndex = 0;

            items.Fill();
            FillItemListBox();
        }

        public OrderForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for changing order
        /// </summary>
        private void HandleChange(Order order)
        {
            FillOrderBox();
        }

        /// <summary>
        /// Fills listviewItems with values from items
        /// </summary>
        private void FillItemListBox()
        {
            OrderItem item;
            listviewItems.Items.Clear();
            for (int i = 0; i < items.Count; i++)
            {
                item = items[i];
                CategoryEnums category = CategoryEnums.Misc;

                // More complicated than it has to be
                if (cmbboxFilter.SelectedItem.ToString() != "None")
                {
                    category = (CategoryEnums)Enum.Parse(typeof(CategoryEnums), cmbboxFilter.SelectedItem.ToString()!);

                    if (item.Categories.IndexOf(category) != -1 && item.InSeason())
                    {
                        ListViewItem viewItem = new(item.Name);
                        viewItem.SubItems.Add(item.Price.ToString());
                        viewItem.SubItems.Add(item.AllergenList.ToString(", "));

                        listviewItems.Items.Add(viewItem);
                    }
                }
                else
                {
                    if (item.InSeason())
                    {
                        ListViewItem viewItem = new(item.Name);
                        viewItem.SubItems.Add(item.Price.ToString());
                        viewItem.SubItems.Add(item.AllergenList.ToString(", "));

                        listviewItems.Items.Add(viewItem);
                    }
                }
            }
        }

        /// <summary>
        /// Fills listviewOrder with values from order
        /// </summary>
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
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // something
        }

        /// <summary>
        /// Add selected item to order
        /// <summary>
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
                int inventoryIndex = listviewItems.Items.IndexOf(listviewItems.SelectedItems[0]);

                if (items[inventoryIndex] != null)
                {
                    Allergen allergen = (chkboxAllergy.Checked) ? new Allergen(cmbboxAllergy.SelectedItem.ToString()) : new Allergen(AllergenIngredients.None);
                    int orderIndex = order.IndexOf(items[inventoryIndex], allergen);

                    // check if item can be found in order.itemGroups
                    if (orderIndex != -1 /*&& order[orderIndex].Allergy == allergen*/)
                    {
                        //order[orderIndex].Count += (int)numAmount.Value;
                        order.Add(orderIndex, (int)numAmount.Value);
                        //order = order[orderIndex] + (int)numAmount.Value;
                    }
                    else
                    {
                        // Add new itemGroup to order.itemGroups
                        OrderItemGroup itemGroup = new()
                        {
                            ItemType = items[inventoryIndex],
                            Allergy = allergen,
                            Count = (int)numAmount.Value,
                        };
                        order += itemGroup;
                    }
                    // Reset numAmount value to 1
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

        /// <summary>
        /// Any time a new item is clicked, reset Allergy Check Box to enabled but unchecked
        /// </summary>
        private void listviewItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkboxAllergy.Checked = false;
            chkboxAllergy.Enabled = true;

            cmbboxAllergy.Enabled = false;
            cmbboxAllergy.Items.Clear();
            cmbboxAllergy.Text = "";
        }

        /// <summary>
        /// Fill Allergy Combo Box to have the correct values
        /// </summary>
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
                cmbboxAllergy.Items.Add(AllergenIngredients.None);
                if (i != -1)
                {
                    for (int n = 0; n < item.AllergenList.Count; n++)
                    {
                        cmbboxAllergy.Items.Add(item.AllergenList[n].ToString());
                    }
                }
                cmbboxAllergy.SelectedIndex = 0;
            }
            else
            {
                cmbboxAllergy.Items.Clear();
                cmbboxAllergy.Text = "";
            }
        }

        private void cmbboxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillItemListBox();
        }
    }
}
