using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число 1: ");
            string numb1 = Console.ReadLine();
            Console.Write("Введите число 2: ");
            string numb2 = Console.ReadLine();
            Console.Write("Какой оператор использовать? ('+'/'-'/'*'/'/') ");
            string oper1 = Console.ReadLine();
            int n1 = Convert.ToInt32(numb1);
            int n2 = Convert.ToInt32(numb2);
            char oper = Convert.ToChar(oper1);
            char s1 = '+';
            char s2 = '-';
            char s3 = '*';

            if (oper == s1)
            {
                int rez = n1 + n2;
                Console.WriteLine("Результат вычисления будет равен: " + rez);
            }
            else if (oper == s2)
            {
                int rez = n1 - n2;
                Console.WriteLine("Результат вычисления будет равен: " + rez);
            }
            else if (oper == s3)
            {
                int rez = n1 * n2;
                Console.WriteLine("Результат вычисления будет равен: " + rez);
            }
            else
            {
                int rez = n1 / n2;
                Console.WriteLine("Результат вычисления будет равен: " + rez);
            }
            Console.ReadLine();
        }
    }
}
