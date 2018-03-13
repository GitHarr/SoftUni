using System;

namespace _02._Bank_Account_Methods
{
    public class StartUp
    {
        public static void Main()
        {
            BankAccount acc = new BankAccount();

            acc.Id = 1;
            acc.Deposit(15);
            acc.Withdraw(10);

            Console.WriteLine(acc);
        }
    }
}
