using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBank.Classes
{
    public class Customer
    {
        private static int nextCustomerId = 1;

        // Properties
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string ContactDetails { get; set; }


        // Constructor
        public Customer(string name, string contactDetails)
        {
            CustomerId = nextCustomerId++;
            Name = name;
            ContactDetails = contactDetails;
        }
    }
}
