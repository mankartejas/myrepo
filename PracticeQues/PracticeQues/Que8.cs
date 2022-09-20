/*8. Write a program in C# to find the factorial of the given number.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQues
{
    internal class Que8
    {
        static void Main()
        {
            int n, fact = 1;
            Console.WriteLine("ENTER NO");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = n ; i > 0; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
            
        }
    }
}
