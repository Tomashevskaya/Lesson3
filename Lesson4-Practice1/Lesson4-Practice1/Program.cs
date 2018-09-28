using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число Х");
            String x1 = Console.ReadLine();
            Console.WriteLine("Введите число Y");
            String y1 = Console.ReadLine();
            int x = Convert.ToInt32(x1);
            int y = Convert.ToInt32(y1);
            if (x >= 0 && y >= 0)
            {
                if (x == y) Console.WriteLine("Значения равны");
                if (x > y) Console.WriteLine("Значение Х больше Y на " + (x - y));
                if (x < y) Console.WriteLine("Значение Y больше Х на " + (y - x));
                }
            Console.ReadLine();
        }
    }
}
