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
            btnDetails = new Button();
            listviewAccounts = new ListView();
            colCustomerID = new ColumnHeader();
            colCustomerName = new ColumnHeader();
            colDateJoined = new ColumnHeader();
            colAccountType = new ColumnHeader();
            listviewOrders = new ListView();
            colOrderNum = new ColumnHeader();
            colCustomer = new ColumnHeader();
            colStatus = new ColumnHeader();
            colScheduled = new ColumnHeader();
            colCost = new ColumnHeader();
            label4 = new Label();
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
            splitContainer1.Panel2.Controls.Add(btnDetails);
            splitContainer1.Panel2.Controls.Add(listviewAccounts);
            splitContainer1.Panel2.Controls.Add(listviewOrders);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(1039, 497);
            splitContainer1.SplitterDistance = 573;
            splitContainer1.TabIndex = 0;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Trebuchet MS", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDate.ForeColor = SystemColors.GrayText;
            lblDate.Location = new Point(486, 63);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(78, 18);
            lblDate.TabIndex = 4;
            lblDate.Text = "10/25/2026";
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEdit.Location = new Point(123, 433);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(85, 52);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(3, 433);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 52);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDelete.Location = new Point(470, 433);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 52);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // listviewItems
            // 
            listviewItems.BackColor = Color.AntiqueWhite;
            listviewItems.Columns.AddRange(new ColumnHeader[] { colCategory, colName, colPrice, colAllergens });
            listviewItems.FullRowSelect = true;
            listviewItems.GridLines = true;
            listviewItems.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listviewItems.Location = new Point(3, 84);
            listviewItems.MultiSelect = false;
            listviewItems.Name = "listviewItems";
            listviewItems.Size = new Size(561, 343);
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
            colName.Width = 170;
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
            btnBack.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(470, 9);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 52);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(3, 55);
            label3.Name = "label3";
            label3.Size = new Size(165, 26);
            label3.TabIndex = 0;
            label3.Text = "Available Items:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(263, 38);
            label1.TabIndex = 0;
            label1.Text = "Welcome, Admin!";
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(365, 8);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(94, 29);
            btnDetails.TabIndex = 6;
            btnDetails.Text = "Details";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // listviewAccounts
            // 
            listviewAccounts.BackColor = Color.AntiqueWhite;
            listviewAccounts.Columns.AddRange(new ColumnHeader[] { colCustomerID, colCustomerName, colDateJoined, colAccountType });
            listviewAccounts.FullRowSelect = true;
            listviewAccounts.GridLines = true;
            listviewAccounts.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listviewAccounts.Location = new Point(3, 277);
            listviewAccounts.Name = "listviewAccounts";
            listviewAccounts.Size = new Size(456, 208);
            listviewAccounts.TabIndex = 5;
            listviewAccounts.UseCompatibleStateImageBehavior = false;
            listviewAccounts.View = View.Details;
            // 
            // colCustomerID
            // 
            colCustomerID.Text = "ID#";
            colCustomerID.Width = 80;
            // 
            // colCustomerName
            // 
            colCustomerName.Text = "Name";
            colCustomerName.Width = 150;
            // 
            // colDateJoined
            // 
            colDateJoined.Text = "Date Joined";
            colDateJoined.Width = 105;
            // 
            // colAccountType
            // 
            colAccountType.Text = "Type";
            colAccountType.Width = 85;
            // 
            // listviewOrders
            // 
            listviewOrders.BackColor = Color.AntiqueWhite;
            listviewOrders.Columns.AddRange(new ColumnHeader[] { colOrderNum, colCustomer, colStatus, colScheduled, colCost });
            listviewOrders.FullRowSelect = true;
            listviewOrders.GridLines = true;
            listviewOrders.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listviewOrders.Location = new Point(3, 40);
            listviewOrders.MultiSelect = false;
            listviewOrders.Name = "listviewOrders";
            listviewOrders.Size = new Size(456, 194);
            listviewOrders.TabIndex = 2;
            listviewOrders.TabStop = false;
            listviewOrders.UseCompatibleStateImageBehavior = false;
            listviewOrders.View = View.Details;
            // 
            // colOrderNum
            // 
            colOrderNum.Text = "Order #";
            colOrderNum.Width = 80;
            // 
            // colCustomer
            // 
            colCustomer.Text = "Customer";
            colCustomer.Width = 115;
            // 
            // colStatus
            // 
            colStatus.Text = "Status";
            colStatus.Width = 75;
            // 
            // colScheduled
            // 
            colScheduled.Text = "Due Date";
            colScheduled.Width = 90;
            // 
            // colCost
            // 
            colCost.Text = "$__.__";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(3, 248);
            label4.Name = "label4";
            label4.Size = new Size(118, 26);
            label4.TabIndex = 0;
            label4.Text = "Customers:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(3, 11);
            label2.Name = "label2";
            label2.Size = new Size(150, 26);
            label2.TabIndex = 0;
            label2.Text = "Active Orders:";
            // 
            // AdminConsoleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1039, 497);
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
        private ListView listviewOrders;
        private Label label2;
        private ColumnHeader colName;
        private ColumnHeader colPrice;
        private ColumnHeader colAllergens;
        private ColumnHeader colCustomer;
        private ColumnHeader colScheduled;
        private ColumnHeader colStatus;
        private ColumnHeader colOrderNum;
        private Button button3;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
        private Label lblDate;
        private ColumnHeader colCategory;
        private ListView listviewAccounts;
        private Label label4;
        private ColumnHeader colCustomerID;
        private ColumnHeader colCustomerName;
        private ColumnHeader colDateJoined;
        private ColumnHeader colCost;
        private ColumnHeader colAccountType;
        private Button btnDetails;
    }
}