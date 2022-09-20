/*13.Write a program in C# to find the largest of the given three numbers. Accept the numbers from the users.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQues
{
    internal class Que13
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("enter three nos:-");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a>c)
            {
                Console.WriteLine(a + " is the largest");
            }
            else if(b > c)
            {
                Console.WriteLine(b + " is the largest");
            }
            else
            {
                Console.WriteLine(c + " is the largest.");
            }

        }
    }
}
