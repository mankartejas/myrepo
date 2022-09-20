/*1.You owe the credit card company an amount of M. The company charges you an interest of 1.5%   per month on the unpaid balance.
 * You have decided close the card and pay off the debt by making a monthly payment of N rupee a month. 
Write a program that asks for the monthly payment, the program writes out the balance and total payments so far for every
succeeding month until the balance is zero or less. 
Sample Input : 
Enter the monthly payment: 100
Sample Output: 
Month: 1 balance: 915.0 total payments: 100.0 
Month: 2 balance: 828.725 total payments: 200.0 
Month: 3 balance: 741.155875 total payments: 300.0
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjAssign
{
    internal class Interest
    {
        public double amount, mpayment;
        public const double interest = 0.015;

        public void monthlypayment()
        {
            int month = 1;
            while (amount > 0)
            {
                amount += amount * interest;
                if (amount > mpayment)
                {
                    amount -= mpayment;
                    Console.WriteLine("Month: " + month + " balance: " + amount + " total payments: " + mpayment * month);
                }
                else
                {
                    mpayment = mpayment * (month - 1) + amount;
                    amount = 0;
                    Console.WriteLine("Month: " + month + " balance: " + amount + " total payments: " + mpayment);
                }
                month++;
            }
        }
        public static void Main()
        {
            Interest u1 = new Interest();
            u1.amount = 1000;
            Console.Write("Enter the monthly payment: ");
            u1.mpayment = Convert.ToDouble(Console.ReadLine());
            u1.monthlypayment();
        }

    }
}
