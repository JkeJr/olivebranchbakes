namespace OliveBranchBakes.Forms
{
    partial class AdminConsoleForm
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
            splitContainer1 = new SplitContainer();
            lblDate = new Label();
            btnEdit = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            listviewItems = new ListView();
            colCategory = new ColumnHeader();
            colName = new ColumnHeader();
            colPrice = new ColumnHeader();
            colAllergens = new ColumnHeader();
            btnBack = new Button();
            label3 = new Label();
            label1 = new Label();
            listView2 = new ListView();
            colOrderNum = new ColumnHeader();
            colCustomer = new ColumnHeader();
            colPayment = new ColumnHeader();
            colCount = new ColumnHeader();
            btnDetails = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lblDate);
            splitContainer1.Panel1.Controls.Add(btnEdit);
            splitContainer1.Panel1.Controls.Add(btnAdd);
            splitContainer1.Panel1.Controls.Add(btnDelete);
            splitContainer1.Panel1.Controls.Add(listviewItems);
            splitContainer1.Panel1.Controls.Add(btnBack);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(listView2);
            splitContainer1.Panel2.Controls.Add(btnDetails);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(951, 450);
            splitContainer1.SplitterDistance = 567;
            splitContainer1.TabIndex = 0;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDate.ForeColor = SystemColors.GrayText;
            lblDate.Location = new Point(479, 61);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(85, 20);
            lblDate.TabIndex = 4;
            lblDate.Text = "10/25/2026";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(123, 395);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(64, 52);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 395);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 52);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(470, 395);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 52);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // listviewItems
            // 
            listviewItems.BackColor = Color.MistyRose;
            listviewItems.Columns.AddRange(new ColumnHeader[] { colCategory, colName, colPrice, colAllergens });
            listviewItems.FullRowSelect = true;
            listviewItems.GridLines = true;
            listviewItems.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listviewItems.Location = new Point(3, 84);
            listviewItems.MultiSelect = false;
            listviewItems.Name = "listviewItems";
            listviewItems.Size = new Size(561, 305);
            listviewItems.TabIndex = 2;
            listviewItems.TabStop = false;
            listviewItems.UseCompatibleStateImageBehavior = false;
            listviewItems.View = View.Details;
            // 
            // colCategory
            // 
            colCategory.Text = "Categories";
            colCategory.Width = 120;
            // 
            // colName
            // 
            colName.Text = "Name";
            colName.Width = 200;
            // 
            // colPrice
            // 
            colPrice.Text = "$__.__";
            // 
            // colAllergens
            // 
            colAllergens.Text = "Allergens";
            colAllergens.Width = 175;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(470, 13);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 61);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 0;
            label3.Text = "Available Items:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 0;
            label1.Text = "Welcome, Admin!";
            // 
            // listView2
            // 
            listView2.BackColor = Color.MistyRose;
            listView2.Columns.AddRange(new ColumnHeader[] { colOrderNum, colCustomer, colPayment, colCount });
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView2.Location = new Point(3, 32);
            listView2.MultiSelect = false;
            listView2.Name = "listView2";
            listView2.Size = new Size(374, 357);
            listView2.TabIndex = 2;
            listView2.TabStop = false;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // colOrderNum
            // 
            colOrderNum.Text = "Order #";
            colOrderNum.Width = 80;
            // 
            // colCustomer
            // 
            colCustomer.Text = "Customer";
            colCustomer.Width = 170;
            // 
            // colPayment
            // 
            colPayment.Text = "$__.__";
            // 
            // colCount
            // 
            colCount.Text = "Item #";
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(258, 395);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(119, 52);
            btnDetails.TabIndex = 4;
            btnDetails.Text = "View Details";
            btnDetails.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 0;
            label2.Text = "Active Orders:";
            // 
            // AdminConsoleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(951, 450);
            ControlBox = false;
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminConsoleForm";
            Text = "AdminConsoleForm";
            Load += AdminConsoleForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private ListView listviewItems;
        private Button btnBack;
        private Label label3;
        private ListView listView2;
        private Label label2;
        private ColumnHeader colName;
        private ColumnHeader colPrice;
        private ColumnHeader colAllergens;
        private ColumnHeader colCustomer;
        private ColumnHeader colCount;
        private ColumnHeader colPayment;
        private ColumnHeader colOrderNum;
        private Button button3;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnDetails;
        private Button btnEdit;
        private Label lblDate;
        private ColumnHeader colCategory;
    }
}