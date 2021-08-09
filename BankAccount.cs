using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    class BankAccount
    {
        
            private double balance = 0;

            public void Deposit(double deposit)
            {
                balance = balance + deposit;
            }

            public double GetBalance(double withdrawAmt)
            {
                return balance -= withdrawAmt;
            }

    }
}
