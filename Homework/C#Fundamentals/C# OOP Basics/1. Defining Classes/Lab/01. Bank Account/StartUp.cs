﻿using System;

namespace _01._Bank_Account
{
    public class StartUp
    {
        public static void Main()
        {
            BankAccount acc = new BankAccount();

            acc.Id = 1;
            acc.Balance = 15;

            Console.WriteLine($"Account {acc.Id}, balance {acc.Balance}");
        }
    }
}
