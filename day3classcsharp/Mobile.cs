using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3classcsharp
{
    class Mobile
    {
       internal static string CompanyName;
       internal string Modelname;
       internal void mobile()
        {
            Console.WriteLine("CompanyName:{0}||ModelName:{1}", CompanyName, Modelname);
        }
        internal static void getdata()
        {
            Console.WriteLine("CompanyName:{0}", CompanyName);
        }
    }
    class staticeg2
    {
        float f = 34.29f;
        internal static void Info()
        {
            Console.WriteLine("static Method");

        }
        static void Main()
        {

            Mobile mobile = new Mobile();
          
            Mobile.CompanyName = "Motorola";
            Mobile.getdata();
            Info();
            Console.ReadKey();

        }

                                              
                                                              
        }
    }


