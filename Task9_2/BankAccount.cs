using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_2
{
    public class BankAccount
    {
        private static Random _random = new Random();
        private decimal _balance;
        private static int _totalAccounts;

        public int AccountNumber { get; }
        public decimal Balance { get; private set; }

        public BankAccount()
        {
            _totalAccounts++;    
            AccountNumber = _random.Next(1000, 9999);
        }
        
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (Balance < amount)
                throw new ArgumentException($"На счете недостаточно средств! Текущий баланс счета = {Balance} у.е.");
            Balance -= amount;
        }
        public void ShowTotalAccounts()
        {
            Console.WriteLine($"Всего создано счетов: {_totalAccounts}");
        }
    }
}
