/*2.Write a program with abstract classes and interfaces.Abstract class should contain one abstract and non-abstract method.
 * Abstract method should get daily sales value and return as month sales value. Non-abstract method should return daily sales value.
 * Interface should contain one method which return sales value for a year.

Main class should inherits both class and interface. Here daily sales value is Rs.400.

System should call those three methods and display the following output:

Daily sales: Rs .400

Monthly sales: Rs .12000

Annual sales: Rs .144000
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssign
{
    public abstract class Sales1
    {
        public abstract double MonthlySales(double daily);
        public double DailySales()
        {
            return 400.0;
        }
    }

    public interface Sales2
    {
        public double YearlySales(double daily);
    }

    public class Sales : Sales1, Sales2
    {
        public override double MonthlySales(double daily)
        {
            return 30 * daily;
        }

        public double YearlySales(double daily)
        {
            return 365 * daily;
        }

        static void Main(string[] args)
        {
            Sales sales = new Sales();
            double daily = sales.DailySales();
            Console.WriteLine($"Daily Sales: {sales.DailySales()}\nMonthly Sales: {sales.MonthlySales(daily)}\nAnnual Sales: {sales.YearlySales(daily)}");
        }
    }
}