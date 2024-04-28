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
    public partial class Main : Form
    {
        private Controller controller;
        private List<Customer> customers;

        public Main()
        {
            InitializeComponent();
            controller = new Controller();
            customers = new List<Customer>();

            controller.UpdateCustomerListBox(listBoxCustomers);
            PopulateCustomerComboBox();

        }



        private void ShowAddCustomerForm(Controller controller, List<Customer> customers)
        {
            panelShowCustomer.Controls.Clear();
            AddCustomerForm addCustomerForm = new AddCustomerForm(controller, customers);
            addCustomerForm.TopLevel = false;
            addCustomerForm.FormBorderStyle = FormBorderStyle.None;
            panelShowCustomer.Controls.Add(addCustomerForm);
            addCustomerForm.Dock = DockStyle.Fill;
            addCustomerForm.Show();
        }

        private void ShowEditCustomerForm()
        {
            if (listBoxCustomers.SelectedItem != null)
            {
                panelShowCustomer.Controls.Clear();
                Customer selectedCustomer = (Customer)listBoxCustomers.SelectedItem;
                EditCustomerForm editCustomerForm = new EditCustomerForm(controller, selectedCustomer, listBoxCustomers);
                editCustomerForm.TopLevel = false;
                editCustomerForm.FormBorderStyle = FormBorderStyle.None;
                panelShowCustomer.Controls.Add(editCustomerForm);
                editCustomerForm.Dock = DockStyle.Fill;
                editCustomerForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a customer to edit.");
            }
        }



        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            // Check if a customer is selected
            if (listBoxCustomers.SelectedItem != null)
            {
                // Call the ShowEditCustomerForm method
                ShowEditCustomerForm();
            }
            else
            {
                MessageBox.Show("Please select a customer to edit.");
            }
        }

        private void ShowDeleteCustomerForm()
        {
            panelShowCustomer.Controls.Clear();
            DeleteCustomerForm deleteCustomerForm = new DeleteCustomerForm(controller, listBoxCustomers);
            deleteCustomerForm.TopLevel = false;
            deleteCustomerForm.FormBorderStyle = FormBorderStyle.None;
            panelShowCustomer.Controls.Add(deleteCustomerForm);
            deleteCustomerForm.Dock = DockStyle.Fill;
            deleteCustomerForm.Show();
        }



        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            // Show the AddCustomerForm
            AddCustomerForm addCustomerForm = new AddCustomerForm(controller, customers);
            addCustomerForm.Show();

            // Update the customer listBox after the form is closed
            addCustomerForm.FormClosed += (s, ev) =>
            {
                controller.UpdateCustomerListBox(listBoxCustomers);
            };
        }




        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            ShowDeleteCustomerForm();
        }

        private void btnQuitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void PopulateCustomerComboBox()
        {
            // Get the list of customers from the controller
            List<Customer> customers = controller.GetCustomers();

            // Set the data source of the combo box to the list of customers
            comboDisplayCustomers.DataSource = customers;

            // Set the display member to specify which property of the Customer class to display
            comboDisplayCustomers.DisplayMember = "Name";
        }




        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (comboDisplayCustomers.SelectedItem != null)
            {
                Customer selectedCustomer = (Customer)comboDisplayCustomers.SelectedItem;
                AddAccountForm addAccountForm = new AddAccountForm(selectedCustomer);

                // Subscribe to the AccountAdded event
                addAccountForm.AccountAdded += AddAccountForm_AccountAdded;

                addAccountForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a customer first.");
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void PopulateSelectedAccountComboBox(int customerId)
        {
            // Clear the combo box
            comboSelectedAccount.Items.Clear();

            // Get the list of accounts for the selected customer ID
            List<Account> customerAccounts = controller.GetAccountsByCustomerId(customerId);

            // Add each account's details to the combo box
            foreach (Account account in customerAccounts)
            {
                string accountDetails = $"Account Number: {account.AccountId}, Type: {account.GetType().Name}";
                comboSelectedAccount.Items.Add(accountDetails);
            }
        }


        private void AddAccountForm_AccountAdded(object sender, EventArgs e)
        {
            // Get the selected customer
            Customer selectedCustomer = (Customer)comboDisplayCustomers.SelectedItem;

            // Repopulate the combo box of accounts for the selected customer
            PopulateSelectedAccountComboBox(selectedCustomer.CustomerId);
        }


    }
}
