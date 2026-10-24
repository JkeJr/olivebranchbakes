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
            listView1 = new ListView();
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
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnDetails = new Button();
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
            splitContainer1.Panel1.Controls.Add(button3);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(listView1);
            splitContainer1.Panel1.Controls.Add(btnBack);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(listView2);
            splitContainer1.Panel2.Controls.Add(btnDetails);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 416;
            splitContainer1.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.BackColor = Color.MistyRose;
            listView1.Columns.AddRange(new ColumnHeader[] { colName, colPrice, colAllergens });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(3, 84);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(410, 193);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            colAllergens.Width = 200;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(319, 9);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
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
            listView2.Size = new Size(374, 245);
            listView2.TabIndex = 2;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 0;
            label2.Text = "Active Orders:";
            // 
            // button1
            // 
            button1.Location = new Point(319, 283);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(3, 283);
            button2.Name = "button2";
            button2.Size = new Size(59, 29);
            button2.TabIndex = 3;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(68, 283);
            button3.Name = "button3";
            button3.Size = new Size(59, 29);
            button3.TabIndex = 3;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(258, 283);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(119, 29);
            btnDetails.TabIndex = 3;
            btnDetails.Text = "View Details";
            btnDetails.UseVisualStyleBackColor = true;
            // 
            // AdminConsoleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminConsoleForm";
            Text = "AdminConsoleForm";
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
        private ListView listView1;
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
        private Button button2;
        private Button button1;
        private Button btnDetails;
    }
}