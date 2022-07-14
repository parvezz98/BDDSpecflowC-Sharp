using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDSpecFlowProject.OtherTest
{
    interface FirstInterface
    {
      
      public  void m1First();
        void m2First();
        static void m3First()
        {
            Console.WriteLine("Test i inrerface");
        }
        //private void m4First()
        //{
        //    Console.WriteLine("Test Private inrerface");
        //}
    }
}
