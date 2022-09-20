using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjAssign
{
    class Shapes
    {
        void area(double r)
        {
            double A = 3.14 * r * r;
            Console.WriteLine("Area of Circle = " + A);
        }

        void area(double b, double h)
        {
            double A = 0.5 * b * h;
            Console.WriteLine("Area of Triangle = " + A);
        }

        void area(int a)
        {
            float A = a * a;
            Console.WriteLine("Area of Square = " + A);
        }

        void area(int a, int b)
        {
            int A = a * b;
            Console.WriteLine("Area of Rectangle = " + A);
        }


        static void Main(string[] args)
        {
            Shapes s = new Shapes();
            s.area(3.0);
            s.area(5.2, 4.5);
            s.area(10);
            s.area(4, 5);
        }
    }
}
