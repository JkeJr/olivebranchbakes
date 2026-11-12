namespace OliveBranchBakes.Forms.Payment
{
    partial class PaymentEntryForm
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
            btnConfirm = new Button();
            label1 = new Label();
            btnBack = new Button();
            txtPriceTotal = new TextBox();
            label3 = new Label();
            listviewPricing = new ListView();
            columnHeader1 = new ColumnHeader();
            colName = new ColumnHeader();
            colAmount = new ColumnHeader();
            dtpPickup = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            txtNameFirst = new TextBox();
            label6 = new Label();
            txtNameLast = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            listviewOrder = new ListView();
            colGroupName = new ColumnHeader();
            colCount = new ColumnHeader();
            colAllergy = new ColumnHeader();
            colPrice = new ColumnHeader();
            label7 = new Label();
            label8 = new Label();
            cmmbEmail = new ComboBox();
            rtbComments = new RichTextBox();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(590, 264);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 29);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 2;
            label1.Text = "Confirm Order:";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(346, 265);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // txtPriceTotal
            // 
            txtPriceTotal.Location = new Point(246, 265);
            txtPriceTotal.Name = "txtPriceTotal";
            txtPriceTotal.ReadOnly = true;
            txtPriceTotal.Size = new Size(94, 27);
            txtPriceTotal.TabIndex = 0;
            txtPriceTotal.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(195, 264);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 6;
            label3.Text = "Total:";
            // 
            // listviewPricing
            // 
            listviewPricing.Columns.AddRange(new ColumnHeader[] { columnHeader1, colName, colAmount });
            listviewPricing.FullRowSelect = true;
            listviewPricing.GridLines = true;
            listviewPricing.HeaderStyle = ColumnHeaderStyle.None;
            listviewPricing.Location = new Point(12, 187);
            listviewPricing.MultiSelect = false;
            listviewPricing.Name = "listviewPricing";
            listviewPricing.Scrollable = false;
            listviewPricing.Size = new Size(328, 74);
            listviewPricing.TabIndex = 7;
            listviewPricing.TabStop = false;
            listviewPricing.UseCompatibleStateImageBehavior = false;
            listviewPricing.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 150;
            // 
            // colName
            // 
            colName.Text = "Name";
            colName.TextAlign = HorizontalAlignment.Right;
            colName.Width = 100;
            // 
            // colAmount
            // 
            colAmount.Text = "Amount";
            colAmount.Width = 75;
            // 
            // dtpPickup
            // 
            dtpPickup.Checked = false;
            dtpPickup.CustomFormat = "MMM d',' yyyy',' h':00' tt";
            dtpPickup.Format = DateTimePickerFormat.Custom;
            dtpPickup.Location = new Point(495, 231);
            dtpPickup.MinDate = new DateTime(2026, 10, 26, 0, 0, 0, 0);
            dtpPickup.Name = "dtpPickup";
            dtpPickup.Size = new Size(189, 27);
            dtpPickup.TabIndex = 3;
            dtpPickup.Value = new DateTime(2026, 11, 8, 0, 0, 0, 0);
            dtpPickup.ValueChanged += dtpPickup_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(434, 231);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 6;
            label4.Text = "Pickup:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(362, 40);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 6;
            label5.Text = "First:";
            // 
            // txtNameFirst
            // 
            txtNameFirst.Location = new Point(407, 37);
            txtNameFirst.Name = "txtNameFirst";
            txtNameFirst.Size = new Size(113, 27);
            txtNameFirst.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(527, 40);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 6;
            label6.Text = "Last:";
            // 
            // txtNameLast
            // 
            txtNameLast.Location = new Point(571, 37);
            txtNameLast.Name = "txtNameLast";
            txtNameLast.Size = new Size(113, 27);
            txtNameLast.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(352, 83);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 6;
            label2.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(407, 80);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(145, 27);
            txtEmail.TabIndex = 2;
            // 
            // listviewOrder
            // 
            listviewOrder.Columns.AddRange(new ColumnHeader[] { colGroupName, colCount, colAllergy, colPrice });
            listviewOrder.FullRowSelect = true;
            listviewOrder.GridLines = true;
            listviewOrder.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listviewOrder.Location = new Point(12, 37);
            listviewOrder.MultiSelect = false;
            listviewOrder.Name = "listviewOrder";
            listviewOrder.Size = new Size(328, 144);
            listviewOrder.TabIndex = 11;
            listviewOrder.TabStop = false;
            listviewOrder.UseCompatibleStateImageBehavior = false;
            listviewOrder.View = View.Details;
            // 
            // colGroupName
            // 
            colGroupName.Text = "Name";
            colGroupName.Width = 140;
            // 
            // colCount
            // 
            colCount.Text = "#";
            colCount.TextAlign = HorizontalAlignment.Center;
            colCount.Width = 35;
            // 
            // colAllergy
            // 
            colAllergy.Text = "Allergy";
            // 
            // colPrice
            // 
            colPrice.Text = "$__.__";
            colPrice.Width = 58;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(346, 14);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 2;
            label7.Text = "Enter Info:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(552, 83);
            label8.Name = "label8";
            label8.Size = new Size(23, 20);
            label8.TabIndex = 12;
            label8.Text = "@";
            // 
            // cmmbEmail
            // 
            cmmbEmail.DropDownStyle = ComboBoxStyle.DropDownList;
            cmmbEmail.FormattingEnabled = true;
            cmmbEmail.Items.AddRange(new object[] { "gmail.com", "hotmail.com", "icloud.com", "outlook.com", "yahoo.com" });
            cmmbEmail.Location = new Point(571, 80);
            cmmbEmail.Name = "cmmbEmail";
            cmmbEmail.Size = new Size(113, 28);
            cmmbEmail.TabIndex = 13;
            // 
            // rtbComments
            // 
            rtbComments.Location = new Point(346, 113);
            rtbComments.Name = "rtbComments";
            rtbComments.ReadOnly = true;
            rtbComments.Size = new Size(338, 112);
            rtbComments.TabIndex = 14;
            rtbComments.TabStop = false;
            rtbComments.Text = "";
            // 
            // PaymentEntryForm
            // 
            AcceptButton = btnConfirm;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnBack;
            ClientSize = new Size(686, 305);
            ControlBox = false;
            Controls.Add(rtbComments);
            Controls.Add(cmmbEmail);
            Controls.Add(label8);
            Controls.Add(listviewOrder);
            Controls.Add(txtNameLast);
            Controls.Add(txtEmail);
            Controls.Add(txtNameFirst);
            Controls.Add(dtpPickup);
            Controls.Add(listviewPricing);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPriceTotal);
            Controls.Add(btnBack);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(btnConfirm);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PaymentEntryForm";
            Text = "PaymentEntryForm";
            Load += PaymentEntryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirm;
        private ListView listviewOrder;
        private Label label1;
        private Button btnBack;
        private TextBox txtPriceTotal;
        private Label label3;
        private ListView listviewPricing;
        private DateTimePicker dtpPickup;
        private Label label4;
        private Label label5;
        private TextBox txtNameFirst;
        private Label label6;
        private TextBox txtNameLast;
        private Label label2;
        private TextBox txtEmail;
        private ColumnHeader columnHeader1;
        private ColumnHeader colName;
        private ColumnHeader colAmount;
        private ColumnHeader colGroupName;
        private ColumnHeader colAllergy;
        private ColumnHeader colCount;
        private ColumnHeader colPrice;
        private Label label7;
        private Label label8;
        private ComboBox cmmbEmail;
        private RichTextBox rtbComments;
    }
}