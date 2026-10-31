using OliveBranchBakes.Objects;
using OliveBranchBakes.Objects.Order_Assets;
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
        private AllergenList allergenList = new();
        private ItemCategories categoryList = new();

        public ItemCreateForm()
        {
            InitializeComponent();
        }
        private void ItemCreateForm_Load(object sender, EventArgs e)
        {
            // Seasonal initialization
            chkSeasonal.Checked = false;

            dtpStart.Enabled = chkSeasonal.Checked;
            dtpStart.MinDate = new DateTime(DateTime.Today.Year, 1, 1);
            dtpStart.MaxDate = new DateTime(DateTime.Today.Year, 12, 31);

            dtpEnd.Enabled = chkSeasonal.Checked;
            dtpStart.MinDate = new DateTime(DateTime.Today.Year, 1, 1);
            dtpStart.MaxDate = new DateTime(DateTime.Today.Year + 1, 12, 31);

            // Lists
            Fill();

            txtAllergens.Clear();
            UpdateAllergenText();

            //categoryList.Add(CategoryEnums.Misc);
            //txtCategories.Text = categoryList.ToString(", ");
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
            txtAllergens.Text = orderItem.AllergenList.ToString(", ");

            // Fill in seasonal data if applicable
            if (orderItem.Seasonal)
            {
                chkSeasonal.Checked = true;
                DateTime start = (DateTime)orderItem.Season[0];
                DateTime end = (DateTime)orderItem.Season[1];

                dtpStart.Enabled = chkSeasonal.Checked;
                dtpStart.MinDate = new DateTime(DateTime.Today.Year, 1, 1);
                dtpStart.MaxDate = end;

                dtpEnd.Enabled = chkSeasonal.Checked;
                dtpStart.MinDate = start;
                dtpStart.MaxDate = new DateTime(DateTime.Today.Year + 1, 12, 31);

                dtpStart.Value = start;
                dtpEnd.Value = end;
            }

            this.ShowDialog();
            return item;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (chkSeasonal.Checked)
                    item = new(
                            [""],
                            txtName.Text,
                            Convert.ToDecimal(txtPrice.Text),
                            allergenList,
                            new DateRange(dtpStart.Value, dtpEnd.Value));
                else
                    item = new(
                            [""],
                            txtName.Text,
                            Convert.ToDecimal(txtPrice.Text),
                            allergenList);
            }
            this.Close();
        }

        // Converts to string AND formats it ready for AllergenIngredients enum
        private static string[] ConvertToStringList(string entry, string splitter)
        {
            string[] list = entry.Replace(" ", "").Split(splitter);
            foreach (string srt in list)
            {
                list[list.IndexOf(srt)] = srt[0].ToString().ToUpper() + srt.Substring(1).ToLower();
            }

            return list;
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            // Expand checks when I add more properties to OrderItem
            errorMessage += Validator.IsPresent(txtName.Text, "Item Name");
            errorMessage += Validator.IsPresent(txtPrice.Text, "Price");
            errorMessage += Validator.IsDecimal(txtPrice.Text, "Price");
            //errorMessage += Validator.IsPresent(txtAllergens.Text, "Allergen Ingredients");

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

        // List Controls

        // Allergens
        private void btnAddAllergy_Click(object sender, EventArgs e)
        {
            int index = lbAllergens.SelectedIndex;
            Allergen allergen = new(lbAllergens.Items[index].ToString()!);

            if (index == -1)
            {
                MessageBox.Show("Please select an Allergy", "Selection Error");
            }
            // Check if Allergy already exists in allergyList
            else if (allergenList.IndexOf(allergen) != -1)
            {
                MessageBox.Show("Allergy already in list", "Selection Error");
            }
            else
            {
                allergenList.Add(allergen);
                UpdateAllergenText();
            }
        }
        private void btnRemoveAllergy_Click(object sender, EventArgs e)
        {
            int index = lbAllergens.SelectedIndex;
            Allergen allergen = new(lbAllergens.Items[index].ToString()!);

            if (index == -1)
            {
                MessageBox.Show("Please select an Allergy", "Selection Error");
            }
            else if (allergenList.IndexOf(allergen) == -1)
            {
                MessageBox.Show("Allergy is not in list", "Selection Error");
            }
            else
            {
                allergenList.Remove(allergen);
                UpdateAllergenText();
            }
        }
        private void btnClearAllergies_Click(object sender, EventArgs e)
        {
            allergenList.Clear();
            UpdateAllergenText();
        }

        // Set allergen text to the correct list
        private void UpdateAllergenText()
        {
            // If the list is empty, add "None" as the listed allergen
            if (allergenList.Count == 0)
                allergenList.Add(AllergenIngredients.None);
            else if (allergenList.Count > 1)
            {
                // If "None" is a listed allergen among others, remove it
                int n = allergenList.IndexOf(new Allergen(AllergenIngredients.None));
                if (n != -1)
                    allergenList.RemoveAt(n);
            }
            txtAllergens.Text = allergenList.ToString(", ");
        }

        // Fills the listbox items
        private void Fill()
        {
            lbAllergens.Items.Clear();
            lbCategories.Items.Clear();

            // Loop through AllergenIngredients and ignore "None"
            foreach (string allergen in Enum.GetNames(typeof(AllergenIngredients)))
                if (allergen != "None")
                    lbAllergens.Items.Add(allergen);

            // Loop through CategoryEnums
            foreach (string category in Enum.GetNames(typeof(CategoryEnums)))
                lbCategories.Items.Add(category);
        }
    }
}
