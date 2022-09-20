using System;
using System.Collections;
namespace GenericCollectionAssign 
{ 

    class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public int Age { get; set; }
    }
    internal class ldisplay
    {
        static void Main()
        {
            Student s1 = new Student() { Sid = 1, Sname = "tejas", Age = 21 };
            Student s2 = new Student() { Sid = 2, Sname = "Pranay", Age = 21 };
            Student s3 = new Student() { Sid = 3, Sname = "paritosh", Age = 22 };
            List<Student> list = new List<Student>() { s1, s2, s3 };
            foreach (Student item in list)
                Console.WriteLine("{0} {1} {2}", item.Sid, item.Sname, item.Age);
        }
    }
}