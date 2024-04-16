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
        public int CustomerId { get; }
        public string Name { get; set; }
        public string ContactDetails { get; set; }

        public bool IsStaff { get; set; }

        // Constructor
        public Customer(string name, string contactDetails, bool isStaff)
        {
            CustomerId = nextCustomerId++;
            Name = name;
            ContactDetails = contactDetails;
            IsStaff = isStaff;
        }

        public override string ToString()
        {
            return $"{CustomerId}: {Name} - {ContactDetails}";
        }

    }
}
