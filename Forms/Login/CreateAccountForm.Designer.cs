namespace OliveBranchBakes.Forms.Login
{
    partial class CreateAccountForm
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
            txtFirstName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            cmbbEmail = new ComboBox();
            btnCancel = new Button();
            btnEnter = new Button();
            label6 = new Label();
            label7 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 110);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "First:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(57, 107);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(78, 27);
            txtFirstName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 2;
            label2.Text = "Input Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 146);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 0;
            label3.Text = "Last:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(57, 143);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(78, 27);
            txtLastName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(160, 81);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 2;
            label4.Text = "E-Mail:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(160, 107);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(107, 27);
            txtEmail.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 110);
            label5.Name = "label5";
            label5.Size = new Size(23, 20);
            label5.TabIndex = 0;
            label5.Text = "@";
            // 
            // cmbbEmail
            // 
            cmbbEmail.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbbEmail.FormattingEnabled = true;
            cmbbEmail.Items.AddRange(new object[] { "gmail.com", "hotmail.com", "icloud.com", "outlook.com", "yahoo.com" });
            cmbbEmail.Location = new Point(283, 107);
            cmbbEmail.Name = "cmbbEmail";
            cmbbEmail.Size = new Size(92, 28);
            cmbbEmail.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 182);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(77, 29);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(298, 182);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(77, 29);
            btnEnter.TabIndex = 7;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 2;
            label6.Text = "Username:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(160, 9);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 2;
            label7.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(12, 32);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(123, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(160, 32);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(123, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // CreateAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 223);
            ControlBox = false;
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnEnter);
            Controls.Add(btnCancel);
            Controls.Add(cmbbEmail);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CreateAccountForm";
            Text = "CreateAccountForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private Label label2;
        private Label label3;
        private TextBox txtLastName;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private ComboBox cmbbEmail;
        private Button btnCancel;
        private Button btnEnter;
        private Label label6;
        private Label label7;
        private TextBox txtUsername;
        private TextBox txtPassword;
    }
}