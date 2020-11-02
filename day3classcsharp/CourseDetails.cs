using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3classcsharp
{
    class Coursedetails
    {
        int Cid;
        string Cname;
        int Fee;
       internal static string Insititution ;
        internal Coursedetails(int cid, string Cname, int Fee,string insititution)
        {
            this.Cid = cid;
            this.Cname = Cname;
            this.Fee = Fee;
        }
        internal void DisplayCoursedetails()
        {
            Console.WriteLine("Cid:{0}||cname:{1}||fee:{2}", Cid, Cname, Fee, Insititution);
        }

        class arrayeg3
        {
            static void Main()
            {
                Console.WriteLine("enter college name");
                Coursedetails.Insititution = Console.ReadLine();
                Coursedetails[] cou = new Coursedetails[2];
                for (int i = 0; i < 2; i++)
                {


                    Console.WriteLine("enter cid,cname and fee");
                    int cid = Convert.ToInt32(Console.ReadLine());
                    string cname = Console.ReadLine();
                    int Fee = Convert.ToInt32(Console.ReadLine());
                    cou[i] = new Coursedetails(cid, cname, Fee,Insititution);
                }
                for (int i = 0; i < 2; i++)
                {
                    cou[i].DisplayCoursedetails();
                    Console.ReadKey();

                }
            }
        }
    }
}
