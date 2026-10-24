namespace OliveBranchBakes.Forms
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem("");
            label1 = new Label();
            label2 = new Label();
            btnContinue = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            btnAdd = new Button();
            numAmount = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            cmbboxFilter = new ComboBox();
            cmbboxAllergy = new ComboBox();
            chkboxAllergy = new CheckBox();
            label4 = new Label();
            listviewItems = new ListView();
            colName = new ColumnHeader();
            colPrice = new ColumnHeader();
            colAllergens = new ColumnHeader();
            colCount = new ColumnHeader();
            rtxtComments = new RichTextBox();
            label3 = new Label();
            listviewOrder = new ListView();
            colOrderedName = new ColumnHeader();
            colOrderedPrice = new ColumnHeader();
            colOrderedCount = new ColumnHeader();
            colOrderedAllergen = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 55);
            label1.TabIndex = 1;
            label1.Text = "MENU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 26);
            label2.TabIndex = 1;
            label2.Text = "Order";
            // 
            // btnContinue
            // 
            btnContinue.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnContinue.Location = new Point(3, 375);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(150, 48);
            btnContinue.TabIndex = 6;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnClear.Location = new Point(253, 375);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 48);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnDelete.Location = new Point(159, 375);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 48);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(rtxtComments);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(listviewOrder);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(btnClear);
            splitContainer1.Panel2.Controls.Add(btnDelete);
            splitContainer1.Panel2.Controls.Add(btnContinue);
            splitContainer1.Size = new Size(776, 426);
            splitContainer1.SplitterDistance = 428;
            splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            splitContainer2.FixedPanel = FixedPanel.Panel1;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(label1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(btnAdd);
            splitContainer2.Panel2.Controls.Add(numAmount);
            splitContainer2.Panel2.Controls.Add(label6);
            splitContainer2.Panel2.Controls.Add(label5);
            splitContainer2.Panel2.Controls.Add(cmbboxFilter);
            splitContainer2.Panel2.Controls.Add(cmbboxAllergy);
            splitContainer2.Panel2.Controls.Add(chkboxAllergy);
            splitContainer2.Panel2.Controls.Add(label4);
            splitContainer2.Panel2.Controls.Add(listviewItems);
            splitContainer2.Size = new Size(425, 426);
            splitContainer2.SplitterDistance = 63;
            splitContainer2.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(239, 306);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(183, 49);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // numAmount
            // 
            numAmount.Location = new Point(127, 328);
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(106, 27);
            numAmount.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(262, 13);
            label6.Name = "label6";
            label6.Size = new Size(45, 18);
            label6.TabIndex = 5;
            label6.Text = "Filter:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(127, 306);
            label5.Name = "label5";
            label5.Size = new Size(105, 18);
            label5.TabIndex = 5;
            label5.Text = "Amount: (1-100)";
            // 
            // cmbboxFilter
            // 
            cmbboxFilter.FormattingEnabled = true;
            cmbboxFilter.Items.AddRange(new object[] { "All", "Donuts", "Cakes", "Cookies" });
            cmbboxFilter.Location = new Point(308, 8);
            cmbboxFilter.Name = "cmbboxFilter";
            cmbboxFilter.Size = new Size(114, 28);
            cmbboxFilter.TabIndex = 0;
            // 
            // cmbboxAllergy
            // 
            cmbboxAllergy.FormattingEnabled = true;
            cmbboxAllergy.Items.AddRange(new object[] { "Tree Nut", "Pine Nut", "Peanut", "Almond", "Dairy", "Strawberry", "Blueberry" });
            cmbboxAllergy.Location = new Point(3, 328);
            cmbboxAllergy.Name = "cmbboxAllergy";
            cmbboxAllergy.Size = new Size(114, 28);
            cmbboxAllergy.TabIndex = 2;
            // 
            // chkboxAllergy
            // 
            chkboxAllergy.AutoSize = true;
            chkboxAllergy.Font = new Font("Trebuchet MS", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            chkboxAllergy.Location = new Point(3, 306);
            chkboxAllergy.Name = "chkboxAllergy";
            chkboxAllergy.Size = new Size(76, 22);
            chkboxAllergy.TabIndex = 1;
            chkboxAllergy.Text = "Allergy?";
            chkboxAllergy.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(3, 10);
            label4.Name = "label4";
            label4.Size = new Size(64, 26);
            label4.TabIndex = 2;
            label4.Text = "Items";
            // 
            // listviewItems
            // 
            listviewItems.BackColor = Color.AntiqueWhite;
            listviewItems.Columns.AddRange(new ColumnHeader[] { colName, colPrice, colAllergens, colCount });
            listviewItems.FullRowSelect = true;
            listviewItems.GridLines = true;
            listviewItems.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listviewItems.Location = new Point(3, 39);
            listviewItems.Name = "listviewItems";
            listviewItems.Size = new Size(419, 263);
            listviewItems.TabIndex = 1;
            listviewItems.TabStop = false;
            listviewItems.UseCompatibleStateImageBehavior = false;
            listviewItems.View = View.Details;
            // 
            // colName
            // 
            colName.Text = "Name";
            colName.Width = 150;
            // 
            // colPrice
            // 
            colPrice.Text = "$__.__";
            // 
            // colAllergens
            // 
            colAllergens.Text = "Allergens";
            colAllergens.Width = 170;
            // 
            // colCount
            // 
            colCount.Text = "#";
            // 
            // rtxtComments
            // 
            rtxtComments.BackColor = Color.AntiqueWhite;
            rtxtComments.Location = new Point(3, 295);
            rtxtComments.Name = "rtxtComments";
            rtxtComments.Size = new Size(338, 74);
            rtxtComments.TabIndex = 5;
            rtxtComments.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 274);
            label3.Name = "label3";
            label3.Size = new Size(75, 18);
            label3.TabIndex = 5;
            label3.Text = "Comments:";
            // 
            // listviewOrder
            // 
            listviewOrder.BackColor = Color.AntiqueWhite;
            listviewOrder.Columns.AddRange(new ColumnHeader[] { colOrderedName, colOrderedPrice, colOrderedCount, colOrderedAllergen });
            listviewOrder.FullRowSelect = true;
            listviewOrder.GridLines = true;
            listviewOrder.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listviewOrder.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listviewOrder.Location = new Point(3, 29);
            listviewOrder.Name = "listviewOrder";
            listviewOrder.Size = new Size(338, 226);
            listviewOrder.TabIndex = 4;
            listviewOrder.TabStop = false;
            listviewOrder.UseCompatibleStateImageBehavior = false;
            listviewOrder.View = View.Details;
            // 
            // colOrderedName
            // 
            colOrderedName.Text = "Name";
            colOrderedName.Width = 150;
            // 
            // colOrderedPrice
            // 
            colOrderedPrice.Text = "$__.__";
            // 
            // colOrderedCount
            // 
            colOrderedCount.Text = "#";
            colOrderedCount.Width = 30;
            // 
            // colOrderedAllergen
            // 
            colOrderedAllergen.Text = "Allergen";
            colOrderedAllergen.Width = 80;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(splitContainer1);
            Name = "OrderForm";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "OrderForm";
            Load += OrderForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button btnContinue;
        private Button btnClear;
        private Button btnDelete;
        private SplitContainer splitContainer1;
        private ListView listviewOrder;
        private SplitContainer splitContainer2;
        private RichTextBox rtxtComments;
        private Label label3;
        private CheckBox chkboxAllergy;
        private Label label4;
        private ListView listviewItems;
        private NumericUpDown numAmount;
        private Label label5;
        private ComboBox cmbboxAllergy;
        private Button btnAdd;
        private ComboBox cmbboxFilter;
        private Label label6;
        private ColumnHeader colName;
        private ColumnHeader colPrice;
        private ColumnHeader colAllergens;
        private ColumnHeader colCount;
        private ColumnHeader colOrderedName;
        private ColumnHeader colOrderedPrice;
        private ColumnHeader colOrderedCount;
        private ColumnHeader colOrderedAllergen;
    }
}