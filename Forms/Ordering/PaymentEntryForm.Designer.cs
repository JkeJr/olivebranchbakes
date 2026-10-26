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
            colAllergy = new ColumnHeader();
            colCount = new ColumnHeader();
            colPrice = new ColumnHeader();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(529, 265);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 29);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
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
            btnBack.Location = new Point(346, 263);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 5;
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
            dtpPickup.CustomFormat = "MMM d',' yyyy',' h':00' tt";
            dtpPickup.Format = DateTimePickerFormat.Custom;
            dtpPickup.Location = new Point(407, 231);
            dtpPickup.MinDate = new DateTime(2026, 10, 26, 0, 0, 0, 0);
            dtpPickup.Name = "dtpPickup";
            dtpPickup.Size = new Size(214, 27);
            dtpPickup.TabIndex = 4;
            dtpPickup.Value = new DateTime(2026, 11, 11, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(346, 231);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 6;
            label4.Text = "Pickup:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(346, 67);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 6;
            label5.Text = "First:";
            // 
            // txtNameFirst
            // 
            txtNameFirst.Location = new Point(391, 67);
            txtNameFirst.Name = "txtNameFirst";
            txtNameFirst.Size = new Size(91, 27);
            txtNameFirst.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(488, 67);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 6;
            label6.Text = "Last:";
            // 
            // txtNameLast
            // 
            txtNameLast.Location = new Point(532, 67);
            txtNameLast.Name = "txtNameLast";
            txtNameLast.Size = new Size(91, 27);
            txtNameLast.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(396, 110);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 6;
            label2.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(451, 110);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(170, 27);
            txtEmail.TabIndex = 3;
            // 
            // listviewOrder
            // 
            listviewOrder.Columns.AddRange(new ColumnHeader[] { colGroupName, colAllergy, colCount, colPrice });
            listviewOrder.FullRowSelect = true;
            listviewOrder.GridLines = true;
            listviewOrder.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listviewOrder.Location = new Point(12, 37);
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
            colGroupName.Width = 170;
            // 
            // colAllergy
            // 
            colAllergy.Text = "Allergy";
            // 
            // colCount
            // 
            colCount.Text = "#";
            colCount.TextAlign = HorizontalAlignment.Center;
            colCount.Width = 35;
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
            label7.Location = new Point(346, 37);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 2;
            label7.Text = "Enter Info:";
            // 
            // PaymentEntryForm
            // 
            AcceptButton = btnConfirm;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnBack;
            ClientSize = new Size(633, 305);
            ControlBox = false;
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
    }
}