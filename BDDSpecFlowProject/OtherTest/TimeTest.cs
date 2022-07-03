using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDSpecFlowProject.OtherTest
{
    class TimeTest
    {
        [Test]
        public static void m1()
        {
            Console.Write("Current Date and Time is : ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());
          //  Console.ReadLine();
        }
    }
}
