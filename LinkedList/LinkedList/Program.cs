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
            list.Display();
            Console.WriteLine("========================");
           //UC2:-Insert at Beginning
            list.InsertAtBeginning(70);
            list.InsertAtBeginning(30);
            list.InsertAtBeginning(56);
            list.Display();
            Console.WriteLine("========================");
            //UC3:-Append
            list.Append(56);
            list.Append(30);
            list.Append(70);
            list.Display();
            Console.WriteLine("========================");
            //UC4:-Inserted in Between LinkedList
            list.InsertBetweenPosition(2, 30);
            list.Display();
            Console.WriteLine("=========================");
            //UC5:-Delete first element in the Linked List
            list.Pop(56);
            list.Display();
            Console.WriteLine("=========================");
            //UC6:-Delete Last Element in the Linked List
            list.RemoveLastNode(70);
            list.Display();


        }
    }
}
