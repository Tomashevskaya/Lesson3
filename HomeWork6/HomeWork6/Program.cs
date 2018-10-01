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
            int l = str.Length;
            for (int i = l; i > 0; i--) Console.Write(str[i]); 
            Console.ReadLine();
        }
    }
}
