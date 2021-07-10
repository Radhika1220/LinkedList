using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {

          
            Console.WriteLine("****WELCOME TO LINKED LIST OPERATIONS");
            Console.WriteLine("**********1.Inserted into list(From Last)************");
            Console.WriteLine("**********2.Inserted into list(Front)************");
            Console.WriteLine("**********3.Inserting in middle***********");
            Console.WriteLine("**********4.Delete the First Element***********");
            Console.WriteLine("**********5.Delete the Last Element***********");
            Console.WriteLine("**********6.Searching the Element***********");
            Console.WriteLine("***********7.Using Search operation to find which position to insert******");
            Console.WriteLine("**********8.Delete the element and find size of list******");
            Console.WriteLine("Enter the option!!!");
            int num = Convert.ToInt32(Console.ReadLine());
            //Creating object for Custom Linked list class
            CustomLinkedList custom = new CustomLinkedList();
            switch(num)
            {
                case 1:
                    custom.InsertLast(56);
                    custom.InsertLast(30);
                    custom.InsertLast(70);
                    custom.Display();
                    break;
                case 2:
                    custom.InsertFront(56);
                    custom.InsertFront(30);
                    custom.InsertFront(70);
                    custom.Display();
                    break;
                case 3:
                    custom.InsertLast(56);
                    custom.InsertLast(70);
                    custom.InsertMiddle(2, 30);
                    custom.Display();
                    break;
                case 4:
                    custom.InsertFront(56);
                    custom.InsertFront(30);
                    custom.InsertFront(70);
                    custom.DeleteFirst();
                    custom.Display();
                    break;
                case 5:
                    custom.InsertLast(56);
                    custom.InsertLast(30);
                    custom.InsertLast(70);
                    custom.DeleteLast();
                    custom.Display();
                    break;
                case 6:
                    custom.InsertLast(56);
                    custom.InsertLast(30);
                    custom.InsertLast(70);
                    custom.Search(56);
                    break;
                case 7:
                    custom.InsertLast(56);
                    custom.InsertLast(30);
                    custom.InsertLast(70);
                    custom.InsertBetween(30, 40);
                    custom.Display();
                    break;
                case 8:
                    custom.InsertFront(70);
                    custom.InsertFront(40);
                    custom.InsertFront(30);
                    custom.InsertFront(56);
                    custom.Display();
                    custom.DeleteInBetween(40);
                    custom.Display();
                    break;
            }
            Console.ReadLine();
        }
    }

   
}
