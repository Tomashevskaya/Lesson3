using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ: ");
            int symb = Console.Read();
            char symbol = Convert.ToChar(symb);
            switch (symbol)
            {
                case 'W':
                    Console.WriteLine("Нужно переместить фигуру вверх");
                    break;
                case 'S':
                    Console.WriteLine("Нужно переместить фигуру вниз");
                    break;
                case 'A':
                    Console.WriteLine("Нужно переместить фигуру влево");
                    break;
                case 'D':
                    Console.WriteLine("Нужно переместить фигуру вправо");
                    break;
                default:
                    Console.WriteLine("Необходимость перемещения отсутствует");
                    break;
            }
            Console.ReadLine();
        }
   }
}
