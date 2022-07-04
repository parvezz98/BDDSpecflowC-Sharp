using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDSpecFlowProject.OtherTest
{
    class SetCollection
    {
        [Test]
        public static void setCollection() {
            ISet<int> stt = new HashSet<int>();
            stt.Add(32); stt.Add(21); stt.Add(30); stt.Add(45); stt.Add(6); stt.Add(78);
            stt.Add(50); stt.Add(33); stt.Add(33); stt.Add(09); stt.Add(67); stt.Add(00);
            foreach (int y in stt) {
                Console.Write(y+",");
                    }
            Console.WriteLine("");
            ISet<int> stt2 = new SortedSet<int>();
            stt2.Add(32); stt2.Add(21); stt2.Add(09); stt2.Add(45); stt2.Add(6); stt2.Add(78);
            stt2.Add(50); stt2.Add(09); stt2.Add(43); stt2.Add(09); stt2.Add(67); stt2.Add(00);
            foreach (int y in stt2)
            {
                Console.Write(y+",");
            }
        }
        
       
}
    
}
