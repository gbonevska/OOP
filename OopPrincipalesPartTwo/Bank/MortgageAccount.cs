using System;

namespace Bank
{
    class MortgageAccount : AAccount, IWithdraw, IDeposit
    {
        // method
        public bool IsDepositable()
        {
            return true;
        }

        public bool IsWithdrawable()
        {
            return false;
        }

        //Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (this.CustomerInfo.CustomerType == Customer.CustomersTypes.Individual)
            {
                return base.CalculateInterest(numberOfMonths - 6);
            }
            else  // customer types should be company
            {
                decimal firstTwelveMonths = base.CalculateInterest(12) / 2;
                return firstTwelveMonths + base.CalculateInterest(numberOfMonths - 12);
            }
        }

        //constructor
        public MortgageAccount(Customer customerInfo, decimal interestRate, decimal accountBalance)
        {
            this.AccountBalance = accountBalance;
            this.AccountType = AccountTypes.Mortgage;
            this.InterestRate = interestRate;
            this.CustomerInfo = customerInfo;
        }
    }
}
