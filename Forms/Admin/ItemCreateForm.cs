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
        private void ItemCreateForm_Load(object sender, EventArgs e)
        {
            chkSeasonal.Checked = false;

            dtpStart.Enabled = chkSeasonal.Checked;
            dtpStart.MinDate = new DateTime(DateTime.Today.Year, 1, 1);
            dtpStart.MaxDate = new DateTime(DateTime.Today.Year, 12, 31);

            dtpEnd.Enabled = chkSeasonal.Checked;
            dtpStart.MinDate = new DateTime(DateTime.Today.Year, 1, 1);
            dtpStart.MaxDate = new DateTime(DateTime.Today.Year + 1, 12, 31);
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
                if (chkSeasonal.Enabled)
                    item = new(
                            txtName.Text,
                            Convert.ToDecimal(txtPrice.Text),
                            txtAllergens.Text, new DateRange(dtpStart.Value, dtpEnd.Value));
                else
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

        private void chkSeasonal_CheckedChanged(object sender, EventArgs e)
        {
            dtpStart.Enabled = chkSeasonal.Checked;
            dtpEnd.Enabled = chkSeasonal.Checked;
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            // Match dtpEnd lower bound by the dtpStart value
            dtpEnd.MinDate = dtpStart.Value;

            if (dtpStart.Value > dtpEnd.Value)
                dtpEnd.Value = dtpStart.Value;
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            // Check if dtpEnd.Value is currently in the next year
            if (dtpEnd.Value.Year > DateTime.Today.Year)
                dtpStart.MaxDate = new DateTime(DateTime.Today.Year, 12, 31);
            else
                // Match dtpStart upper bound by the dtpEnd value
                dtpStart.MaxDate = dtpEnd.Value;

            if (dtpEnd.Value < dtpStart.Value)
                dtpStart.Value = dtpEnd.Value;
            
        }
    }
}
