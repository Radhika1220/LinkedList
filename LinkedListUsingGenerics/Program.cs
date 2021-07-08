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
            Console.WriteLine("**********1.Inserted into list(From Last)************");
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
            }
            Console.ReadLine();
        }
    }
}
