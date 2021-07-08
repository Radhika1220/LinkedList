using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// UC1-Insert from last and display the nodes
/// </summary>
namespace LinkedListUsingGenerics
{

    class CustomLinkedList
    {
        //Creating a head node to point the first element
        public Node head;
       //Creating a method to insert last 
        public  void InsertLast(int new_data)
        {
            Node new_node = new Node(new_data);
            if(this.head==null)
            {
                this.head = new_node;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = new_node;
            }
            Console.WriteLine("Inserted into list " + new_node.data);
        }

        public Node GetLastNode()
        {
            Node temp = this.head;
            while(temp.next!=null)
            {
                temp = temp.next;
            }
            return temp;
        }
        //Display the nodes
        public void Display()
        {
            Console.WriteLine("**********Displaying Nodes************");
            Node temp = this.head;
            if(temp==null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            else
            {
                while(temp!=null)
                {
                    Console.WriteLine(" " + temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
