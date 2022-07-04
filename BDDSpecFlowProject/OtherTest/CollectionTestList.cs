using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDSpecFlowProject.OtherTest
{
    class CollectionTestList
    {
        public CollectionTestList() {
            Console.WriteLine("Const is call");
        }
        [Test]
        public void testListAndIList() {
            IList<Object> lst = new List<Object>();
            lst.Add("Jac");
            lst.Add("Sam");
            lst.Add("Max");
            lst.Add("iax");
            lst.Add("Pax");
            lst.Add("Mqax");
            lst.Add('T');
            lst.Add('A');
            lst.Add(786);
           lst.Add(100);
           lst.RemoveAt(lst.Count-1);
            foreach (Object h in lst)  {Console.Write(h+","); }
            Console.WriteLine("Count- "+lst.Count);
            LinkedList<Object> lst1 = new LinkedList<Object>();
            lst1.AddFirst("Zzambo");
            lst1.AddFirst("Xxambo");
            lst1.AddFirst("Ppambo");
            lst1.AddLast(12);
            lst1.AddFirst(001);
            
            foreach (Object h in lst1) { Console.Write(h + ","); }
        }
       
    }
}
