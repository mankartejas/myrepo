/*3.Create a class called shapes Overload the Area method 
 * that has to calculate the area of rectangle, triangle, circle, and square by passing the relevant parameters.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssign
{
    internal class Shape
    {
        public void area(int a, int b)
        {
            int A = a * b;
            Console.WriteLine("Area of rectangle: "+A);
        }
        public void area(double r)
        {
            Console.WriteLine($"Area of Circle:{3.14 * r * r}");
        }

        public void area(int a)
        {
            int A = a * a;
            Console.WriteLine("Area of Square: " + A);
        }

        public void area(double a, double b)
        {
            double A = 0.5*a * b; 
            Console.WriteLine("Area of triangle: " + A);
        }


        static void Main()
        {
            Shape s = new Shape();
            s.area(3.2);
            s.area(3, 2);
            s.area(3);
            s.area(3.2,2.0);
        }
    }
}
