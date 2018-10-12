using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lines_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввведите стихотворение: ");
            string poem = Console.ReadLine();
            string poem1 = poem.Replace("о", "а");
            string poem2 = poem1.Replace("л", "ль");
            string poem3 = poem2.Replace("ть", "т");
            string[] poem4 = poem3.Split(',');
            foreach (var item in poem4)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
