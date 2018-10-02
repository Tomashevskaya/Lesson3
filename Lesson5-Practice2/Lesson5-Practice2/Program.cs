using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Загадайте число от 1 до 100");
            Console.WriteLine("Это число меньше или равно 50? (Да-'+', нет '-' )");
            string answer1 = Console.ReadLine();
            if (Convert.ToChar(answer1)=='+')
            {
                Console.WriteLine("Это число равно 50? (Да-'+', нет '-' )");
                string answer2 = Console.ReadLine();
                if (Convert.ToChar(answer2) == '+') Console.WriteLine("Вы загадали число 50");
                else Console.WriteLine("Это число меньше или равно 25? (Да-'+', нет '-' )");
                string answer3 = Console.ReadLine();
                if (Convert.ToChar(answer3) == '+') Console.WriteLine("Вы загадали число 50");
            }

        }
    }
}
