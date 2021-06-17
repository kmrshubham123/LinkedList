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
                temp.next = head; //node is connted through a temperory node
                head = temp;
            }
            Console.WriteLine("{0} Inserted Begnning into Linked List", head.data);

        }//End of InsertAtBeginningMethod
      
        /// <summary>
        /// UC3:-Created Linked List by appending 30 and 70 to 56
        /// </summary>
        /// <param int="data"></param>
        public void Append(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
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
            Console.WriteLine("{0} Append into Linked List", node.data);
        }
        public Node InsertBetweenPosition(int position, int data)//Function to insert a Node at required Position
        {
            if (position < 1)//list is start from 1 ,id it is less than 1 then invalid position
            {
                Console.WriteLine("Invalid");
            }
            if (position == 1)//first Position insert data and create a new node and heads Become a new Node
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 1) //checking for its not Zero and till iterating position = 1
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;

                }
                if (position != 1)// not 1 then Out of Range
                    Console.WriteLine("Position out of Range");
            }
            Console.WriteLine("{0} Inserted in Between the Linked List", data);
            return head;

        }


    }
   
}
