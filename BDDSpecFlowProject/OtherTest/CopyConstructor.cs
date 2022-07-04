using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDSpecFlowProject.OtherTest
{
    class CopyConstructor
    {
        private string name;
        private int age;
        public CopyConstructor(string Name,int Age) {
            name = Name;
            age = Age;
        }
        public CopyConstructor(CopyConstructor obj)
        {
            name = obj.name;
            age = obj.age;
        }
        [Test]
        public static void testCopyCons() {
            CopyConstructor sb = new CopyConstructor("Jax", 23);
            Console.WriteLine(sb.name +"  ^^^^^^^  " + sb.age);
        }
    }
}
