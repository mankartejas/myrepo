/*Write an Arraylist that will hold the names of all students and display them in descending order.*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionAssign
{
    internal class StringSort
    {
        static void Main()
        {
            List<string> al = new List<string>();
            int n;
            Console.WriteLine("Enter total no of names");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("enter name {0}: ", i + 1);
                al.Add(Convert.ToString(Console.ReadLine()));
            }

            al.Sort();
            Console.WriteLine("sorted desc:");
            for (int i = n - 1; i >= 0; i--)
            {

                Console.WriteLine(al[i]);
            }
        }
    }
}
