/*14.    Write a program in C# to find the smallest of five numbers accepted from the user.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQues
{
    internal class Que14
    {
        static void Main(String[] args)
        {
            int a, b, c, d, e;
            Console.WriteLine("Enter 5 numbers: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            e = Convert.ToInt32(Console.ReadLine());

            if (a < b && a < c && a < d && a < e)
            {
                Console.WriteLine(a + " is the smallest");
            }
            else if (b < c && b < d && b < e)
            {
                Console.WriteLine(b + " is the smallest");
            }
            else if (c < d && c < e)
            {
                Console.WriteLine(c + " is the smallest.");
            }
            else if (d < e)
            {
                Console.WriteLine(d + " is the smallest.");
            }
            else
            {
                Console.WriteLine(e + " is the smallest.");
            }
        }
    }
}
