using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQues
{
    internal class Que19
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word: ");
            string s = Console.ReadLine();
            int n = s.Length, flag = 0;
            for (int i = 0; i < n / 2; i++)
            {
                if (s[i] != s[n - (i + 1)])
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("The given word is a palindrome");
            }
            else
            {
                Console.WriteLine("The given word is not a palindrome");
            }
        }
    }
}
