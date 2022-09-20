/*11. Write a program in C# to find the multiplication table of the given number till 20.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQues
{
    internal class Que11
    {
        static void Main()
        {
            static void Main()
            {
                Console.WriteLine("enter the no: ");
                int a = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i <= 20; i++)
                {
                    Console.WriteLine("{0} * {1} = {2}", a, i, a * i);
                }
            }
        }
    }
}
