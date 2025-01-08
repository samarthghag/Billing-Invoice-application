namespace SAMDIGI_TECH_Billing_Invoice_Application
{
    partial class Form1
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
            label1 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            txtPhoneNumber = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(162, 34);
            label1.TabIndex = 0;
            label1.Text = "Username :";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(180, 25);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(328, 47);
            txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(155, 34);
            label2.TabIndex = 2;
            label2.Text = "Password :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(173, 94);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(335, 47);
            txtPassword.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 165);
            label3.Name = "label3";
            label3.Size = new Size(227, 34);
            label3.TabIndex = 4;
            label3.Text = "Phone Number :";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(245, 162);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(263, 47);
            txtPhoneNumber.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(203, 239);
            button1.Name = "button1";
            button1.Size = new Size(133, 53);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(512, 304);
            Controls.Add(button1);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Font = new Font("PMingLiU-ExtB", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 5, 7, 5);
            Name = "Form1";
            Text = "Billing Invoice Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private Label label2;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtPhoneNumber;
        private Button button1;
    }
}
