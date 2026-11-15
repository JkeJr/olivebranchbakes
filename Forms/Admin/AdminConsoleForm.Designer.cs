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
            btnHide = new Button();
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
            cmbbAccountType = new ComboBox();
            btnDeleteAccount = new Button();
            btnDetailsAccount = new Button();
            cmbbOrderStatus = new ComboBox();
            btnDeleteOrder = new Button();
            btnDetailsOrder = new Button();
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
            splitContainer1.Panel1.Controls.Add(btnHide);
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
            splitContainer1.Panel2.Controls.Add(cmbbAccountType);
            splitContainer1.Panel2.Controls.Add(btnDeleteAccount);
            splitContainer1.Panel2.Controls.Add(btnDetailsAccount);
            splitContainer1.Panel2.Controls.Add(cmbbOrderStatus);
            splitContainer1.Panel2.Controls.Add(btnDeleteOrder);
            splitContainer1.Panel2.Controls.Add(btnDetailsOrder);
            splitContainer1.Panel2.Controls.Add(listviewAccounts);
            splitContainer1.Panel2.Controls.Add(listviewOrders);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(1039, 497);
            splitContainer1.SplitterDistance = 573;
            splitContainer1.TabIndex = 0;
            // 
            // btnHide
            // 
            btnHide.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHide.Location = new Point(359, 433);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(85, 52);
            btnHide.TabIndex = 3;
            btnHide.Text = "Hide";
            btnHide.UseVisualStyleBackColor = true;
            btnHide.Click += btnHide_Click;
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
            btnEdit.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
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
            btnAdd.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
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
            btnDelete.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(450, 433);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 52);
            btnDelete.TabIndex = 4;
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
            // cmbbAccountType
            // 
            cmbbAccountType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbbAccountType.FormattingEnabled = true;
            cmbbAccountType.Location = new Point(135, 246);
            cmbbAccountType.Name = "cmbbAccountType";
            cmbbAccountType.Size = new Size(124, 28);
            cmbbAccountType.TabIndex = 8;
            cmbbAccountType.SelectedIndexChanged += cmbbAccountType_SelectedIndexChanged;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            btnDeleteAccount.Location = new Point(265, 245);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(94, 29);
            btnDeleteAccount.TabIndex = 9;
            btnDeleteAccount.Text = "Delete";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // btnDetailsAccount
            // 
            btnDetailsAccount.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            btnDetailsAccount.Location = new Point(365, 245);
            btnDetailsAccount.Name = "btnDetailsAccount";
            btnDetailsAccount.Size = new Size(94, 29);
            btnDetailsAccount.TabIndex = 10;
            btnDetailsAccount.Text = "Details";
            btnDetailsAccount.UseVisualStyleBackColor = true;
            btnDetailsAccount.Click += btnDetailsAccount_Click;
            // 
            // cmbbOrderStatus
            // 
            cmbbOrderStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbbOrderStatus.FormattingEnabled = true;
            cmbbOrderStatus.Location = new Point(159, 9);
            cmbbOrderStatus.Name = "cmbbOrderStatus";
            cmbbOrderStatus.Size = new Size(100, 28);
            cmbbOrderStatus.TabIndex = 5;
            cmbbOrderStatus.SelectedIndexChanged += cmbbOrderStatus_SelectedIndexChanged;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            btnDeleteOrder.Location = new Point(265, 8);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(94, 29);
            btnDeleteOrder.TabIndex = 6;
            btnDeleteOrder.Text = "Delete";
            btnDeleteOrder.UseVisualStyleBackColor = true;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // btnDetailsOrder
            // 
            btnDetailsOrder.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            btnDetailsOrder.Location = new Point(365, 8);
            btnDetailsOrder.Name = "btnDetailsOrder";
            btnDetailsOrder.Size = new Size(94, 29);
            btnDetailsOrder.TabIndex = 7;
            btnDetailsOrder.Text = "Details";
            btnDetailsOrder.UseVisualStyleBackColor = true;
            btnDetailsOrder.Click += btnDetails_Click;
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
            listviewAccounts.TabStop = false;
            listviewAccounts.UseCompatibleStateImageBehavior = false;
            listviewAccounts.View = View.Details;
            listviewAccounts.SelectedIndexChanged += listviewAccounts_SelectedIndexChanged;
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
            listviewOrders.SelectedIndexChanged += listviewOrders_SelectedIndexChanged;
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
            label4.Size = new Size(104, 26);
            label4.TabIndex = 0;
            label4.Text = "Accounts:";
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
            Text = "Olive Branch Bakes | Admin Console";
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
        private Button btnDetailsOrder;
        private ComboBox cmbbOrderStatus;
        private Button btnDeleteOrder;
        private Button btnDetailsAccount;
        private Button btnDeleteAccount;
        private ComboBox cmbbAccountType;
        private Button btnHide;
    }
}