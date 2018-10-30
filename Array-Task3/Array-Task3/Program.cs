using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] nums = { { 1, 2, 3 }, { 6, 5, 4 } };
            Console.WriteLine("Максимальное значение первого ряда: " + nums[0,2]);
            Console.WriteLine("Максимальное значение второго ряда: " + nums[1,0]);
            Console.ReadLine();
        }
    }
}
