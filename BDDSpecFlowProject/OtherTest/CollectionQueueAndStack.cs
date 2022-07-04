using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDSpecFlowProject.OtherTest
{
    class CollectionQueueAndStack
    {
        [Test, Order(2)]
        public static void testStack() {
            Stack myStack = new Stack();

            // Inserting the elements into the Stack
            myStack.Push("1st Element");
            myStack.Push("2nd Element");
            myStack.Push("3rd Element");
            myStack.Push("4th Element");
            myStack.Push("5th Element");
            myStack.Push("6th Element");
            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Peek());
            foreach (var t in myStack) {
                Console.WriteLine(t);
            }
        }
        [Test, Order(-1)]
        public static void testQueue()
        {
            Queue myStack2 = new Queue();

            // Inserting the elements into the Stack
            myStack2.Enqueue("1st Element");
            myStack2.Enqueue("2nd Element");
            myStack2.Enqueue("3rd Element");
            myStack2.Enqueue("4th Element");
            myStack2.Enqueue("5th Element");
            myStack2.Enqueue("6th Element");
            Console.WriteLine(myStack2.Peek());
         //   Console.WriteLine(myStack2.Offer());
            Console.WriteLine(myStack2.Peek());
            foreach (var t in myStack2)
            {
                Console.WriteLine(t);
            }
        }
    }
}
