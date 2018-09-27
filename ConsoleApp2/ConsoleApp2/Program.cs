using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму кредита: ");
            string sum = Console.ReadLine();
            Console.WriteLine("Введите проценты кредита: ");
            string per = Console.ReadLine();
            int sum1 = Convert.ToInt32(sum);
            int per1 = Convert.ToInt32(per);
            double perGen = sum1 * per1/100;
            double sumGen = sum1 + perGen;
            double sumMonth = sumGen / 12;
            Console.WriteLine("Выплаты по месяцам: ");
            Console.WriteLine("1 месяц " + sumMonth + " руб");
            Console.WriteLine("2 месяц " + sumMonth + " руб");
            Console.WriteLine("3 месяц " + sumMonth + " руб");
            Console.WriteLine("4 месяц " + sumMonth + " руб");
            Console.WriteLine("5 месяц " + sumMonth + " руб");
            Console.WriteLine("6 месяц " + sumMonth + " руб");
            Console.WriteLine("7 месяц " + sumMonth + " руб");
            Console.WriteLine("8 месяц " + sumMonth + " руб");
            Console.WriteLine("9 месяц " + sumMonth + " руб");
            Console.WriteLine("10 месяц " + sumMonth + " руб");
            Console.WriteLine("11 месяц " + sumMonth + " руб");
            Console.WriteLine("12 месяц " + sumMonth + " руб");
            Console.WriteLine("Общая сумма выплат составит " + sumGen + " руб");
            Console.ReadLine();
        }
    }
}
