using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionAssign
{
    internal class GenericSort
    {
        /*Accept 10 numbers and sort the data in ascending order and display it.*/

        static void Main(string[] args)
        {
            List<int> al = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter elements:");
                al.Add(Convert.ToInt32(Console.ReadLine()));
            }

            al.Sort();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(al[i]);
            }

            Console.WriteLine("\n");
            foreach (object i in al)
            {
                Console.WriteLine(i);
            }

        }
    }
}
