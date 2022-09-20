/*5.Write a program in C# to find the total number of odd and even numbers accepted from the user.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQues
{
    internal class Que5
    {
        static void Main()
        {
            int i,tot,Ocount = 0, Ecount = 0, num;
            Console.WriteLine("Enter total numbers");
            tot = Convert.ToInt32(Console.ReadLine());
            for(i = 0; i < tot; i++)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if(num %2 == 0)
                {
                    Ecount++;
                }
                else
                {
                    Ocount++;
                }
            }
            Console.WriteLine("Total even- " + Ecount + "\n Total odd- " + Ocount);
        }
    }
}
