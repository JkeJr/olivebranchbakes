namespace OliveBranchBakes.Forms.Login
{
    partial class CustomerHomeForm
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
            btnDeleteAccount = new Button();
            btnEditAccount = new Button();
            lblCreationDate = new Label();
            lblEmail = new Label();
            lblName = new Label();
            btnReorder = new Button();
            btnDetails = new Button();
            lstviewPrevOrders = new ListView();
            colOrderNum = new ColumnHeader();
            colDateCreated = new ColumnHeader();
            colDateScheduled = new ColumnHeader();
            colCount = new ColumnHeader();
            colCost = new ColumnHeader();
            label2 = new Label();
            label1 = new Label();
            btnBack = new Button();
            lblWelcome = new Label();
            btnCancel = new Button();
            btnOrder = new Button();
            txtTotal = new TextBox();
            label7 = new Label();
            lstviewCurOrder = new ListView();
            colCountItem = new ColumnHeader();
            colNameItem = new ColumnHeader();
            colAllergy = new ColumnHeader();
            colPrice = new ColumnHeader();
            lblOrderStatus = new Label();
            label6 = new Label();
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
            splitContainer1.Panel1.Controls.Add(btnDeleteAccount);
            splitContainer1.Panel1.Controls.Add(btnEditAccount);
            splitContainer1.Panel1.Controls.Add(lblCreationDate);
            splitContainer1.Panel1.Controls.Add(lblEmail);
            splitContainer1.Panel1.Controls.Add(lblName);
            splitContainer1.Panel1.Controls.Add(btnReorder);
            splitContainer1.Panel1.Controls.Add(btnDetails);
            splitContainer1.Panel1.Controls.Add(lstviewPrevOrders);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(btnBack);
            splitContainer1.Panel1.Controls.Add(lblWelcome);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnCancel);
            splitContainer1.Panel2.Controls.Add(btnOrder);
            splitContainer1.Panel2.Controls.Add(txtTotal);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(lstviewCurOrder);
            splitContainer1.Panel2.Controls.Add(lblOrderStatus);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Size = new Size(792, 450);
            splitContainer1.SplitterDistance = 445;
            splitContainer1.TabIndex = 0;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            btnDeleteAccount.Location = new Point(12, 163);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(128, 29);
            btnDeleteAccount.TabIndex = 10;
            btnDeleteAccount.Text = "Delete Account";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btnEditAccount
            // 
            btnEditAccount.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            btnEditAccount.Location = new Point(12, 85);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(128, 61);
            btnEditAccount.TabIndex = 9;
            btnEditAccount.Text = "Edit Info";
            btnEditAccount.UseVisualStyleBackColor = true;
            // 
            // lblCreationDate
            // 
            lblCreationDate.AutoSize = true;
            lblCreationDate.Location = new Point(146, 167);
            lblCreationDate.Name = "lblCreationDate";
            lblCreationDate.Size = new Size(114, 20);
            lblCreationDate.TabIndex = 8;
            lblCreationDate.Text = "Customer Since:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(146, 126);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 20);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "E-Mail:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(146, 85);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 8;
            lblName.Text = "Name:";
            // 
            // btnReorder
            // 
            btnReorder.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            btnReorder.Location = new Point(217, 392);
            btnReorder.Name = "btnReorder";
            btnReorder.Size = new Size(125, 55);
            btnReorder.TabIndex = 7;
            btnReorder.Text = "Re-Order";
            btnReorder.UseVisualStyleBackColor = true;
            // 
            // btnDetails
            // 
            btnDetails.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            btnDetails.Location = new Point(348, 392);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(94, 55);
            btnDetails.TabIndex = 6;
            btnDetails.Text = "Details";
            btnDetails.UseVisualStyleBackColor = true;
            // 
            // lstviewPrevOrders
            // 
            lstviewPrevOrders.BackColor = Color.AntiqueWhite;
            lstviewPrevOrders.Columns.AddRange(new ColumnHeader[] { colOrderNum, colDateCreated, colDateScheduled, colCount, colCost });
            lstviewPrevOrders.FullRowSelect = true;
            lstviewPrevOrders.GridLines = true;
            lstviewPrevOrders.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lstviewPrevOrders.Location = new Point(3, 229);
            lstviewPrevOrders.Name = "lstviewPrevOrders";
            lstviewPrevOrders.Size = new Size(439, 157);
            lstviewPrevOrders.TabIndex = 5;
            lstviewPrevOrders.TabStop = false;
            lstviewPrevOrders.UseCompatibleStateImageBehavior = false;
            lstviewPrevOrders.View = View.Details;
            // 
            // colOrderNum
            // 
            colOrderNum.Text = "Order #";
            colOrderNum.Width = 80;
            // 
            // colDateCreated
            // 
            colDateCreated.Text = "Date Order'd";
            colDateCreated.Width = 100;
            // 
            // colDateScheduled
            // 
            colDateScheduled.Text = "Date Sched'd";
            colDateScheduled.Width = 100;
            // 
            // colCount
            // 
            colCount.Text = "Count";
            colCount.Width = 55;
            // 
            // colCost
            // 
            colCost.Text = "$__.__";
            colCost.Width = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(3, 46);
            label2.Name = "label2";
            label2.Size = new Size(137, 26);
            label2.TabIndex = 4;
            label2.Text = "Account Info:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(3, 200);
            label1.Name = "label1";
            label1.Size = new Size(173, 26);
            label1.TabIndex = 4;
            label1.Text = "Previous Orders:";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold);
            btnBack.Location = new Point(354, 17);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(88, 29);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.Maroon;
            lblWelcome.Location = new Point(3, 8);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(339, 38);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Welcome, User!";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(3, 331);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(337, 55);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel Order";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrder.Location = new Point(3, 392);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(337, 55);
            btnOrder.TabIndex = 9;
            btnOrder.Text = "Start New Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(234, 284);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(97, 27);
            txtTotal.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(183, 287);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 7;
            label7.Text = "Total:";
            // 
            // lstviewCurOrder
            // 
            lstviewCurOrder.BackColor = Color.AntiqueWhite;
            lstviewCurOrder.Columns.AddRange(new ColumnHeader[] { colCountItem, colNameItem, colAllergy, colPrice });
            lstviewCurOrder.FullRowSelect = true;
            lstviewCurOrder.GridLines = true;
            lstviewCurOrder.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lstviewCurOrder.Location = new Point(3, 37);
            lstviewCurOrder.MultiSelect = false;
            lstviewCurOrder.Name = "lstviewCurOrder";
            lstviewCurOrder.Size = new Size(337, 241);
            lstviewCurOrder.TabIndex = 6;
            lstviewCurOrder.TabStop = false;
            lstviewCurOrder.UseCompatibleStateImageBehavior = false;
            lstviewCurOrder.View = View.Details;
            // 
            // colCountItem
            // 
            colCountItem.Text = "#";
            colCountItem.Width = 30;
            // 
            // colNameItem
            // 
            colNameItem.Text = "Item Name";
            colNameItem.Width = 140;
            // 
            // colAllergy
            // 
            colAllergy.Text = "Allergy";
            colAllergy.Width = 70;
            // 
            // colPrice
            // 
            colPrice.Text = "$__.__";
            colPrice.Width = 55;
            // 
            // lblOrderStatus
            // 
            lblOrderStatus.Font = new Font("Trebuchet MS", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblOrderStatus.Location = new Point(183, 15);
            lblOrderStatus.Name = "lblOrderStatus";
            lblOrderStatus.Size = new Size(157, 18);
            lblOrderStatus.TabIndex = 5;
            lblOrderStatus.Text = "InProgress";
            lblOrderStatus.TextAlign = ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(3, 9);
            label6.Name = "label6";
            label6.Size = new Size(155, 26);
            label6.TabIndex = 4;
            label6.Text = "Current Order:";
            // 
            // CustomerHomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            CancelButton = btnBack;
            ClientSize = new Size(792, 450);
            ControlBox = false;
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CustomerHomeForm";
            Text = "CustomerHomeForm";
            Load += CustomerHomeForm_Load;
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
        private Label lblWelcome;
        private Button btnDetails;
        private ListView lstviewPrevOrders;
        private Label label1;
        private Button btnBack;
        private Button btnReorder;
        private ColumnHeader colOrderNum;
        private ColumnHeader colDateScheduled;
        private ColumnHeader colCount;
        private ColumnHeader colCost;
        private ColumnHeader colDateCreated;
        private Label lblName;
        private Label lblEmail;
        private Label label2;
        private Label lblCreationDate;
        private Button btnDeleteAccount;
        private Button btnEditAccount;
        private ListView lstviewCurOrder;
        private Label lblOrderStatus;
        private Label label6;
        private ColumnHeader colCountItem;
        private ColumnHeader colNameItem;
        private ColumnHeader colAllergy;
        private ColumnHeader colPrice;
        private TextBox txtTotal;
        private Label label7;
        private Button btnOrder;
        private Button btnCancel;
    }
}