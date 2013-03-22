using System;

namespace Bank
{
    abstract class AAccount : ICalculateInterest
    {
        // properties
        public Customer CustomerInfo { get; set; }
        public AccountTypes AccountType { get; set; }
        public decimal AccountBalance { get; set; }
        public decimal InterestRate { get; set; }

        virtual public decimal CalculateInterest(int numberOfMonths)
        {
            return (decimal)numberOfMonths * this.InterestRate;
        }
    }
}
