using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            NewMethod();
        }

        private static void NewMethod()
        {
            Console.Write("Введите число 1: ");
            string numb1 = Console.ReadLine();
            Console.Write("Введите число 2: ");
            string numb2 = Console.ReadLine();
            Console.Write("Какой оператор использовать? (+/-) ");
            string oper = Console.ReadLine();
            int n1 = Convert.ToInt32(numb1);
            int n2 = Convert.ToInt32(numb2);
            char oper1 = Convert.ToChar(oper);
            char s1 = '+';
            int rez;
            rez = oper1 == s1 ? n1 + n2 : n1 - n2;
            Console.WriteLine("Результат вычисления будет равен: ");
            String result = Console.ReadLine();
            int result1 = Convert.ToInt32(result);
            if (result1 == rez)
            {
                Console.WriteLine("Правильно");
            }
            else
                Console.WriteLine("Неправильно");
            if (result1 > rez)
            {
                Console.WriteLine("Должно быть меньше");
            }
            if (result1 < rez)
            {
                Console.WriteLine("Должно быть больше");
            }
            if (result1 !=rez)
            {
                Console.WriteLine("Вторая попытка. Результат вычисления будет равен: ");
                String res2 = Console.ReadLine();
                int result2 = Convert.ToInt32(res2);
                if (result2 == rez)
                {
                    Console.WriteLine("Правильно");
                }
                else
                {
                    Console.WriteLine("Неправильно");
                }
                if (result2 > rez)
                {
                    Console.WriteLine("Должно быть меньше");
                }
                if (result2 < rez)
                {
                    Console.WriteLine("Должно быть больше");
                }
                Console.WriteLine("Последняя попытка:");
                String res3 = Console.ReadLine();
                int result3 = Convert.ToInt32(res3);
                if (result3 == rez)
                {
                    Console.WriteLine("Правильно");
                }
                else
                {
                    Console.WriteLine("Опять неправильно. Скорее всего, вы - гуманитарий:) ");
                }

            }
            Console.Read();
        }
    }
}
