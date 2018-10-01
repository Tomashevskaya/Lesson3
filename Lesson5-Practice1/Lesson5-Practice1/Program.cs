using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            string a1 = Console.ReadLine();
            int a = Convert.ToInt32(a1);
            Console.WriteLine("В какую степень возвести? ");
            string n1 = Console.ReadLine();
            int n = Convert.ToInt32(n1);
            int b = 1;
            int rez = 1;
            while (b++ <= n)
            {
                rez = rez * a;
            }
            Console.Write("Результат равен: " + rez);
            Console.ReadLine();

        }
    }
}
