﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Linklist
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList customLinkedList = new CustomLinkedList();
            //UC4 Deleting first node of LinkList
            customLinkedList.InsertLast(56);
            customLinkedList.InsertLast(30);
            customLinkedList.InsertLast(70);
            customLinkedList.Display();
            Console.WriteLine("\nDeleted node:"+ customLinkedList.DeleteFirstNode());
            customLinkedList.Display();
            Console.ReadLine();
        }
    }
}
