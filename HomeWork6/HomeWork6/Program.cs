using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово: ");
            string str = Console.ReadLine();
            string reserve = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
                reserve += str[i];
            Console.WriteLine(reserve);
            
            Console.ReadLine();
        }
    }
}
