using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDSpecFlowProject.OtherTest
{
    class SortArray
    {
        [Test]
        public static void m1() {
            Console.WriteLine("Test");
            int[]  a = { 0, 1, 0, 1, 0, 1 };
            //int[] ad= new int[5];
            //ad[0] = 0;
            int temp = 0;
            for (int i = 0; i < a.Length; i++) {
                for (int j = 1 + i; j < a.Length; j++) {
                    if (a[i] > a[j]) {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
                
            }
            foreach (int k in a)
            {
                Console.Write(k);
            }

        }
    }
}
