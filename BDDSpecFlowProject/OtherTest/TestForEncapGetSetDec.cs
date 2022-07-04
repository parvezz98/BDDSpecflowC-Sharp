using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDSpecFlowProject.OtherTest
{
    class TestForEncapGetSetDec
    {
        [Test]
        public static void testEncap() {
            EncapGetSetDec ec = new EncapGetSetDec();
            int age=ec.Age = 3;
            string name = ec.Name="Vani";
            Console.WriteLine(age);
            Console.WriteLine(name);

        }
    }
}
