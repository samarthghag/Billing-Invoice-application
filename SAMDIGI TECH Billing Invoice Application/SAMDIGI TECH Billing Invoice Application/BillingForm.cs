using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMDIGI_TECH_Billing_Invoice_Application
{
    public partial class BillingForm : Form
    {
        private string username;
        private string phoneNumber;
        public BillingForm(string username, string phoneNumber)
        {
            InitializeComponent();
            this.username = username;
            this.phoneNumber = phoneNumber;

            // Initialize customer details
            txtCustomerName.Text = username;
            txtCustomerPhone.Text = phoneNumber;
            txtCustomerID.Text = "CUST" + new Random().Next(1000, 9999);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCustomerName.Text) || string.IsNullOrWhiteSpace(txtCustomerPhone.Text))
                {
                    MessageBox.Show("Customer details are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Product Prices
                int priceA = 1000, priceB = 2500, priceC = 1500, priceD = 1800;

                // Quantities from TextBoxes
                int quantityA = ValidateQuantity(txtProductAQuantity.Text);
                int quantityB = ValidateQuantity(txtProductBQuantity.Text);
                int quantityC = ValidateQuantity(txtProductCQuantity.Text);
                int quantityD = ValidateQuantity(txtProductDQuantity.Text);

                // Calculate Total Prices
                int totalPriceA = quantityA * priceA;
                int totalPriceB = quantityB * priceB;
                int totalPriceC = quantityC * priceC;
                int totalPriceD = quantityD * priceD;

                // Display Total Prices
                txtProductATotal.Text = totalPriceA.ToString();
                txtProductBTotal.Text = totalPriceB.ToString();
                txtProductCTotal.Text = totalPriceC.ToString();
                txtProductDTotal.Text = totalPriceD.ToString();

                // Calculate Overall Total
                int overallTotal = totalPriceA + totalPriceB + totalPriceC + totalPriceD;
                txtBoxOverallTotal.Text = overallTotal.ToString();

                // Apply Discount
                double discount = CalculateDiscount(overallTotal);
                int finalPrice = (int)(overallTotal - (overallTotal * discount));
                txtBoxDiscount.Text = $"{discount * 100}%";
                txtBoxFianlPrice.Text = finalPrice.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CalculateDiscount(int overallTotal)
        {
            if (overallTotal > 20000) return 0.20;
            if (overallTotal > 15000) return 0.15;
            if (overallTotal > 10000) return 0.10;
            if (overallTotal >= 5000) return 0.05;
            return 0;
        }

        private int ValidateQuantity(string text)
        {
            // Display Total Prices
            txtProductATotal.Text = txtProductATotal.ToString();
            txtProductBTotal.Text = txtProductBTotal.ToString();
            txtProductCTotal.Text = txtProductCTotal.ToString();
            txtProductDTotal.Text = txtProductDTotal.ToString();
            return string.IsNullOrWhiteSpace(text) ? 0 : int.Parse(text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtCustomerID.Clear();
            txtCustomerPhone.Clear();
            txtProductAQuantity.Clear();
            txtProductBQuantity.Clear();
            txtProductCQuantity.Clear();
            txtProductDQuantity.Clear();
            txtProductATotal.Clear();
            txtProductBTotal.Clear();
            txtProductCTotal.Clear();
            txtProductDTotal.Clear();
            txtBoxOverallTotal.Clear();
            txtBoxFianlPrice.Text = "0%";
            txtBoxFianlPrice.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
