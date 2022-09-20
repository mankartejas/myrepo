/*5.Write an executable program in C# that will hold the employee code and employee names available in an Organization using Collections.
    When the data is displayed it should be in a sorted manner.Choose an appropiate type of Collection.*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionAssign
{
    internal class DictionarySort5
    {
        public static void Main()
        {
            Dictionary<int, string> sd = new Dictionary<int, string>();
            Console.Write("Enter the no of employees: ");

            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int ecode;
                string ename;

                ecode = Convert.ToInt32(Console.ReadLine());
                ename = Convert.ToString(Console.ReadLine());
                sd.Add(ecode, ename);
            }

            Console.WriteLine("details of employee:");

            var list = sd.Keys.ToList();
            list.Sort();
            foreach(var item in list)
            {
                Console.WriteLine($"id:{item}- Name:{sd[item]}");
            }
        }
    }
}
