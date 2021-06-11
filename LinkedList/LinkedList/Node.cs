using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class Node
    {   // Variables
        public int data;// actual data that has to be store in list = data
        public Node next;// refer to the next node of the list
        /// <summary>
        /// constructor to initillize data and next variables
        /// </summary>
        public Node(int data)
        {
            this.data = data;
            next = null;
        }//end of Public Node
      
    }
}
