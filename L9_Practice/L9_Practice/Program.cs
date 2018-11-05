using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinates cords = new Coordinates { x = 1, y = 2, z = 3 };

            (int x, int y, int z) = cords;

            double result = Math.Sqrt(x * x + y * y + z * z);
            Console.WriteLine("Длина вектора равна {0}", result);

            DateTimeDec date1 = new DateTimeDec();
            ( _, _, _, int hour, int min, int sec) = date1;
            Console.WriteLine("Текущее время:\n{0}:{1}:{2}", hour,min,sec);
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

    class DateTimeDec
    {
        DateTime date = DateTime.Now;

        public void Deconstruct(out int y, out int m, out int d, out int hour, out int min, out int sec)
        {
            y = date.Year;
            m = date.Month;
            d = date.Day;
            hour = date.Hour;
            min = date.Minute;
            sec = date.Second;
        }
        
    }

}

