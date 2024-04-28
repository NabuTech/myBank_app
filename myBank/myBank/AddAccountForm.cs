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
    public enum AccountType
    {
        Everyday,
        Investment,
        Omni
    }
    public partial class AddAccountForm : Form
    {
        public event EventHandler AccountAdded;
        private readonly Customer selectedCustomer;

        public AddAccountForm(Customer customer)
        {
            InitializeComponent();
            selectedCustomer = customer; // Assign the parameter to the field
            Console.WriteLine("Customer ID received: " + customer.CustomerId); // Debug statement
            Console.WriteLine("Customer Name received: " + customer.Name); // Debug statement
        }


        private void btnConfirmAddAccount_Click(object sender, EventArgs e)
        {
            if (selectedCustomer != null)
            {
                // Check if an account type is selected
                if (radioEveryday.Checked || radioInvestment.Checked || radioOmni.Checked)
                {
                    // Parse the selected account type
                    AccountType accountType = AccountType.Everyday;
                    if (radioInvestment.Checked)
                        accountType = AccountType.Investment;
                    else if (radioOmni.Checked)
                        accountType = AccountType.Omni;

                    // Parse the starting balance
                    if (decimal.TryParse(txtDepositBalance.Text, out decimal initialBalance))
                    {
                        // Create a new account based on the selected account type
                        Account newAccount = null;
                        switch (accountType)
                        {
                            case AccountType.Everyday:
                                newAccount = new EverydayAccount(0, selectedCustomer.CustomerId, initialBalance);
                                break;
                            case AccountType.Investment:
                                newAccount = new InvestmentAccount(0, selectedCustomer.CustomerId, initialBalance);
                                break;
                            case AccountType.Omni:
                                newAccount = new OmniAccount(0, selectedCustomer.CustomerId, initialBalance);
                                break;
                        }

                        OnAccountAdded(EventArgs.Empty);

                        // Close the AddAccountForm
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid initial balance. Please enter a valid number.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select an account type.");
                }
            }
            else
            {
                MessageBox.Show("No customer selected.");
            }
        }


        private void AddAccountForm_Load(object sender, EventArgs e)
        {
            if (selectedCustomer != null)
            {
                txtCustomerId.Text = selectedCustomer.CustomerId.ToString();
            }
        }

        // Method to raise the AccountAdded event
        protected virtual void OnAccountAdded(EventArgs e)
        {
            AccountAdded?.Invoke(this, e);
        }
    }
}
