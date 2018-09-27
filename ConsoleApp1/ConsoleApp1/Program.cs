using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус: ");
            string r1 = Console.ReadLine();
            int r2 = Convert.ToInt32(r1);
            double radius = 3.14 * r2 * r2;
            Console.Write("Площадь круга: "+ radius);
            Console.ReadLine();
        }
    }
}
