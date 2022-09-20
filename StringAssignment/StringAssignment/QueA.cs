using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class QueA
    {
        static void Main()
        {
            string str = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine(str[12]);

            Console.WriteLine("String the word is:");
            Console.WriteLine(str.Contains("is"));

            string str2 = " and killed it";

            string s = string.Concat(str, str2);
            Console.WriteLine(s);

            Console.WriteLine(s.EndsWith("dogs"));

            Console.WriteLine("String equality");
            Console.WriteLine(str.Equals("The quick brown Fox jumps over the lazy Dog"));
            Console.WriteLine(str.Equals("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG"));

            Console.WriteLine("length of the string is: ");
            Console.WriteLine(str.Length);

            Console.WriteLine("check whether the string matches");
            Console.WriteLine(str.Equals("The quick brown Fox jumps over the lazy Dog"));

            Console.WriteLine("Replace the word The with the word A: {0}.", str.Replace("The", "A"));

            string[] nstr = str.Split(" j");
            foreach (string item in nstr)
            {
                Console.WriteLine(item);
            }

            if (str.Contains("fox") || str.Contains("dog"))
            {
                Console.WriteLine("fox,dog");
            }

            Console.WriteLine(str.ToLower());

            Console.WriteLine(str.ToUpper());

            Console.WriteLine("index of a:{0}", str.IndexOf("a"));

            Console.WriteLine("last index of e:{0}", str.LastIndexOf("e"));

            //varbatim string
            Console.WriteLine("Enter the address: ");
            string @vs = Console.ReadLine();
            Console.WriteLine(String.Concat(@vs, "/WebApps/MyApps/Images  "));


            string poem = @"I WANDER'D lonely as a cloud " +
                "\nThat floats on high o'er vales and hills" +
                "\nWhen all at once I saw a crowd";
            Console.WriteLine(poem);

        }
    }
}
