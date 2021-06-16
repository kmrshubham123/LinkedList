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
        public void InsertBetweenPosition(int position, int data)//Function to insert a Node at required Position
        {
            Node node = new Node(data);
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            else if (position == 1)//if position is 1 then new node is set infornt of head node
            {
                node.next = head;
                head = node; 
            }
            else
            {
                Node temp = head, prev = head, after;
                for (int i = 1; i < position; i++)
                {
                    temp = temp.next;
                    if (i == position - 2)
                    {
                        prev = temp;
                    }
                }
                after = temp;
                prev.next = node;
                node.next = after;
            }
             Console.WriteLine("{0} Inserted in Between the Linked List", node.data);
        }
        public Node Pop(int data)//Methd for Delete Node
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next; //head is link with Next node and Starting or previous node become null 
            Console.WriteLine("{0} Delete into Linked List", data);
            return this.head;
        }
        public Node RemoveLastNode(int data)//Method to Delete last element to linked list
        {
            if (head == null)// if the first node is null or only one node then, they return null
            {
                return null;
            }
            if(head.next==null)
            {
                return null;
            }
            Node NewNode = head;
            //create and Extra Space Secondlast and traverse the linked list till the second last node
            while(NewNode.next.next!=null)//the second Last node and make the next pointer of that node null
            {
                NewNode = NewNode.next;
            }//Delete the last node,next node of the 2nd last node delete and value of 2nd last node to null
            NewNode.next = null;
            Console.WriteLine("{0} Delete Last Element in List", data);
            return head;
        }
        



    }
   
}
