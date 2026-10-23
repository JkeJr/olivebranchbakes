namespace OliveBranchBakes
{
    partial class OliveBranchBakesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OliveBranchBakesForm));
            lblProjectName = new Label();
            lblName = new Label();
            lblPhase = new Label();
            lblClassNameNum = new Label();
            lblDate = new Label();
            lblDescription = new Label();
            txtProjectName = new TextBox();
            txtName = new TextBox();
            txtPhase = new TextBox();
            txtClassNameNum = new TextBox();
            rtxtDescription = new RichTextBox();
            dateTime = new DateTimePicker();
            SuspendLayout();
            // 
            // lblProjectName
            // 
            lblProjectName.Location = new Point(12, 24);
            lblProjectName.Name = "lblProjectName";
            lblProjectName.Size = new Size(134, 25);
            lblProjectName.TabIndex = 0;
            lblProjectName.Text = "Project Name:";
            lblProjectName.TextAlign = ContentAlignment.TopRight;
            // 
            // lblName
            // 
            lblName.Location = new Point(12, 75);
            lblName.Name = "lblName";
            lblName.Size = new Size(134, 25);
            lblName.TabIndex = 1;
            lblName.Text = "My Name:";
            lblName.TextAlign = ContentAlignment.TopRight;
            // 
            // lblPhase
            // 
            lblPhase.Location = new Point(12, 128);
            lblPhase.Name = "lblPhase";
            lblPhase.Size = new Size(134, 25);
            lblPhase.TabIndex = 2;
            lblPhase.Text = "Current Phase:";
            lblPhase.TextAlign = ContentAlignment.TopRight;
            // 
            // lblClassNameNum
            // 
            lblClassNameNum.Location = new Point(12, 179);
            lblClassNameNum.Name = "lblClassNameNum";
            lblClassNameNum.Size = new Size(134, 25);
            lblClassNameNum.TabIndex = 3;
            lblClassNameNum.Text = "Class Name and #:";
            lblClassNameNum.TextAlign = ContentAlignment.TopRight;
            // 
            // lblDate
            // 
            lblDate.Location = new Point(12, 230);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(134, 25);
            lblDate.TabIndex = 4;
            lblDate.Text = "Date:";
            lblDate.TextAlign = ContentAlignment.TopRight;
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(12, 285);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(134, 25);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Desctiption:";
            lblDescription.TextAlign = ContentAlignment.TopRight;
            // 
            // txtProjectName
            // 
            txtProjectName.Enabled = false;
            txtProjectName.Location = new Point(183, 24);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.ReadOnly = true;
            txtProjectName.Size = new Size(272, 27);
            txtProjectName.TabIndex = 6;
            txtProjectName.Text = "Olive Branch Bakes";
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(183, 75);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(272, 27);
            txtName.TabIndex = 6;
            txtName.Text = "Jacob Payes";
            // 
            // txtPhase
            // 
            txtPhase.Enabled = false;
            txtPhase.Location = new Point(183, 128);
            txtPhase.Name = "txtPhase";
            txtPhase.ReadOnly = true;
            txtPhase.Size = new Size(272, 27);
            txtPhase.TabIndex = 6;
            txtPhase.Text = "Phase 1: Requirements & Scope";
            // 
            // txtClassNameNum
            // 
            txtClassNameNum.Enabled = false;
            txtClassNameNum.Location = new Point(183, 179);
            txtClassNameNum.Name = "txtClassNameNum";
            txtClassNameNum.ReadOnly = true;
            txtClassNameNum.Size = new Size(272, 27);
            txtClassNameNum.TabIndex = 6;
            txtClassNameNum.Text = "CS3388 Object Oriented Programming";
            // 
            // rtxtDescription
            // 
            rtxtDescription.Enabled = false;
            rtxtDescription.Location = new Point(183, 285);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.ReadOnly = true;
            rtxtDescription.Size = new Size(581, 136);
            rtxtDescription.TabIndex = 7;
            rtxtDescription.Text = resources.GetString("rtxtDescription.Text");
            // 
            // dateTime
            // 
            dateTime.Enabled = false;
            dateTime.Location = new Point(183, 230);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(272, 27);
            dateTime.TabIndex = 8;
            dateTime.Value = new DateTime(2026, 9, 29, 0, 0, 0, 0);
            // 
            // OliveBranchBakesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTime);
            Controls.Add(rtxtDescription);
            Controls.Add(txtClassNameNum);
            Controls.Add(txtPhase);
            Controls.Add(txtName);
            Controls.Add(txtProjectName);
            Controls.Add(lblDescription);
            Controls.Add(lblDate);
            Controls.Add(lblClassNameNum);
            Controls.Add(lblPhase);
            Controls.Add(lblName);
            Controls.Add(lblProjectName);
            Name = "OliveBranchBakesForm";
            Text = "Olive Branch Bakes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProjectName;
        private Label lblName;
        private Label lblPhase;
        private Label lblClassNameNum;
        private Label lblDate;
        private Label lblDescription;
        private TextBox txtProjectName;
        private TextBox txtName;
        private TextBox txtPhase;
        private TextBox txtClassNameNum;
        private RichTextBox rtxtDescription;
        private DateTimePicker dateTime;
    }
}
