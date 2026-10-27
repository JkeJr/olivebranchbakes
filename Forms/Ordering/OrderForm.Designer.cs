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
            btnBack = new Button();
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
            colOrderedCount = new ColumnHeader();
            colOrderedAllergen = new ColumnHeader();
            colOrderedPrice = new ColumnHeader();
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
            label1.Size = new Size(112, 43);
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
            label2.Size = new Size(53, 22);
            label2.TabIndex = 1;
            label2.Text = "Order";
            // 
            // btnContinue
            // 
            btnContinue.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnContinue.Location = new Point(3, 281);
            btnContinue.Margin = new Padding(3, 2, 3, 2);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(131, 36);
            btnContinue.TabIndex = 6;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnClear.Location = new Point(221, 281);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(77, 36);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnDelete.Location = new Point(139, 281);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(77, 36);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(10, 9);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
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
            splitContainer1.Size = new Size(679, 320);
            splitContainer1.SplitterDistance = 374;
            splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            splitContainer2.FixedPanel = FixedPanel.Panel1;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(3, 2, 3, 2);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(btnBack);
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
            splitContainer2.Size = new Size(372, 320);
            splitContainer2.SplitterDistance = 47;
            splitContainer2.SplitterWidth = 3;
            splitContainer2.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(270, 2);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 22);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(209, 230);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(160, 37);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // numAmount
            // 
            numAmount.Location = new Point(111, 246);
            numAmount.Margin = new Padding(3, 2, 3, 2);
            numAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(93, 23);
            numAmount.TabIndex = 3;
            numAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(229, 10);
            label6.Name = "label6";
            label6.Size = new Size(40, 16);
            label6.TabIndex = 5;
            label6.Text = "Filter:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(111, 230);
            label5.Name = "label5";
            label5.Size = new Size(90, 16);
            label5.TabIndex = 5;
            label5.Text = "Amount: (1-100)";
            // 
            // cmbboxFilter
            // 
            cmbboxFilter.FormattingEnabled = true;
            cmbboxFilter.Items.AddRange(new object[] { "All", "Donuts", "Cakes", "Cookies" });
            cmbboxFilter.Location = new Point(270, 6);
            cmbboxFilter.Margin = new Padding(3, 2, 3, 2);
            cmbboxFilter.Name = "cmbboxFilter";
            cmbboxFilter.Size = new Size(100, 23);
            cmbboxFilter.TabIndex = 0;
            // 
            // cmbboxAllergy
            // 
            cmbboxAllergy.FormattingEnabled = true;
            cmbboxAllergy.Items.AddRange(new object[] { "Tree Nut", "Pine Nut", "Peanut", "Almond", "Dairy", "Strawberry", "Blueberry" });
            cmbboxAllergy.Location = new Point(3, 246);
            cmbboxAllergy.Margin = new Padding(3, 2, 3, 2);
            cmbboxAllergy.Name = "cmbboxAllergy";
            cmbboxAllergy.Size = new Size(100, 23);
            cmbboxAllergy.TabIndex = 2;
            // 
            // chkboxAllergy
            // 
            chkboxAllergy.AutoSize = true;
            chkboxAllergy.Font = new Font("Trebuchet MS", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            chkboxAllergy.Location = new Point(3, 230);
            chkboxAllergy.Margin = new Padding(3, 2, 3, 2);
            chkboxAllergy.Name = "chkboxAllergy";
            chkboxAllergy.Size = new Size(68, 20);
            chkboxAllergy.TabIndex = 1;
            chkboxAllergy.Text = "Allergy?";
            chkboxAllergy.UseVisualStyleBackColor = true;
            chkboxAllergy.CheckedChanged += chkboxAllergy_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(3, 6);
            label4.Name = "label4";
            label4.Size = new Size(50, 22);
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
            listviewItems.Location = new Point(3, 29);
            listviewItems.Margin = new Padding(3, 2, 3, 2);
            listviewItems.Name = "listviewItems";
            listviewItems.Size = new Size(367, 198);
            listviewItems.TabIndex = 1;
            listviewItems.TabStop = false;
            listviewItems.UseCompatibleStateImageBehavior = false;
            listviewItems.View = View.Details;
            listviewItems.SelectedIndexChanged += listviewItems_SelectedIndexChanged;
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
            rtxtComments.Location = new Point(3, 221);
            rtxtComments.Margin = new Padding(3, 2, 3, 2);
            rtxtComments.Name = "rtxtComments";
            rtxtComments.Size = new Size(296, 56);
            rtxtComments.TabIndex = 5;
            rtxtComments.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 206);
            label3.Name = "label3";
            label3.Size = new Size(64, 16);
            label3.TabIndex = 5;
            label3.Text = "Comments:";
            // 
            // listviewOrder
            // 
            listviewOrder.BackColor = Color.AntiqueWhite;
            listviewOrder.Columns.AddRange(new ColumnHeader[] { colOrderedName, colOrderedCount, colOrderedAllergen, colOrderedPrice });
            listviewOrder.FullRowSelect = true;
            listviewOrder.GridLines = true;
            listviewOrder.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listviewOrder.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listviewOrder.Location = new Point(3, 22);
            listviewOrder.Margin = new Padding(3, 2, 3, 2);
            listviewOrder.Name = "listviewOrder";
            listviewOrder.Size = new Size(296, 170);
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
            // colOrderedPrice
            // 
            colOrderedPrice.Text = "$__.__";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(700, 338);
            ControlBox = false;
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnBack;
    }
}