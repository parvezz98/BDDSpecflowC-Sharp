using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDSpecFlowProject.OtherTest
{
    delegate int mineDele(int i, int y);

    class DelegatesTest
    {
       
        public static int Add(int i, int u)
        {
            return i + u;
        }
        public static int Multi(int i, int u)
        {
            return i * u;
        }
        [Test]
        public static void delTest() {
            mineDele dd = new mineDele(Add);
            int result = dd(67,22);
            Console.WriteLine(result);
            dd = new mineDele(Multi);
           int mm= dd(67, 22);
            Console.WriteLine(mm);
        }
    }
}
