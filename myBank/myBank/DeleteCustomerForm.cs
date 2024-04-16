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
    public partial class DeleteCustomerForm : Form
    {
        private Controller controller;
        private ListBox listBoxCustomers;

        public DeleteCustomerForm(Controller controller, ListBox listBoxCustomers)
        {
            InitializeComponent();
            this.controller = controller;
            this.listBoxCustomers = listBoxCustomers;
        }

        private void DeleteCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (listBoxCustomers.SelectedItem != null)
            {
                Customer selectedCustomer = (Customer)listBoxCustomers.SelectedItem;
                controller.DeleteCustomer(selectedCustomer);
                controller.UpdateCustomerListBox(listBoxCustomers);
                MessageBox.Show("Customer deleted successfully.");
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }

            this.Close();
        }
    }
}
