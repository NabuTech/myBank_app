using myBank.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace myBank
{
    public partial class AddCustomerForm : Form
    {
        private Controller controller;
        private List<Customer> customers;

        public AddCustomerForm(Controller controller, List<Customer> customers)
        {
            InitializeComponent();
            this.controller = controller;
            this.customers = customers;
        }

        private void btnConfirmAddCustomer_Click(object sender, EventArgs e)
        {
            // Retrieve the values from the text boxes and checkbox
            string name = txtName.Text;
            string contactDetails = txtContactDetails.Text;
            bool isStaff = checkBoxIsStaff.Checked;

            // Check if the name and contact details are not empty
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(contactDetails))
            {
                MessageBox.Show("Name and contact details cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new customer instance
            Customer newCustomer = new Customer(name, contactDetails, isStaff);

            // Add the new customer to the list
            controller.AddCustomer(newCustomer);

            // Close the form
            this.Close();
        }

        // Method to get the next available customer ID
        private int GetNextCustomerId()
        {
            // Get the maximum customer ID from the existing customers and add 1
            int maxId = customers.Max(c => c.CustomerId);
            return maxId + 1;
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelConfirmCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
