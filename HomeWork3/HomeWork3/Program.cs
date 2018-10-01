using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово: ");
            string str = Console.ReadLine();
            int l = str.Length;
            int k = 0;
            for (int i = 0; i < l; i++)
            {
                if (str[i] == 'a') k += 1;
            }
            Console.WriteLine("Количество букв а = " + k);
            Console.ReadLine();
        }
    }
}
