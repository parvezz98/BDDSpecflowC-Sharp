using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDSpecFlowProject.OtherTest
{
    class TestingInterfaceForClass : FirstInterface
    {
       
      public void m1First()
        {
            Console.WriteLine("Test i inrerface");
        }
       
     
         public  void m2First() {
            Console.WriteLine("Test i inrerface");
           // FirstInterface.m3First;
        }
       
        static void m3First()
        {
            Console.WriteLine("Test i inrerface");
        }


    }
}
