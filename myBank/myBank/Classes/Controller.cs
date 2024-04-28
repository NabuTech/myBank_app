using System;
using System.Collections.Generic;
using System.IO;
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
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Customers JSON file not found. No customers loaded.");
            }
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
    }
}
