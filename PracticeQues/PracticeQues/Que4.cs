/*4.Accept a number from the user and display whether the given number is an odd number or even number.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQues
{
    internal class Que4
    {
        static void Main()
        {
            int i = 0;
            Console.WriteLine("Enter a number");
            i = Convert.ToInt32(Console.ReadLine()); 
            if (i%2 == 0)
            {
                Console.WriteLine("Even no");
            }
            else
            {
                Console.WriteLine("odd no");
            }
        }
    }
}
