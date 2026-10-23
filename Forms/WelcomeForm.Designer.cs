namespace OliveBranchBakes
{
    partial class WelcomeForm
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
            lblWelcome = new Label();
            btnLoginGo = new Button();
            btnGuest = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(57, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(677, 52);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to Olive Branch Bakes";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLoginGo
            // 
            btnLoginGo.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginGo.Location = new Point(57, 246);
            btnLoginGo.Name = "btnLoginGo";
            btnLoginGo.Size = new Size(231, 98);
            btnLoginGo.TabIndex = 1;
            btnLoginGo.Text = "Login";
            btnLoginGo.UseVisualStyleBackColor = true;
            btnLoginGo.Click += btnLoginGo_Click;
            // 
            // btnGuest
            // 
            btnGuest.Font = new Font("Trebuchet MS", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuest.Location = new Point(503, 246);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(231, 98);
            btnGuest.TabIndex = 1;
            btnGuest.Text = "Guest";
            btnGuest.UseVisualStyleBackColor = true;
            btnGuest.Click += btnGuest_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(143, 82);
            label1.Name = "label1";
            label1.Size = new Size(500, 36);
            label1.TabIndex = 2;
            label1.Text = "Choose to Login or Continue as a Guest";
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 375);
            Controls.Add(label1);
            Controls.Add(btnGuest);
            Controls.Add(btnLoginGo);
            Controls.Add(lblWelcome);
            Name = "WelcomeForm";
            Text = "Welcome | Olive Branch Bakes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnLoginGo;
        private Button btnGuest;
        private Label label1;
    }
}