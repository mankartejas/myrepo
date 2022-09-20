/*2.    Write a program in C# to accept the name of the user from command line  and greet the user as:
    “Hi! username
    Welcome to the world of C#”*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQues
{
    internal class Que2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Hi " + name + "\n Welcome to the world of C#.");

        }
    }
}
