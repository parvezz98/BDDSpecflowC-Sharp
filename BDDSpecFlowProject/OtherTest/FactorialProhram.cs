using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDSpecFlowProject.OtherTest
{
    class FactorialProhram
    {
        static int value = 677;
        // int input = 0;
       static  int temp = 1;
        [Test]
       
        public static void m1() {
            for (int i = value; i >=1; i--) {
                temp = temp * i;
            }
            Console.WriteLine(temp);
        }
        public void m2()
        {
            value = 9;
          //  input = 52;

        }
    }
}
