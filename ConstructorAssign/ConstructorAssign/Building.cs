/*2.Create a class called building which has datamembers like 
string type(Flat/Villa)
string capacity(2BHK/3BHK/4BHK)
string dimension
if flat store the floor number where the flat is available 
If villa store the land dimension like 20X30,60X40,30X40 as values
string dateofcompletion
Accept all values through constructor
Display all values using showdata().
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssign
{
    internal class Building
    {
        public string type;
        public string capacity;
        public string dimension;
        public int floorNo = 0 ;
        public DateOnly DateOfCompletion;

        public Building()
        {

        }

        public Building(string type, string capacity, string dimension, int floorNo, DateOnly DateofCompletion)
        {
            this.type = type;
            this.capacity = capacity;
            this.dimension = dimension;
            this.floorNo = floorNo;
            this.DateOfCompletion = DateofCompletion;
        }

        public Building(string type, string capacity, string dimension, DateOnly DateofCompletion)
        {
            this.type = type;
            this.capacity = capacity;
            this.dimension = dimension;
            this.DateOfCompletion = DateofCompletion;
        }


        public void showDetails()
        {
            Console.WriteLine($"Type:{type}");
            Console.WriteLine($"Capacity:{capacity}");
            Console.WriteLine($"dimensions:{dimension}");
            Console.WriteLine($"Floor Number:{floorNo}");
            Console.WriteLine($"Date of Completion:{DateOfCompletion}\n");
        }

        static void Main()
        {
            Building b = new Building("flat", "2bhk", "20X30", 6, DateOnly.Parse("20-10-23"));
            b.showDetails();

            Building v = new Building("villa", "3bhk", "40X60", DateOnly.Parse("20-12-23"));
            v.showDetails();
        }


    }
}
