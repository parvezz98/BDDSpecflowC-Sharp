using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDSpecFlowProject.Utility
{
   public class DateAndTime
    {
       public static string currentTimeandDate = null;
        public static string getCurrentDateAndTime() {
            DateTime d = DateTime.Now;
            currentTimeandDate = d.ToString();
            return currentTimeandDate;
        }
    }
}
