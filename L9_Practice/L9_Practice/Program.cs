using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9_Practice
{
    class Program
    {
        /*static void Main(string[] args)
        {
           
                Coordinates coord = new Coordinates() {x=1, y=2,z=3 };
                (int x, int  y, int z) = coord;
                double result = Math.Sqrt(x * x + y * y + z * z);
                Console.WriteLine("Длина вектора равна {0}", result);
        }


        struct Coordinates
        {
            public int x { get; set; }
            public int y { get; set; }
            public int z { get; set; }
        }
        public void Deconstruct(out int X, out int Y, out int Z)
        {
            X = this.x;
            Y = this.y;
            Z = this.z;
        }
       }*/
        static void Main(string[] args)
        {
            Coordinates cords = new Coordinates { x = 1, y = 2, z = 3 };

            (int x, int y, int z) = cords;

            double result = Math.Sqrt(x * x + y * y + z * z);
            Console.WriteLine("Длина вектора равна {0}", result);
            Console.ReadLine();

        }
    }
    struct Coordinates
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }


        public void Deconstruct(out int X, out int Y, out int Z)
        {
            X = this.x;
            Y = this.y;
            Z = this.z;
        }


    }
}

