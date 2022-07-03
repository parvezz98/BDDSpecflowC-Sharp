using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using excel = Microsoft.Office.Interop.Excel;

namespace BDDSpecFlowProject.Utility
{
   public class ExcelData
    {
      
        public static String getData(int row, int col)
        {
            String value="";
            excel.Application x1app = new excel.Application();
           // excel.Workbook x1Wb = x1app.Workbooks.Open(@ConfigurationManager.AppSettings["TestDataPath"]);
            excel.Workbook x1Wb = x1app.Workbooks.Open(@"C:\Users\user\source\repos\BDDSpecFlowProject\BDDSpecFlowProject\Data\ApplicationTestData.xlsx");
            excel.Worksheet x1Ws = (excel.Worksheet)x1Wb.Sheets[1];
            excel.Range x1range = x1Ws.UsedRange;
          //  value = x1range.Cells[row][col].value2;
           // value = Convert.ToString(x1range.Cells[row][col].value2);
            x1app.Quit();
            return value;
        }
        [Test]
        public static void ReadData() {
           string y= getData(1, 1);
        }
    }
}
