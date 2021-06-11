using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++++Welcome to the Linked List+++++");
            SingleLinkedList list = new SingleLinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            
        }
    }
}
