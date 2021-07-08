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
            }
            Console.ReadLine();
        }
    }
}
