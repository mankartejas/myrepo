/*2.Create a class called Accounts which has data members like ACCOUNT no, Customer name, Account type, Transaction type (d/w), amount, balance
D->Deposit
W->Withdrawal
If transaction type is deposit call the credit(int amount) and update balance in this method.
If transaction type is withdraw call debit(int amt) and update balance
Pass the other information like Acount no, name, acc type through accept()
call the show data method to display the values.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjAssign
{
    internal class Accounts
    {
        private long AccNo;
        private string CustName;
        private string AccType;
        private double Balance;
        //private char transtype;
        //private double amount;

        void transaction(char transType, double amt)
        {
            if (transType == 'c' || transType == 'C')
            {
                this.credit(amt);
            }
            else if (transType == 'w' || transType == 'W')
            {
                this.debit(amt);
            }
        }

        void debit(double amt)
        {
            this.Balance = this.Balance - amt;
        }
        void credit(double amt)
        {
            this.Balance = this.Balance + amt;
        }

        void showData()
        {
            Console.WriteLine("ACCOUNT DETAILS:");
            Console.WriteLine("Account No - " + this.AccNo);
            Console.WriteLine("Customer Name - " + this.CustName);
            Console.WriteLine("Account Type - " + this.AccType);
            Console.WriteLine("Balance Amount - " + this.Balance);
        }

        void accept(long accNo, string name, string accType)
        {
            this.AccNo = accNo;
            this.CustName = name;
            this.AccType = accType;
        }

        //Main function
        static void Main(string[] args)
        {

            Accounts Person1 = new Accounts();
            Person1.accept(766351418, "Prajwal Hatwar", "Savings");
            Person1.transaction('c', 30000);
            Person1.transaction('w', 2500);
            Person1.showData();

        }
    }
}
