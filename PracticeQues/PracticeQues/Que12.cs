/*12.    Write a program to print the numbers divisible by 7 between 200 and 300.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQues
{
    internal class Que12
    {
        static void Main()
        {
            for (int i = 200; i < 300; i++)
            {
                if (i % 7 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
