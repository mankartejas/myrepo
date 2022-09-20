/*3.    Write a program in C# to accept two numbers from command line  and display all the numbers between the given two numbers.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQues
{
    internal class Que3
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter numbers1: ");
            int a = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Enter numbers2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a+1; i < b; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
