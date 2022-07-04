using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDSpecFlowProject.OtherTest
{
    class CollectionDictionariAndSucclass
    {
        [Test]
        public static void testDic()
        {
            {
                Dictionary<int, string> names = new Dictionary<int, string>();
                names.Add(3, "Sonoo");
                names.Add(1, "Peter");
                names.Add(2, "James");
                names.Add(4, "Ratan");
                names.Add(5, "Irfan");
                
                foreach (KeyValuePair<int, string> kv in names)
                {
                    Console.WriteLine(kv.Key + " " + kv.Value);
                }
               var y= names[2];
                Console.WriteLine(y);
               // var y = nam

            }
        }
        [Test]
        public static void testSortedList()
        {
            {
                SortedList<int, string> Snames = new SortedList<int, string>();
                Snames.Add(3, "Sonoo");
                Snames.Add(1, "Peter");
                Snames.Add(2, "James");
                Snames.Add(4, "Ratan");
                Snames.Add(5, "Irfan");

                foreach (KeyValuePair<int, string> kv in Snames)
                {
                    Console.WriteLine(kv.Key + " " + kv.Value);
                }
                var y = Snames[2];
                Console.WriteLine(y);
                //  KeyValuePair<int, string> kt =names.GetValueOrDefault<intstring>;

            }
        }
    }
    }

