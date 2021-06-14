using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++++Welcome to the Linked List+++++");
            //UC1:-Simple LinkedList
            SingleLinkedList list = new SingleLinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
           //UC2:-Insert at Beginning
            list.InsertAtBeginning(70);
            list.InsertAtBeginning(30);
            list.InsertAtBeginning(56);
            list.Display();

            
        }
    }
}
