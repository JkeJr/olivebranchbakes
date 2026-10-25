using OliveBranchBakes.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OliveBranchBakes.Forms.Admin
{
    public partial class ItemCreateForm : Form
    {
        public ItemCreateForm()
        {
            InitializeComponent();
        }

        private OrderItem item = null!;

        public OrderItem GetNewItem()
        {
            this.ShowDialog();
            return item;
        }

        public OrderItem EditItem(OrderItem orderItem)
        {
            txtName.Text = orderItem.Name;
            txtPrice.Text = orderItem.Price.ToString();
            txtAllergens.Text = orderItem.Allergens;

            this.ShowDialog();
            return item;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                item = new(
                        txtName.Text,
                        Convert.ToDecimal(txtPrice.Text),
                        txtAllergens.Text);
            }
            this.Close();
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            // Expand checks when I add more properties to OrderItem
            errorMessage += Validator.IsPresent(txtName.Text, "Item Name");
            errorMessage += Validator.IsPresent(txtPrice.Text, "Price");
            errorMessage += Validator.IsDecimal(txtPrice.Text, "Price");
            errorMessage += Validator.IsPresent(txtAllergens.Text, "Allergen Ingredients");

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
