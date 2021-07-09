using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// UC1-Insert from last and display the nodes
/// UC2-Insert front the element
/// UC3-Appending in list(same as insert at last)
/// </summary>
namespace LinkedListUsingGenerics
{

    class CustomLinkedList
    {
        //Creating a head node to point the first element
        public Node head;
        //Creating a method to insert last 
        public void InsertLast(int new_data)
        {
            Node new_node = new Node(new_data);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = new_node;
            }
            Console.WriteLine("Inserted into list from last " + new_node.data);
        }
        //Insert Front 
        public void InsertFront(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = this.head;
            this.head = new_node;
            Console.WriteLine("Inserted the list in front " + new_node.data);
        }
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public void Append(int new_data)
        {
            Node temp = this.head;
            while (temp != null)
            {
                temp = temp.next;
            }
            Node new_node = new Node(new_data);
            temp.next = new_node;

        }

        public void InsertBetween(int pos, int new_data)
        { 
            Node newNode = new Node(new_data);
            if (pos == 1)
            {
                newNode.next = this.head;
                head = newNode;
            }
            else if (pos <= 0)
            {
                Console.WriteLine("Invalid Position!!!");
            }
            else if (pos > 0)
            {
                Node temp = head;
                while (pos != 0)
                {
                    if (pos == 2)
                    {
                        Console.WriteLine("After insertion performed between tow nodes");
                        newNode.next=temp.next;
                        temp.next=newNode;
                        break;
                    }
                    temp = temp.next;
                    Console.WriteLine(pos);
                   pos--;
                }

            }
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
                    Console.Write(" " + temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
