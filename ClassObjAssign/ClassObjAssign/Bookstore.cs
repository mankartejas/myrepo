/*5.For an Online Bookstore create a class to store book details and display the  book details with fields isbn,bookname,booktitle,bookauthor,
 * quantityofbooks,bookprice.calculate and display the bill amount
[Note: Use Suitable Methods]
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjAssign
{
    internal class Bookstore
    {
        private int isbn, quantityofbooks;
        private string bookname, booktitle, bookauthor;
        private double bookprice;

        public void display()
        {
            Console.WriteLine("Book Name: " + bookname + "\nBook Title: " + booktitle + "\nBook Author: " + bookauthor + "\nQuantity of Books: " + quantityofbooks + "\nBook Price: " + bookprice);
        }

        public void calculatebill()
        {
            Console.WriteLine("Bill = " + (bookprice * quantityofbooks));
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the isbn: ");
            Bookstore book = new Bookstore();

            book.isbn = int.Parse(Console.ReadLine());

            Console.Write("Enter the Name of book: ");

            book.bookname = Console.ReadLine();
            Console.Write("Enter the Title of book: ");
            book.booktitle = Console.ReadLine();
            Console.Write("Enter the Author of book: ");
            book.bookauthor = Console.ReadLine();
            Console.Write("Enter the Quantity of book: ");
            book.quantityofbooks = int.Parse(Console.ReadLine());
            Console.Write("Enter the Price of book: ");
            book.bookprice = Double.Parse(Console.ReadLine());
            book.display();
            book.calculatebill();
        }
    }
}
