using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3classcsharp
{
    class Student
    {
        internal static string collegename;
        string name;
        string dept;
        internal Student(string name, string dept)
        {
            this.name = name;
            this.dept = dept;
        }
        internal void displaydetails()
        {

            Console.WriteLine("name:{0}||dept:{1}", name, dept, collegename);

        }
        class staticEg
        {
            static void Main()
            {
                //accesing static variable by class name
                Console.WriteLine("enter college name");
                Student.collegename = Console.ReadLine();

                string name, dept;
                Console.WriteLine("enter no of students");
                int no = Convert.ToInt32(Console.ReadLine());
                Student[] student = new Student[no];
                for (int i = 0; i < student.Length; i++)
                {
                    Console.WriteLine("enter name and dept");
                    name = Console.ReadLine();
                    dept = Console.ReadLine();
                    student[i] = new Student(name, dept);
                }
                for (int i = 0; i < student.Length; i++)
                {

                    student[i].displaydetails();
                    Console.ReadKey();
                }
               

            }
            


        }





    }
}