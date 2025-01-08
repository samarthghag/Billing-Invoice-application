namespace SAMDIGI_TECH_Billing_Invoice_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Input validation
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter your username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter your password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || !long.TryParse(txtPhoneNumber.Text, out _))
            {
                MessageBox.Show("Please enter a valid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Navigate to Billing Invoice Form
            string username = txtUsername.Text;
            string phoneNumber = txtPhoneNumber.Text;

            BillingForm billingForm = new BillingForm(username, phoneNumber);
            billingForm.Show();
            this.Hide();
        }
    }
}
