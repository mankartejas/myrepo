using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssign
{
    interface GovtRules
    {
        public double EmployeePf(double basicSalary);

        public string LeaveDetails();
        public double gratuityAmount(float serviceCompleted, double basicSalary);
    }

    class TCS : GovtRules
    {
        private int empid;
        private string name;
        private string dept;
        private string desg;
        private double basicSalary;
        //private double compf;
        //private double pension;
        private double gratuity;
        private int serviceCompleted;

        public TCS(int empid, string name, string dept, string desg, double basicSalary, int serviceCompleted)
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
            this.serviceCompleted = serviceCompleted;

        }

        public int EMPID
        {
            get { return empid; }
            set { empid = value; }
        }
        public string NAME { get { return name; } set { name = value; } }
        public string DEPT { get { return dept; } set { dept = value; } }
        public string DESG { get { return desg; } set { desg = value; } }
        public double BASICSALARY { get { return basicSalary; } set { basicSalary = value; } }

        public int ServiceCompleted { get { return serviceCompleted; } set { serviceCompleted = value; } }  

        public double EmployeePf(double basicSalary)
        {
            //Console.WriteLine("Employee Contribution towards PF:");

            //compf = basicSalary * 0.0833;
            //pension = basicSalary * 0.0367;
            return (basicSalary * 0.12);
        }

        public double EmployerPf(double basicSalary)
        {
            //Console.WriteLine("Employee Contribution towards PF:");

            //compf = basicSalary * 0.0833;
            //pension = basicSalary * 0.0367;
            return (basicSalary * 0.0833);
        }

        public double PensionFund(double basicSalary)
        {
            //Console.WriteLine("Employee Contribution towards PF:");

            //compf = basicSalary * 0.0833;
            //pension = basicSalary * 0.0367;
            return (basicSalary * 0.0367);
        }

        public string LeaveDetails()
        {
            return "1 day of Casual Leave per month. \r\n12 days of Sick Leave per year.\r\n10 days of Previlage Leave per year.\r\n";
        }

        /*Gratuity amount : if the no of service year completed in the same company is > 5 , 
         * 1month basic salary will be deposited in gratuity amount
        if >10 years service, 2*basic salary = gratuity amount
        if >20 years service, 3* basic salary = gratuity amount
        if < 5 no gratuity.*/

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            //Console.WriteLine("Gratuity Contribution:");
            if(serviceCompleted>5 && serviceCompleted < 10)
            {
                gratuity = basicSalary;
                return gratuity;
            }
            else if (serviceCompleted>10 && serviceCompleted < 20)
            {
                gratuity = 2*basicSalary;
                return gratuity;
            }
            else if (serviceCompleted > 20)
            {
                gratuity = 3 * basicSalary;
                return gratuity;
            }
            else
            {
                return basicSalary;
            }


        }

        public void showTCSDetails()
        {
            Console.WriteLine("\nTCS employee Details:");
            Console.WriteLine($"ID:{empid}, \nName:{name}, \nDetartment:{dept}, \nDesignation:{desg}, \nBasic Salary: {basicSalary}," +
                $"\nEmployee pf contribution:{this.EmployeePf(basicSalary)},\nEmployeer pf contribution:{this.EmployerPf(basicSalary)}," +
                $"\nPension Fund:{this.PensionFund(basicSalary)},\nLeave Details:{this.LeaveDetails}, \nGratuity Amount:{this.gratuityAmount(serviceCompleted,basicSalary)}");

        }



    }

    class Accenture : GovtRules
    {
        private int empid;
        private string name;
        private string dept;
        private string desg;
        private double basicSalary;
        private int serviceCompleted;
        public Accenture(int empid, string name, string dept, string desg, double basicSalary, int serviceCompleted)
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
            this.serviceCompleted = serviceCompleted;
        }

        public int EMPID
        {
            get { return empid; }
            set { empid = value; }
        }
        public string NAME { get { return name; } set { name = value; } }
        public string DEPT { get { return dept; } set { dept = value; } }
        public string DESG { get { return desg; } set { desg = value; } }
        public double BASICSALARY { get { return basicSalary; } set { basicSalary = value; } }

        public int ServiceCompleted { get { return serviceCompleted; } set { serviceCompleted = value; } }


        public double EmployeePf(double basicSalary)
        {
            //Console.WriteLine("Employee Contribution towards PF:");
            
            //compf = basicSalary * 0.0833;
            //pension = basicSalary * 0.0367;
            return (basicSalary * 0.12);
        }
        //public double EmployerPf(double basicSalary)
        //{
        //    //Console.WriteLine("Employee Contribution towards PF:");

        //    //compf = basicSalary * 0.0833;
        //    //pension = basicSalary * 0.0367;
        //    return (basicSalary * 0.12);
        //}

        public string LeaveDetails()
        {
            return "2 day of Casual Leave per month. \r\n5 days of Sick Leave per year.\r\n5 days of Previlage Leave per year.\r\n";
        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            return 0;
        }

        public void showAccentureDetails()
        {
            Console.WriteLine("\nTCS employee Details:");
            Console.WriteLine($"ID:{empid}, \nName:{name}, \nDetartment:{dept}, \nDesignation:{desg}, \nBasic Salary: {basicSalary}," +
                $"\nEmployee pf contribution:{this.EmployeePf(basicSalary)}," +
                $"\nLeave Details:{this.LeaveDetails}, \nGratuity Amount:{this.gratuityAmount(serviceCompleted, basicSalary)}(not Applicable)");

        }


    }


    class test_Rules
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter TCS employee details: Id, Name, Department, Designation, Basic Salary, Service Completed:");
            int empId = int.Parse(Console.ReadLine());
            string empName = Console.ReadLine();
            string empDepartment = Console.ReadLine();
            string empDesignation = Console.ReadLine();
            double basicSalary = long.Parse(Console.ReadLine());
            int serviceCompleted = int.Parse(Console.ReadLine());
            TCS tcs = new TCS(empId, empName, empDepartment, empDesignation, basicSalary, serviceCompleted);
            tcs.showTCSDetails();

            //Console.WriteLine("\nEnter Accenture employee details: Id, Name, Department, Designation, Basic Salary, Service Completed:");
            //empId = int.Parse(Console.ReadLine());
            //empName = Console.ReadLine();
            //empDepartment = Console.ReadLine();
            //empDesignation = Console.ReadLine();
            //basicSalary = long.Parse(Console.ReadLine());
            //serviceCompleted = int.Parse(Console.ReadLine());
            //Accenture accenture = new Accenture(empId, empName, empDepartment, empDesignation, basicSalary, serviceCompleted);
            //accenture.showAccentureDetails();

        }
    }
}