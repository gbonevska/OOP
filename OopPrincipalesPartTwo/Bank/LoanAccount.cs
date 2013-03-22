using System;


namespace Bank
{
    class LoanAccount : AAccount, IWithdraw, IDeposit
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

        //Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (this.CustomerInfo.CustomerType == Customer.CustomersTypes.Individual)
            {
                return base.CalculateInterest(numberOfMonths - 3);
            }
            else  // customer types should be company
            {
                return base.CalculateInterest(numberOfMonths - 2);
            }
        }

        //constructor
        public LoanAccount(Customer customerInfo, decimal interestRate, decimal accountBalance)
        {
            this.AccountBalance = accountBalance;
            this.AccountType = AccountTypes.Loan;
            this.InterestRate = interestRate;
            this.CustomerInfo = customerInfo;
        }


    }
}
