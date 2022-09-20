/*Accept 10 numbers and sort the data in ascending order and display it.*/

using System.Collections;

namespace CollectionAssign
{
    internal class sortArraylist
    {
        static void Main(string[] args)
        {
            ArrayList al= new ArrayList();
            for(int i=0; i<10; i++)
            {
                Console.Write("Enter elements:");
                al.Add(Convert.ToInt32(Console.ReadLine()));
            }

            al.Sort();
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine(al[i]);
            }

            Console.WriteLine("\n");
            foreach(object i in al)
            {
                Console.WriteLine(i);
            }

        }
    }
}