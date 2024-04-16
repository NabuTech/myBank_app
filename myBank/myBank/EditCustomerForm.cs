using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myBank.Classes;

namespace myBank
{
    public partial class EditCustomerForm : Form
    {
        private Controller controller;
        private Customer selectedCustomer;
        private ListBox listBoxCustomers;

        public EditCustomerForm(Controller controller, Customer selectedCustomer, ListBox listBoxCustomers)
        {
            InitializeComponent();
            this.controller = controller;
            this.selectedCustomer = selectedCustomer;
            this.listBoxCustomers = listBoxCustomers;
            PopulateForm();
        }

        private void PopulateForm()
        {
            // Populate the form with the selected customer's details
            txtCustomerID.Text = selectedCustomer.CustomerId.ToString();
            txtEditName.Text = selectedCustomer.Name;
            txtEditContactDetails.Text = selectedCustomer.ContactDetails;
            checkBoxIsStaff.Checked = selectedCustomer.IsStaff;
        }

        private void btnConfirmEditCustomer_Click(object sender, EventArgs e)
        {
            // Update the selected customer's details
            selectedCustomer.Name = txtEditName.Text;
            selectedCustomer.ContactDetails = txtEditContactDetails.Text;
            selectedCustomer.IsStaff = checkBoxIsStaff.Checked;

            // Call the method in the controller to update the list box
            controller.UpdateCustomerListBox(listBoxCustomers);

            // Close the form
            this.Close();
        }

        private void btnCancelEditCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
