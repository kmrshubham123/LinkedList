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
        /// <summary>
        ///   //UC4:-Inserted in Between LinkedList
        /// </summary>
        /// <param int="position"></param>
        /// <param int="data"></param>
        /// <returns></returns>
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

        public Node Pop(int data)//Method for Delete Node
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
            if (head.next == null)
            {
                return null;
            }
            Node NewNode = head;
            //create and Extra Space Secondlast and traverse the linked list till the second last node
            while (NewNode.next.next != null)//the second Last node and make the next pointer of that node null
            {
                NewNode = NewNode.next;
            }//Delete the last node,next node of the 2nd last node delete and value of 2nd last node to null
            NewNode.next = null;
            Console.WriteLine("{0} Delete Last Element in List", data);
            return head;
        }
        /// <summary>
        /// UC7:-Search LinkedList to find the node
        /// </summary>
        /// <param int="data"></param>
        /// <returns></returns>
        public Node Search(int data) //Method to use Search Data
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == data)
                {
                    Console.WriteLine("{0} present in Linked List", data);
                    return temp;
                }
                temp = temp.next;
            }
            Console.WriteLine("{0} Not present in Linked List", data);
            return null;
        }
        /// <summary>
        /// UC9:-Method to Delete node from the linked list
        /// </summary>
        /// <param name="data"></param>
        public void DeleteNode(int data)
        {
            Node temp = head, prev = null;
            if (temp != null && temp.data == data)
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.data != data)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
                return;

            prev.next = temp.next;
            Console.WriteLine("{0} Element is Deleted", data);
        }
        /// <summary>
        /// UC9:-Method to display size of Linked List
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            Node temp = head;
            int size = 0;
            while (temp != null)
            {
                size++;
                temp = temp.next;
            }
            return size;
        }
    }
}
