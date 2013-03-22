using System;


namespace Bank
{
    class Bank
    {
        static void Main()
        {
            // customers
            Customer individual = new Customer(Customer.CustomersTypes.Individual, "Petur", "Petrov");
            AAccount[] individualAccounts = new AAccount[] { new DepositAccount(individual, 5.3m, 1500.00m),
                                                             new DepositAccount(individual, 10m, 200.00m),
                                                             new MortgageAccount(individual, 11.8m, 100000.00m)                                                
                                                            };

            Customer company = new Customer(Customer.CustomersTypes.Company, "Melinda", "Ltd.");
            AAccount[] companyAccounts = new AAccount[] { new DepositAccount(company, 5.3m, 12500.00m),
                                                              new LoanAccount(company, 8.4m, 500000.00m)                                                
                                                            };


            Console.WriteLine("individual info:");
            for (int i = 0; i < individualAccounts.Length; i++)
            {
                Console.WriteLine(" Calc interest: {0:0.00}",individualAccounts[i].CalculateInterest(360));
            }
            Console.WriteLine();
            Console.WriteLine("company info:");
            for (int i = 0; i < companyAccounts.Length; i++)
            {
                Console.WriteLine(" Calc interest: {0:0.00}", companyAccounts[i].CalculateInterest(240));
            }
        }
    }
}
