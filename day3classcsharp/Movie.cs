using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3classcsharp
{
    class Movie
    {
        int id;
        string Moviename;

        internal Movie(int id, string Moviename)
        {
            this.id = id;
            this.Moviename = Moviename;
        }
        internal void Displaymovie()
        {
            Console.WriteLine("id:{0}||Moviename:{1}", id, Moviename);
        }

    }
    class arrayobject
    {
        static void Main()
        {
            Movie movie = new Movie(101, "yavadu");
            movie.Displaymovie();
            Console.WriteLine(" Enter size");
            int size = Convert.ToInt32(Console.ReadLine());
            Movie[] mov = new Movie[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(" Enter id and moviename");
                int id = Convert.ToInt32(Console.ReadLine());
                string moviename = Console.ReadLine();
                mov[i] = new Movie(id, moviename);
            }
            for (int i = 0; i < size; i++)
            {

            }
        }
    }
}
