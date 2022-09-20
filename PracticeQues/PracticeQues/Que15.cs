/*15.Write a program in C# to accept ten marks and display the following
a.    Total
b.    Average
c.    Minimum marks
d.    Maximum marks
e.    Display marks in ascending order
f.    Display marks in descending order*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQues
{
    internal class Que15
    {
        static void Main()
        {
            int[] marks = new int[10];
            Console.WriteLine("Enter 10 marks:");
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(marks);
            int total = marks.Sum();
            Console.WriteLine("Total = " + total);
            Console.WriteLine("Average = " + total / 10);
            Console.WriteLine("Minimum = " + marks[0]);
            Console.WriteLine("Maximum = " + marks[9]);
            Console.WriteLine("Marks in ascending order");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(marks[i]);
            }
            Console.WriteLine("Marks in descending order");
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(marks[i]);
            }
        }
    }
}
