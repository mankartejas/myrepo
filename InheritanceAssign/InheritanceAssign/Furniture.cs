using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssign
{
    class Furniture
    {
        protected int OrderId;
        protected DateOnly OrderDate;
        protected string FurnitureType;
        protected int Qty;
        protected double TotalAmt;
        protected string PaymentMode;


        public void GetData()
        {
            Console.WriteLine("Enter furniture details like order id, order date, furniture type, quantity, total Amount, Payment mode:");
            this.OrderId = int.Parse(Console.ReadLine());
            this.OrderDate = DateOnly.Parse(Console.ReadLine());
            this.FurnitureType = Console.ReadLine();
            this.Qty = int.Parse(Console.ReadLine());
            this.TotalAmt = double.Parse(Console.ReadLine());
            this.PaymentMode = Console.ReadLine();

        }

        public void ShowData()
        {
            Console.WriteLine("Furniture Details");
            Console.WriteLine($"Order Id:{this.OrderId}");
            Console.WriteLine($"Order Date: {this.OrderDate}");
            Console.WriteLine($"Type of Furniture: {this.FurnitureType}");
            Console.WriteLine($"Quantity: {this.Qty}");
            Console.WriteLine($"Total Amount: {this.TotalAmt}");
            Console.WriteLine($"Payment Mode: {this.PaymentMode}");

        }
    }

    class chair:Furniture
    {
        string ChairType, WoodType, SteelType, PlasticColor, Purpose;
        double Rate;

        public void GetData()
        {
            base.GetData();
            Console.WriteLine("Enter Chair Type (wood, steel, plastic):");
            this.ChairType = Console.ReadLine();//wood,steel,plastic
            if(this.ChairType == "wood")
            {
                Console.WriteLine("wood Type(teak/rose)");
                this.WoodType = Console.ReadLine();
            }
            else if(this.ChairType == "steel")
            {
                Console.WriteLine("steel type(grey/green/brown)");
                this.SteelType = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Plastic color(green/red/blue/white)");
                this.PlasticColor = Console.ReadLine();
            }
            Console.WriteLine("Enter Purpose(home/office)");
            this.Purpose = Console.ReadLine();//home office
            Console.WriteLine("enter the rate:");
            this.Rate = Convert.ToInt32(Console.ReadLine());
        }

        public void ShowData()
        {
            base.ShowData();
            Console.WriteLine("Chair Details: ");
            Console.WriteLine($"Chair Type: {this.ChairType}");
            if (this.ChairType == "Wood")
            {
                Console.Write(this.WoodType);
            }
            else if (this.ChairType == "Steel")
            {
                Console.Write(this.SteelType);
            }
            else if (this.ChairType == "Plastic")
            {
                Console.Write(this.PlasticColor);
            }
            Console.WriteLine($"Purpose: {this.Purpose}");
            Console.WriteLine($"Rate: {this.Rate}");
        }
    }

    class cot:Furniture
    {
        string CotType, Capacity, WoodType, SteelType;
        double Rate;

        public void GetData()
        {
            base.GetData();
            Console.WriteLine("Enter Cot Type (wood, steel):");
            this.CotType = Console.ReadLine();//wood,steel,plastic
            if (this.CotType == "wood")
            {
                Console.WriteLine("wood Type(teak/rose)");
                this.WoodType = Console.ReadLine();
            }
            else if (this.CotType == "steel")
            {
                Console.WriteLine("steel type(grey/green/brown)");
                this.SteelType = Console.ReadLine();
            }
            Console.WriteLine("Enter Capacity");
            this.Capacity = Console.ReadLine();//single,double
            Console.WriteLine("enter the rate:");
            this.Rate = Convert.ToInt32(Console.ReadLine());
        }

        public void ShowData()
        {
            base.ShowData();
            Console.WriteLine("Cot Details: ");
            Console.WriteLine($"Cot Type: {this.CotType}");
            if (this.CotType == "Wood")
            {
                Console.Write(this.WoodType);
            }
            else if (this.CotType == "Steel")
            {
                Console.Write(this.SteelType);
            }
            Console.WriteLine($"Capacity: {this.Capacity}");
            Console.WriteLine($"Rate: {this.Rate}");
        }

        

    }

    class test_furniture
    {
       static void Main()
        {
            
           
                chair ch = new chair();
                ch.GetData();
                ch.ShowData();

                cot c = new cot();
                c.GetData();
                c.ShowData();
            
        }
    }
}
