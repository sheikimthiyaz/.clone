using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3classcsharp
{
    class Employee
    {
        string Name;
        int age;
        string degree;
        void Displaydetails()
        {
            Console.WriteLine("Name;{0}||age:{1}||Degree:{2}", Name, age, degree);
        }
        static void Main()
        {
            Employee employee1 = new Employee();
            employee1.Name = "sai";
            employee1.age = 23;
            employee1.degree = "m.tech";
            Employee employee2 = new Employee();
            employee2.Name = "imthu";
            employee2.age = 26;
            employee2.degree = "m.tech";
            employee1.Displaydetails();
            employee2.Displaydetails();
            Console.Read();


        }

         
    }
}
