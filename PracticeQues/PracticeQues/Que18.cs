/*18.    Write a program in C# to accept two words from user and find out if they are same.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQues
{
    internal class Que18
    {
        static void Main()
        {
            Console.WriteLine("Enter the 1st word: ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter the 2nd word: ");
            string s2 = Console.ReadLine();

            if (s1 == s2)
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Not same");
            }
        }
    }
}
