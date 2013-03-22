using System;

namespace Bank
{

    public class Customer
    {

        public enum CustomersTypes
        {
            Individual,
            Company,
        }
        //properties
        public CustomersTypes CustomerType { get; set; }
        public string CustomerName { get; set; }

        //consturctor
        public Customer(CustomersTypes customerType, string customFirstName, string customLastName)
        {
            this.CustomerType = customerType;
            this.CustomerName = customFirstName + " " + customLastName;
        }
    }
}
