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
    }
}
