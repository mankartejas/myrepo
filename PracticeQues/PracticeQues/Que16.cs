/*16.Write a program in C# to accept a word from the user and display the length of it.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQues
{
    internal class Que16
    {
        static void Main()
        {
            string word;
            int len;
            Console.WriteLine("Enter the Word");
            word = Console.ReadLine();
            len = word.Length;
            Console.WriteLine(len);
        }
    }
}
