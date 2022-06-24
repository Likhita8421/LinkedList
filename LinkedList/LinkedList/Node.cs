using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node
    {
        public int data;    //store elements over there
        public Node next;   // hold the contact position of the next element tht is going to be store in next node
        public Node(int data) // constructor
        {
            this.data = data;
        }
    }
}
