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
            Console.WriteLine("\n========================");
            //UC2:-Insert at Beginning
            list.InsertAtBeginning(70);
            list.InsertAtBeginning(30);
            list.InsertAtBeginning(56);
            list.Display();
            Console.WriteLine("\n========================");
            //UC3:-Append
            list.Append(56);
            list.Append(30);
            list.Append(70);
            list.Display();
            Console.WriteLine("\n========================");
            //UC4:-Inserted in Between LinkedList
            list.InsertBetweenPosition(2, 30);
            list.Display();
            Console.WriteLine("\n=========================");
            //UC5:-Delete first element in the Linked List
            list.Pop(56);
            list.Display();
            Console.WriteLine("\n=========================");
            //UC6:-Delete Last Element in the Linked List
            list.RemoveLastNode(70);
            list.Display();
            Console.WriteLine("\n=========================");
            //UC7:-Search for element
            list.Search(30);
            list.Display();
            Console.WriteLine("\n=========================");
            //UC8:-insert 40 after 30 to the Linked List
            list.InsertBetweenPosition(2, 40);
            list.Display();
            Console.WriteLine("\n=========================");
            //UC9:-Delete 40 from the Linked List
            list.DeleteNode(40);
            list.Display();
            Console.WriteLine("\n" + "The Size of Linked List is: " + list.Size());
            Console.WriteLine("=========================");





        }
    }
}
