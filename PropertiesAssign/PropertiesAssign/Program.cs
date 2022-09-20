/*1.For an Online Bookstore create a class to store book details and display the  book details with fields isbn, bookname, 
 * booktitle, bookauthor, quantityofbooks, bookprice.calculate and display the bill amount
[Note: Use Properties]
Note: read multiple book details from the user and calculate the total amount.*/

using System;

namespace PropertiesAssign
{
    class program
    {
        private int isbn, quantityofbooks;
        private string bookname, booktitle, bookauthor;
        private double bookprice;
        public double bill;

        public int ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string BOOKNAME
        {
            get { return bookname; }
            set { bookname = value; }
        }  

        public double BOOKPRICE
        {
            get { return bookprice; }  
            set { bookprice = value; }
        }

        public int QUANTITYOFBOOKS
        {
            get { return quantityofbooks; }
            set { quantityofbooks = value; }
        }

        public string BOOKAUTHOR
        {
            get { return bookauthor; }
            set { bookauthor = value; }
        }

        public string BOOKTITLE
        {
            get { return booktitle; }
            set { booktitle = value; }
        }

        public void Display()
        {
            Console.WriteLine($"isbn no: {this.isbn}");
            Console.WriteLine($"Book Name: {this.bookname}");
            Console.WriteLine($"Book title: {this.booktitle}");
            Console.WriteLine($"book Author: {this.bookauthor}");
            Console.WriteLine($"Quantity of books: {this.quantityofbooks}");
            Console.WriteLine($"Price of Book:{this.bookprice}");

            Console.WriteLine($"Total Bill:{this.quantityofbooks * this.bookprice}");
        }

        static void Main()
        {
            program[] obj = new program[3];

            obj[0] = new program();
            obj[0].isbn = 123;
            obj[0].bookname = "tejas";
            obj[0].bookauthor = "mankar";
            obj[0].booktitle = "Ram";
            obj[0].quantityofbooks = 10;
            obj[0].bookprice = 100;

            obj[0].Display();

            obj[1] = new program();
            obj[1].isbn = 123;
            obj[1].bookname = "tej";
            obj[1].bookauthor = "mankar";
            obj[1].booktitle = "Ram";
            obj[1].quantityofbooks = 10;
            obj[1].bookprice = 200;

            obj[1].Display();

            obj[2] = new program();
            obj[2].isbn = 123;
            obj[2].bookname = "adrak";
            obj[2].bookauthor = "mankar";
            obj[2].booktitle = "Ram";
            obj[2].quantityofbooks = 10;
            obj[2].bookprice = 300;

            obj[2].Display();


        }

    }
}
