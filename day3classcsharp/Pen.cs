using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3classcsharp
{
    class Pen
    {
        public string brand;
        internal string color;
        internal Pen(string b, string color)
        {
            this.brand = "cello";
            this.color = "pen";
        }
        internal void DisplayPen()
        {
            Console.WriteLine("brand:{0},||color:{1}", brand, color);
        }
    }
    class constructoreg
    {
        static void Main()
        {
            Pen pen = new Pen("parker", "blue");
            pen.DisplayPen();
            Console.ReadKey();
        }
    }

        }
  

