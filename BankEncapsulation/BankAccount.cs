using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0;

        public void Deposit(double deposit)
        {
            _balance += deposit;
        }
        public void Withdraw(double withdraw)
        {
            if (withdraw <= _balance)
            {
                _balance -= withdraw;
            }
            else
            {
                Console.WriteLine("You cannot withdraw that much!");
            }
        }

        public double GetBalance()
        {
            return _balance;
        }
    }
}