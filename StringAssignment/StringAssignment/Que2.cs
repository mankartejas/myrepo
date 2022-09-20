/*1.Swap 2 numbers without using a third variable*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class Que2
    {
        static void Main()
        {
            static void Main(String[] args)
            {
                int a, b;
                Console.WriteLine("Enter 2 numebers to swap: ");
                Console.Write("a = ");
                a = int.Parse(Console.ReadLine());
                Console.Write("b = ");
                b = int.Parse(Console.ReadLine());

                a = a + b;
                b = a - b;
                a = a - b;

                Console.WriteLine("Swapped: ");
                Console.Write("a = {0}\n", a);
                Console.Write("b = {0}", b);



            }
        }
    }
}
