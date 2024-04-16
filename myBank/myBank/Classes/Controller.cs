using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myBank.Classes
{
    public class Controller
    {
        private List<Customer> customers;
        private List<Account> accounts;

        public Controller()
        {
            customers = new List<Customer>();
            accounts = new List<Account>();
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void DeleteCustomer(Customer customer)
        {
            customers.Remove(customer);
        }

        public void UpdateCustomerListBox(ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (Customer customer in customers)
            {
                // Add Customer objects to the ListBox
                listBox.Items.Add(customer);
            }
        }

        public void AddAccount(int customerId, Account account)
        {
            // Associate the account with the customer by setting its CustomerId property
            // You need to implement the logic to retrieve the customer ID from the selected customer
            // For now, you can directly pass the customer ID from the combo box
            // account.CustomerId = customerId;
            accounts.Add(account);
        }

        // Deposit method
        public void Deposit(int accountId, decimal amount)
        {
            Account account = FindAccountById(accountId);
            if (account != null)
            {
                account.Balance += amount;
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }

        // Withdraw method
        public void Withdraw(int accountId, decimal amount)
        {
            Account account = FindAccountById(accountId);
            if (account != null)
            {
                if (account.Balance >= amount)
                {
                    account.Balance -= amount;
                }
                else
                {
                    Console.WriteLine("Insufficient funds.");
                }
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }

        // Transfer method
        public void Transfer(int sourceAccountId, int destinationAccountId, decimal amount)
        {
            Account sourceAccount = FindAccountById(sourceAccountId);
            Account destinationAccount = FindAccountById(destinationAccountId);
            if (sourceAccount != null && destinationAccount != null)
            {
                if (sourceAccount.Balance >= amount)
                {
                    sourceAccount.Balance -= amount;
                    destinationAccount.Balance += amount;
                }
                else
                {
                    Console.WriteLine("Insufficient funds.");
                }
            }
            else
            {
                Console.WriteLine("Source or destination account not found.");
            }
        }

        private Customer FindCustomerById(int customerId)
        {
            foreach (Customer customer in customers)
            {
                if (customer.CustomerId == customerId)
                {
                    return customer;
                }
            }
            return null;
        }
        private Account FindAccountById(int accountId)
        {
            foreach (Account account in accounts)
            {
                if (account.AccountId == accountId)
                {
                    return account;
                }
            }
            return null;
        }
    }
}
