using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjAssign
{
    internal class Student
    {
        public int rollno;
        public String name;
        public int classs;
        public int sem;
        public String branch;
        public int[] marks = new int[5];
        public int total;
        public double avg;
        public Student() { }
        public Student(int r, String n, int c, int s, String b, int[] a)
        {
            rollno = r;
            name = n;
            classs = c;
            sem = s;
            branch = b;
            marks = a;
        }
        public void displayresult()
        {
            total = 0;
            foreach (int i in marks)
                total = total + i;
            avg = total / 5;
            if (marks[0] < 35 || marks[1] < 35 || marks[2] < 35 || marks[3] < 35 || marks[4] < 35)
                Console.WriteLine("Result: Failed");
            else if (total > 35 && avg < 50.0)
                Console.WriteLine("Result: Failed");
            else if (avg > 50)
                Console.WriteLine("Result: Passed");
        }

        public void displaydata()
        {
            Console.WriteLine("Marks: {0}, {1}, {2}, {3}, {4}", marks[0], marks[1], marks[2], marks[3], marks[4]);
            Console.WriteLine("Total: {0}, Average: {1}", total, avg);
        }

        public static void Main()
        {
            int[] arr = { 36, 40, 50, 45, 60 };
            Student s1 = new Student(30, "abc", 10, 4, "cse", arr);
            s1.displayresult();
            s1.displaydata();
            Console.WriteLine();
            int[] arr2 = { 45, 60, 70, 75, 80 };
            Student s2 = new Student(20, "xyz", 11, 4, "etc", arr2);
            s2.displayresult();
            s2.displaydata();
        }
    }
}
}
