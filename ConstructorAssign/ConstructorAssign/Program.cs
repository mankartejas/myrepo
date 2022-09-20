/*1.Create a reference type called Person.  Populate the Person class with the following attributes to store the following information:

First name 
Last name 
Email address 
Date of birth 

Add constructors that accept the following parameter lists:
All four parameters 
First name , Last name , Email 
First name , Last name , Date of birth

Write appropriate methods to accept and display the details.*/

using System;

namespace ConstructorAssign
{
    class Person
    {
        public string FirstName, LastName, Email;
        public DateOnly dob;

        public Person()
        {

        }
        public Person(string FirstName, string LastName, string Email, DateOnly dob) 
        {
            this.FirstName = FirstName;
            this.LastName = LastName;  
            this.Email = Email;
            this.dob = dob;

        }

        public Person(string FirstName, string LastName, string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;

        }

        public Person(string FirstName, string LastName, DateOnly dob)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.dob= dob;  
        }

        public void Display()
        {
            Console.WriteLine($"First Name: {this.FirstName} \nLast Name:{this.LastName} \nEmail Address:{this.Email} \nDate of Birth:{this.dob}\n");
        }

        static void Main()
        {
            Person p = new Person();

            //Console.WriteLine("Enter Details:");
            //p.FirstName = Console.ReadLine();
            //p.LastName = Console.ReadLine();
            //p.Email = Console.ReadLine();
            ////p.dob = DateOnly.Parse(Console.ReadLine());



            p.Display();
            Person p1 = new Person("tejas","mankar","tejassmankar@gmail.com",DateOnly.Parse("25-07-00"));
            p1.Display();

            Person p2 = new Person("Ram", "mankar", DateOnly.Parse("25-07-00"));
            p2.Display();




        }
    }
}

