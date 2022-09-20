/*6. Write a program in C# to display temperature in Celsius. Accept the temperature in Fahrenheit.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQues
{
    internal class Que6
    {
        static void Main()
        {
            Double ftemp, ctemp;
            Console.WriteLine("Enter temperature in Fahrenhite");
            ftemp = Convert.ToDouble(Console.ReadLine());
            ctemp = 5*(ftemp - 32)/9;
            Console.WriteLine(ctemp);
        }
    }
}
