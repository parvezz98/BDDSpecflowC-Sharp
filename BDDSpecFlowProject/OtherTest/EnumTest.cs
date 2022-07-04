using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDSpecFlowProject.OtherTest
{
  public  class EnumTest
    {
        enum month
        {    // following are the data members
            jan=101,
            feb,
            mar,
            apr,
            may=43

        }
        [Test]
        public void enumTest() {
            int y = (int)month.mar;
            Console.WriteLine(y);
            //month.apr = 322;
        }
    }
}
