using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDSpecFlowProject.OtherTest
{
    public class ConsTest
    {
        static  ConsTest(){
            Console.WriteLine("Test const");

        }
        static void simpleMethod()=> Console.WriteLine("Non Constracxtuctor");
        
        [Test]
        public void mainn()
        {
            //ConsTest d=  new ConsTest();
           // ConsTest();
            simpleMethod();
            
        }
    }
}
