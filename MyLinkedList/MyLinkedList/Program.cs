using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLinkedList
{

    class Program
    {

        static void Main(string[] args)
        {
            myLinkedList myLinkedList = new myLinkedList();
            myLinkedList.AddToEnd(10);
            myLinkedList.AddToEnd(11);
            myLinkedList.AddToEnd(12);
            myLinkedList.AddToEnd(14);
            myLinkedList.AddToBeginning(15);
            myLinkedList.AddToBeginning(16);
            myLinkedList.AddToBeginning(17);
            myLinkedList.Print();
            Console.ReadLine();

        }
    }
}

