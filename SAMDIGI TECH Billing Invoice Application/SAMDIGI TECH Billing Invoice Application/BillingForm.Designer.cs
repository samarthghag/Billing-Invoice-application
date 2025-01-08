namespace SAMDIGI_TECH_Billing_Invoice_Application
{
    partial class BillingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingForm));
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            txtCustomerPhone = new TextBox();
            label5 = new Label();
            txtCustomerID = new TextBox();
            label4 = new Label();
            txtCustomerName = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            txtProductDQuantity = new TextBox();
            txtProductCQuantity = new TextBox();
            txtProductBQuantity = new TextBox();
            txtProductAQuantity = new TextBox();
            groupBox4 = new GroupBox();
            txtProductDTotal = new TextBox();
            txtProductCTotal = new TextBox();
            txtProductBTotal = new TextBox();
            txtProductATotal = new TextBox();
            groupBox5 = new GroupBox();
            txtBoxFianlPrice = new TextBox();
            txtBoxDiscount = new TextBox();
            txtBoxOverallTotal = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PMingLiU-ExtB", 30F, FontStyle.Italic);
            label1.Location = new Point(263, 9);
            label1.Name = "label1";
            label1.Size = new Size(930, 50);
            label1.TabIndex = 0;
            label1.Text = "SAMA DIGI TECH  Billing Invoice Dashborad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("PMingLiU-ExtB", 17F, FontStyle.Italic);
            label2.Location = new Point(270, 59);
            label2.Name = "label2";
            label2.Size = new Size(923, 29);
            label2.TabIndex = 1;
            label2.Text = "*****************************************************************";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.RoyalBlue;
            groupBox1.Controls.Add(txtCustomerPhone);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCustomerID);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(label3);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(12, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(612, 289);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Details";
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Location = new Point(266, 194);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(332, 47);
            txtCustomerPhone.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 197);
            label5.Name = "label5";
            label5.Size = new Size(246, 34);
            label5.TabIndex = 4;
            label5.Text = "Customer Phone :";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(224, 122);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(279, 47);
            txtCustomerID.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 125);
            label4.Name = "label4";
            label4.Size = new Size(200, 34);
            label4.TabIndex = 2;
            label4.Text = "Customer ID :";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(266, 53);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(332, 47);
            txtCustomerName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 56);
            label3.Name = "label3";
            label3.Size = new Size(242, 34);
            label3.TabIndex = 0;
            label3.Text = "Customer Name :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GrayText;
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.ForeColor = SystemColors.Control;
            groupBox2.Location = new Point(641, 100);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(431, 289);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Product";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 225);
            label9.Name = "label9";
            label9.Size = new Size(329, 34);
            label9.TabIndex = 3;
            label9.Text = "4. Social Media(₹1800) ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 165);
            label8.Name = "label8";
            label8.Size = new Size(393, 34);
            label8.TabIndex = 2;
            label8.Text = "3. Graphic Designing(₹1500)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 108);
            label7.Name = "label7";
            label7.Size = new Size(372, 34);
            label7.TabIndex = 1;
            label7.Text = "2. App Devlopment(₹2500)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 56);
            label6.Name = "label6";
            label6.Size = new Size(421, 34);
            label6.TabIndex = 0;
            label6.Text = "1. Website Devlopment(₹1000)";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.AppWorkspace;
            groupBox3.Controls.Add(txtProductDQuantity);
            groupBox3.Controls.Add(txtProductCQuantity);
            groupBox3.Controls.Add(txtProductBQuantity);
            groupBox3.Controls.Add(txtProductAQuantity);
            groupBox3.Location = new Point(1091, 102);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(158, 287);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Quantity";
            // 
            // txtProductDQuantity
            // 
            txtProductDQuantity.Location = new Point(18, 223);
            txtProductDQuantity.Name = "txtProductDQuantity";
            txtProductDQuantity.Size = new Size(125, 47);
            txtProductDQuantity.TabIndex = 3;
            // 
            // txtProductCQuantity
            // 
            txtProductCQuantity.Location = new Point(18, 163);
            txtProductCQuantity.Name = "txtProductCQuantity";
            txtProductCQuantity.Size = new Size(125, 47);
            txtProductCQuantity.TabIndex = 2;
            // 
            // txtProductBQuantity
            // 
            txtProductBQuantity.Location = new Point(18, 109);
            txtProductBQuantity.Name = "txtProductBQuantity";
            txtProductBQuantity.Size = new Size(125, 47);
            txtProductBQuantity.TabIndex = 1;
            // 
            // txtProductAQuantity
            // 
            txtProductAQuantity.Location = new Point(18, 54);
            txtProductAQuantity.Name = "txtProductAQuantity";
            txtProductAQuantity.Size = new Size(125, 47);
            txtProductAQuantity.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.SandyBrown;
            groupBox4.Controls.Add(txtProductDTotal);
            groupBox4.Controls.Add(txtProductCTotal);
            groupBox4.Controls.Add(txtProductBTotal);
            groupBox4.Controls.Add(txtProductATotal);
            groupBox4.ForeColor = SystemColors.ActiveCaptionText;
            groupBox4.Location = new Point(1255, 102);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(184, 287);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Total Price";
            // 
            // txtProductDTotal
            // 
            txtProductDTotal.Location = new Point(32, 223);
            txtProductDTotal.Name = "txtProductDTotal";
            txtProductDTotal.Size = new Size(125, 47);
            txtProductDTotal.TabIndex = 7;
            // 
            // txtProductCTotal
            // 
            txtProductCTotal.Location = new Point(32, 163);
            txtProductCTotal.Name = "txtProductCTotal";
            txtProductCTotal.Size = new Size(125, 47);
            txtProductCTotal.TabIndex = 6;
            // 
            // txtProductBTotal
            // 
            txtProductBTotal.Location = new Point(32, 109);
            txtProductBTotal.Name = "txtProductBTotal";
            txtProductBTotal.Size = new Size(125, 47);
            txtProductBTotal.TabIndex = 5;
            // 
            // txtProductATotal
            // 
            txtProductATotal.Location = new Point(32, 54);
            txtProductATotal.Name = "txtProductATotal";
            txtProductATotal.Size = new Size(125, 47);
            txtProductATotal.TabIndex = 4;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Honeydew;
            groupBox5.Controls.Add(txtBoxFianlPrice);
            groupBox5.Controls.Add(txtBoxDiscount);
            groupBox5.Controls.Add(txtBoxOverallTotal);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(label10);
            groupBox5.ForeColor = Color.DarkBlue;
            groupBox5.Location = new Point(12, 405);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(612, 240);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Overall Summary";
            // 
            // txtBoxFianlPrice
            // 
            txtBoxFianlPrice.Location = new Point(198, 182);
            txtBoxFianlPrice.Name = "txtBoxFianlPrice";
            txtBoxFianlPrice.Size = new Size(328, 47);
            txtBoxFianlPrice.TabIndex = 6;
            // 
            // txtBoxDiscount
            // 
            txtBoxDiscount.Location = new Point(175, 114);
            txtBoxDiscount.Name = "txtBoxDiscount";
            txtBoxDiscount.Size = new Size(328, 47);
            txtBoxDiscount.TabIndex = 5;
            // 
            // txtBoxOverallTotal
            // 
            txtBoxOverallTotal.Location = new Point(230, 50);
            txtBoxOverallTotal.Name = "txtBoxOverallTotal";
            txtBoxOverallTotal.Size = new Size(328, 47);
            txtBoxOverallTotal.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 185);
            label12.Name = "label12";
            label12.Size = new Size(174, 34);
            label12.TabIndex = 3;
            label12.Text = "Final Price :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 117);
            label11.Name = "label11";
            label11.Size = new Size(148, 34);
            label11.TabIndex = 2;
            label11.Text = "Discount :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 53);
            label10.Name = "label10";
            label10.Size = new Size(206, 34);
            label10.TabIndex = 1;
            label10.Text = "Overall Total :";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(864, 477);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(155, 45);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(1035, 477);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(101, 45);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1155, 477);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 45);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // BillingForm
            // 
            AutoScaleDimensions = new SizeF(18F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1451, 649);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("PMingLiU-ExtB", 19.8000011F, FontStyle.Italic);
            Margin = new Padding(7, 5, 7, 5);
            Name = "BillingForm";
            Text = "BillingForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtCustomerPhone;
        private Label label5;
        private TextBox txtCustomerID;
        private Label label4;
        private TextBox txtCustomerName;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label7;
        private GroupBox groupBox3;
        private TextBox txtProductDQuantity;
        private TextBox txtProductCQuantity;
        private TextBox txtProductBQuantity;
        private TextBox txtProductAQuantity;
        private GroupBox groupBox4;
        private TextBox txtProductDTotal;
        private TextBox txtProductCTotal;
        private TextBox txtProductBTotal;
        private TextBox txtProductATotal;
        private GroupBox groupBox5;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox txtBoxOverallTotal;
        private TextBox txtBoxFianlPrice;
        private TextBox txtBoxDiscount;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
    }
}