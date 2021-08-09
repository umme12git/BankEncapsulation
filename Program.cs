using System;

namespace BankEncapsulation
{
    
    

    class Program
    {
             
        static void Main(string[] args)
        {
            BankAccount cusBankBalance = new BankAccount();
            
            Console.WriteLine("Please enter the deposit amount ");
            var amount = double.Parse(Console.ReadLine());         
            cusBankBalance.Deposit(amount);
            Console.WriteLine("Please enter the amount the money you would like withdraw");
            var withdrawAmt = double.Parse(Console.ReadLine());

            withdrawAmt = cusBankBalance.GetBalance(withdrawAmt);
            Console.WriteLine($"your current balance is {withdrawAmt}");

        }
    }
}
