/*7. Write a program to print the series: 0,1,4,9,16,.....625*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQues
{
    internal class Que7
    {
        static void Main()
        {
            int sq;
            for(int i = 0; i <= 25; i++)
            {
                sq = i * i;
                Console.Write(sq+" ");
            }
        }
    }
}
