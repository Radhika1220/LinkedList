using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// UC1-Insert from last and display the nodes
/// UC2-Insert front the element
/// UC3-Appending in list(same as insert at last)
/// UC4-Insertion between nodes
/// UC5-Deletion the first element
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
            Node newNode = new Node(new_data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = newNode;
            }
            Console.WriteLine("Inserted into list from last " + newNode.data);
        }
        //Insert Front 
        public void InsertFront(int new_data)
        {
            Node newNode = new Node(new_data);
            newNode.next = this.head;
            this.head = newNode;
            Console.WriteLine("Inserted the list in front " + newNode.data);
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
        //Deleting the first node
        public Node DeleteFirst()
        {
            if(this.head==null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
        public Node DeleteLast()
        {
            Node newNode = this.head;
            if(this.head==null)
            {
                return null;
            }
            if(this.head.next==null)
            {
                this.head = null;
                return null;
            }
            while(newNode.next.next!=null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return newNode;

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
