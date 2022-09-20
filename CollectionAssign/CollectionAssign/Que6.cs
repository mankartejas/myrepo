/*6.Create a class called BookStore with fields Bookid and Bookname.Accept and display the  details using HashTable.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace CollectionAssign
{
    internal class Que6
    {
        static void Main()
        {
            //BookStore[] bs = new BookStore[2];

            //bs[0] = new BookStore(1, "tejas");

            Console.WriteLine("Enter no of books");
            int n = Convert.ToInt32(Console.ReadLine());
            BookStore[] bs = new BookStore[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("enter book Id: ");
                int bookid = Convert.ToInt32(Console.ReadLine());
                Console.Write("enter book name: ");
                string bookname = Convert.ToString(Console.ReadLine());

                bs[i] = new BookStore(bookid, bookname);
            }
            Console.WriteLine("\n");
            for(int i = 0; i < n; i++)
            {
                bs[i].Display();
            }
            

        }
    }

    class BookStore
    {
        int BookId;
        string Bookname;
        Hashtable ht = new Hashtable();
        public BookStore(int Bookid, string Bookname)
        {
            this.BookId = Bookid;
            this.Bookname = Bookname;

            ht.Add(this.BookId, this.Bookname);
        }

        public void Display()
        {
            foreach (var item in ht.Keys)
            {
                Console.WriteLine($"Book ID: {item} - Book Name: {ht[item]}");
            }
        }
    }

}
