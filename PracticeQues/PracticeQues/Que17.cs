/*17.Write a program in C# to accept a word from the user and display the reverse of it.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQues
{
    internal class Que17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word");
            string s = Console.ReadLine();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
        }
    }
}
