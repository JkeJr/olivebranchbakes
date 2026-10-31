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
            lbAllergens = new ListBox();
            btnAddAllergy = new Button();
            btnRemoveAllergy = new Button();
            lbCategories = new ListBox();
            btnClearCategories = new Button();
            label6 = new Label();
            btnRemoveCategory = new Button();
            btnAddCategory = new Button();
            txtCategories = new TextBox();
            btnClearAllergies = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(70, 11);
            txtName.Name = "txtName";
            txtName.Size = new Size(153, 27);
            txtName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 59);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 0;
            label2.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(72, 56);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(70, 27);
            txtPrice.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 133);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 0;
            label3.Text = "Allergens:";
            // 
            // txtAllergens
            // 
            txtAllergens.Location = new Point(9, 344);
            txtAllergens.Name = "txtAllergens";
            txtAllergens.ReadOnly = true;
            txtAllergens.Size = new Size(214, 27);
            txtAllergens.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(371, 377);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(79, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Enter";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(9, 377);
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
            chkSeasonal.CheckedChanged += chkSeasonal_CheckedChanged;
            // 
            // dtpStart
            // 
            dtpStart.CustomFormat = "MMMM d";
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.Location = new Point(301, 56);
            dtpStart.MaxDate = new DateTime(2026, 10, 26, 0, 0, 0, 0);
            dtpStart.MinDate = new DateTime(2026, 1, 1, 0, 0, 0, 0);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(150, 27);
            dtpStart.TabIndex = 4;
            dtpStart.Value = new DateTime(2026, 10, 26, 0, 0, 0, 0);
            dtpStart.ValueChanged += dtpStart_ValueChanged;
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
            dtpEnd.MinDate = new DateTime(2026, 10, 25, 0, 0, 0, 0);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(150, 27);
            dtpEnd.TabIndex = 5;
            dtpEnd.Value = new DateTime(2026, 10, 26, 0, 0, 0, 0);
            dtpEnd.ValueChanged += dtpEnd_ValueChanged;
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
            // lbAllergens
            // 
            lbAllergens.FormattingEnabled = true;
            lbAllergens.Items.AddRange(new object[] { "Wheat", "Milk", "etc.." });
            lbAllergens.Location = new Point(12, 156);
            lbAllergens.Name = "lbAllergens";
            lbAllergens.Size = new Size(130, 184);
            lbAllergens.TabIndex = 8;
            // 
            // btnAddAllergy
            // 
            btnAddAllergy.Location = new Point(148, 281);
            btnAddAllergy.Name = "btnAddAllergy";
            btnAddAllergy.Size = new Size(75, 57);
            btnAddAllergy.TabIndex = 9;
            btnAddAllergy.Text = "Add";
            btnAddAllergy.UseVisualStyleBackColor = true;
            btnAddAllergy.Click += btnAddAllergy_Click;
            // 
            // btnRemoveAllergy
            // 
            btnRemoveAllergy.Location = new Point(148, 191);
            btnRemoveAllergy.Name = "btnRemoveAllergy";
            btnRemoveAllergy.Size = new Size(75, 29);
            btnRemoveAllergy.TabIndex = 11;
            btnRemoveAllergy.Text = "Remove";
            btnRemoveAllergy.UseVisualStyleBackColor = true;
            btnRemoveAllergy.Click += btnRemoveAllergy_Click;
            // 
            // lbCategories
            // 
            lbCategories.FormattingEnabled = true;
            lbCategories.Items.AddRange(new object[] { "Cake", "Cookie", "etc.." });
            lbCategories.Location = new Point(239, 156);
            lbCategories.Name = "lbCategories";
            lbCategories.Size = new Size(130, 184);
            lbCategories.TabIndex = 12;
            // 
            // btnClearCategories
            // 
            btnClearCategories.Location = new Point(375, 156);
            btnClearCategories.Name = "btnClearCategories";
            btnClearCategories.Size = new Size(75, 29);
            btnClearCategories.TabIndex = 13;
            btnClearCategories.Text = "Clear";
            btnClearCategories.UseVisualStyleBackColor = true;
            btnClearCategories.Click += btnClearCategories_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(239, 133);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 0;
            label6.Text = "Categories:";
            // 
            // btnRemoveCategory
            // 
            btnRemoveCategory.Location = new Point(375, 191);
            btnRemoveCategory.Name = "btnRemoveCategory";
            btnRemoveCategory.Size = new Size(75, 29);
            btnRemoveCategory.TabIndex = 14;
            btnRemoveCategory.Text = "Remove";
            btnRemoveCategory.UseVisualStyleBackColor = true;
            btnRemoveCategory.Click += btnRemoveCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(375, 281);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(75, 57);
            btnAddCategory.TabIndex = 15;
            btnAddCategory.Text = "Add";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // txtCategories
            // 
            txtCategories.Location = new Point(239, 346);
            txtCategories.Name = "txtCategories";
            txtCategories.ReadOnly = true;
            txtCategories.Size = new Size(211, 27);
            txtCategories.TabIndex = 16;
            // 
            // btnClearAllergies
            // 
            btnClearAllergies.Location = new Point(148, 156);
            btnClearAllergies.Name = "btnClearAllergies";
            btnClearAllergies.Size = new Size(75, 29);
            btnClearAllergies.TabIndex = 17;
            btnClearAllergies.Text = "Clear";
            btnClearAllergies.UseVisualStyleBackColor = true;
            btnClearAllergies.Click += btnClearAllergies_Click;
            // 
            // ItemCreateForm
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnBack;
            ClientSize = new Size(462, 418);
            ControlBox = false;
            Controls.Add(btnClearAllergies);
            Controls.Add(txtCategories);
            Controls.Add(btnAddCategory);
            Controls.Add(btnRemoveCategory);
            Controls.Add(btnClearCategories);
            Controls.Add(lbCategories);
            Controls.Add(btnRemoveAllergy);
            Controls.Add(btnAddAllergy);
            Controls.Add(lbAllergens);
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
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ItemCreateForm";
            Text = "ItemCreateForm";
            Load += ItemCreateForm_Load;
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
        private ListBox lbAllergens;
        private Button btnAddAllergy;
        private Button button1;
        private Button btnRemoveAllergy;
        private ListBox lbCategories;
        private Button btnClearCategories;
        private Label label6;
        private Button btnRemoveCategory;
        private Button btnAddCategory;
        private TextBox txtCategories;
        private Button btnClearAllergies;
    }
}