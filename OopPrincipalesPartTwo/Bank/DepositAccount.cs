using System;


namespace Bank
{
    class DepositAccount : AAccount, IWithdraw, IDeposit
    {     

        // method
        public bool IsDepositable()
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public bool IsWithdrawable()
        {
            return true;
        }

        // Deposit accounts have no interest if their balance is positive and less than 1000.
        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (this.InterestRate > 0m)
            {
                return base.CalculateInterest(numberOfMonths);
            }
            else
            {
                return 0m;
            }
        }

        //constructor
        public DepositAccount(Customer customerInfo, decimal interestRate, decimal accountBalance)
        {
            this.AccountBalance = accountBalance;
            this.AccountType = AccountTypes.Deposit;
            this.CustomerInfo = customerInfo;

            if (this.AccountBalance > 0m && this.AccountBalance < 1000.00m)
            {
                this.InterestRate = 0m;
            }
            else
            {
                this.InterestRate = interestRate;
            }
        }


    }
}
