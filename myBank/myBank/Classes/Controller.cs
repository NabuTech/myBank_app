using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace myBank.Classes
{
    public class Controller
    {
        private List<Customer> customers;
        private string customersFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "customers.json");
   
        public event EventHandler CustomersChanged;

        public Controller()
        {
            customers = new List<Customer>();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            try
            {
                string json = File.ReadAllText(customersFilePath);
                customers = JsonSerializer.Deserialize<List<Customer>>(json);
                Console.WriteLine("Customers loaded from JSON file.");

                foreach (var customer in customers)
                {
                    customer.Accounts = LoadAccountsForCustomer(customer.CustomerId);
                }
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("Customers JSON file not found. No customers loaded.");
            }
        }

        private List<Account> LoadAccountsForCustomer(int customerId)
        {
            List<Account> customerAccounts = new List<Account>();

            try
            {
                // Read the JSON file containing accounts
                string accountsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "accounts.json");
                string json = File.ReadAllText(accountsFilePath);

                // Deserialize the JSON into a list of accounts
                List<Account> allAccounts = JsonSerializer.Deserialize<List<Account>>(json);

                // Iterate through all accounts
                foreach (var account in allAccounts)
                {
                    // Check if the account's CustomerId matches the provided customer ID
                    if (account.CustomerId == customerId)
                    {
                        // Add the account to the list of accounts associated with the customer
                        customerAccounts.Add(account);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Accounts JSON file not found.");
            }

            return customerAccounts;
        }


        private void SaveCustomers()
        {
            string json = JsonSerializer.Serialize(customers);
            File.WriteAllText(customersFilePath, json);
            Console.WriteLine("Customers saved to JSON file.");
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
            SaveCustomers();
            Console.WriteLine("Customer added: " + customer.Name);
        }

        public void DeleteCustomer(Customer customer)
        {
            customers.Remove(customer);
            SaveCustomers();
            Console.WriteLine("Customer deleted: " + customer.Name);
        }

        public void UpdateCustomerListBox(ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (Customer customer in customers)
            {
                // Add Customer objects to the ListBox
                listBox.Items.Add(customer);
            }
            Console.WriteLine("Customer list updated in ListBox.");
        }

        public List<string> GetCustomerNames()
        {
            return customers.Select(customer => customer.Name).ToList();
        }
        public List<Customer> GetCustomers()
        {
            return customers;
        }

        public List<Account> GetAccountsByCustomerId(int customerId)
        {
            // Find the customer with the given ID
            Customer customer = customers.FirstOrDefault(c => c.CustomerId == customerId);

            // If the customer is found, return their accounts; otherwise, return an empty list
            return customer != null ? customer.Accounts : new List<Account>();
        }

    }
}
