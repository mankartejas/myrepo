/*Write a program in C# to generate a Fibonacci series till 40.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQues
{
    internal class Que9
    {
        static void Main()
        {
            int a = 0, b = 1, c;
            
            Console.Write(a + " ");
            Console.Write(b + " ");
            for (int i = 2; i < 40; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }

        }
    }
}
