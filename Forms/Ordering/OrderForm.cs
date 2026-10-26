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

        // Source - https://stackoverflow.com/a/8750673
        // Posted by competent_tech
        // Retrieved 2026-10-22, License - CC BY-SA 3.0
        private void OrderForm_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
            items.Fill();
            FillItemListBox();
        }

        public OrderForm()
        {
            InitializeComponent();
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // something
        }

        // Add selected item to 
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            new PaymentEntryForm().Show();
            this.Close();
        }
    }
}
