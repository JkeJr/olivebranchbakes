namespace OliveBranchBakes.Forms.Admin
{
    partial class ItemCreateForm
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
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            txtAllergens = new TextBox();
            btnAdd = new Button();
            btnBack = new Button();
            chkSeasonal = new CheckBox();
            dtpStart = new DateTimePicker();
            label4 = new Label();
            dtpEnd = new DateTimePicker();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 15);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(89, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(134, 27);
            txtName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 59);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 0;
            label2.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(89, 56);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(70, 27);
            txtPrice.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 99);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 0;
            label3.Text = "Allergens:";
            // 
            // txtAllergens
            // 
            txtAllergens.Location = new Point(89, 96);
            txtAllergens.Name = "txtAllergens";
            txtAllergens.Size = new Size(133, 27);
            txtAllergens.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(372, 134);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(79, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Enter";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(9, 134);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(74, 29);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // chkSeasonal
            // 
            chkSeasonal.AutoSize = true;
            chkSeasonal.Location = new Point(301, 14);
            chkSeasonal.Name = "chkSeasonal";
            chkSeasonal.Size = new Size(97, 24);
            chkSeasonal.TabIndex = 3;
            chkSeasonal.Text = "Seasonal?";
            chkSeasonal.UseVisualStyleBackColor = true;
            // 
            // dtpStart
            // 
            dtpStart.CustomFormat = "MMMM d";
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.Location = new Point(301, 56);
            dtpStart.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dtpStart.MinDate = new DateTime(2026, 1, 1, 0, 0, 0, 0);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(150, 27);
            dtpStart.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(256, 56);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 7;
            label4.Text = "start";
            // 
            // dtpEnd
            // 
            dtpEnd.CustomFormat = "MMMM d";
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.Location = new Point(301, 94);
            dtpEnd.MaxDate = new DateTime(2027, 12, 31, 0, 0, 0, 0);
            dtpEnd.MinDate = new DateTime(2026, 1, 1, 0, 0, 0, 0);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(150, 27);
            dtpEnd.TabIndex = 5;
            dtpEnd.Value = new DateTime(2026, 10, 26, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(262, 94);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 7;
            label5.Text = "end";
            // 
            // ItemCreateForm
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnBack;
            ClientSize = new Size(462, 175);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(chkSeasonal);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
            Controls.Add(txtAllergens);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ItemCreateForm";
            Text = "ItemCreateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtPrice;
        private Label label3;
        private TextBox txtAllergens;
        private Button btnAdd;
        private Button btnBack;
        private CheckBox chkSeasonal;
        private DateTimePicker dtpStart;
        private Label label4;
        private DateTimePicker dtpEnd;
        private Label label5;
    }
}