using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplelink
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int i)
        {
            data = i;
            next = null;
        }
        public void Display()
        {
            Console.Write(" "+ data);
            if (next != null)
            {
                next.Display();
            }
        }
    }
 /*   class programme
    {
        static void Main(string[] args)
        {
            Node mynode = new Node(56);
            mynode.next = new Node(30);
            mynode.next.next = new Node(70);
            mynode.Display();
        }
    }*/
}
