/*Create a class called Student with the following details:
		RollNo
        StudName
		MarksInEng
		MarksInMaths
		MarksInScience
   Display the total marks and Percentage of the student.*/

using System;

namespace ClassObjAssign
{
    class Que8
    {
        public int RollNo;
        public string StudName;
        public int MarksInEng;
        public int MarksInMaths;
        public int MarksInScience;
        public int total;
        public double percentage;
    
        public Que8() {}

        public void Marks(int E, int M, int S)
        {
            total = 0;
            total = E + M + S;

            percentage = (total / 3);

            Console.WriteLine("Total marks: {0}, percentage: {1}", total,percentage);

        }

        static void Main()
        {
            Que8 s = new Que8();
       

            s.RollNo = 1;
            s.StudName = "tejas";
            s.MarksInEng = 50;
            s.MarksInMaths = 50;
            s.MarksInScience = 50;
            s.Marks(s.MarksInEng,s.MarksInMaths,s.MarksInScience);

        }

       
    }
}

