using System;

namespace classes
{
    class Program
    {
        public static void Main(string[] args)
        {
            var account = new BankAccount("Nick", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

            account.MakeWithdrawal(500, DateTime.Now, "Rent");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Cashback");
            Console.WriteLine(account.Balance);


            //tests that initial balance is positive
            try 
            {
                var invalidAccount = new BankAccount("invalid", -100);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with a negative balance");
                Console.WriteLine(e.ToString());
            }

            // tests for a negative balance
            try
            {
                account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdaw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
