using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class SingleLinkedList
    {
        Node head; //starting of linked list defining position head
        public void Add(int data)// proprty of adding (add the element of linked list)
        {
            Node node = new Node(data);//  creating the object of the node class
                                       //  and pushing data into it
            if (head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} Inserted into Linked List", node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        /// <summary>
        /// UC2:-Inserting a data at beginning through a temp node
        /// </summary>
        /// <param int="data"></param>
        public void InsertAtBeginning(int data)
        {
            if (head == null)
            {
                head = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = head;
                head = temp;
            }
            Console.WriteLine("{0} Inserted Begnning into Linked List", head.data);

        }//End of InsertAtBeginningMethod

    }
   
}
