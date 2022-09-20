using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjAssign
{
    class BankAccount
    {
        public String Name;
        public int AccountNumber;
        public String TypeOfAccount;
        public double BalanceAmount;
        public BankAccount() { }
        public BankAccount(String n, int an, String t, double b)
        {
            Name = n;
            AccountNumber = an;
            BalanceAmount = b;
            TypeOfAccount = t;
        }

        public void disp()
        {
            Console.WriteLine($"Name: {Name}\nBalance: Rs {BalanceAmount}");
        }

        public void deposit()
        {
            Console.WriteLine($"Balance: Rs {BalanceAmount}\nEnter amount to be deposited:");
            double depo = Convert.ToDouble(Console.ReadLine());
            BalanceAmount = BalanceAmount + depo;
            Console.WriteLine($"Balance: Rs {BalanceAmount}");
        }

        public void withdraw()
        {
            Console.WriteLine($"Balance: Rs {BalanceAmount}\nEnter amount to be withdrawn:");
            double with = Convert.ToDouble(Console.ReadLine());
            BalanceAmount = BalanceAmount - with;
            Console.WriteLine($"Balance: Rs {BalanceAmount}");
        }

        public static void Main()
        {
            BankAccount account1 = new BankAccount("Abc", 10235, "Sav", 500.6);
            Console.WriteLine("Menu: 1.Show Details 2.Withdraw 3.Deposit");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    account1.disp();
                    break;

                case 2:
                    account1.withdraw();
                    break;

                case 3:
                    account1.deposit();
                    break;

            }
        }
    }
}
