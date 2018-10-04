using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 100;
            Console.WriteLine("Задумайте число от 1 до 100");
            while (max > min)
            {
                int middle = ((max - min) / 2) + min;
                Console.WriteLine("Задуманное число больше " + middle + "? (+/-)");
                string answer = Console.ReadLine();
                char ans = Convert.ToChar(answer);
                switch (ans)
                {
                    case '+':
                        min = middle + 1;
                        middle = min + middle;
                        break;
                    case '-':
                        max = middle;
                        break;
                }
            }
            if (max == min) Console.WriteLine("Это число " + max);
            Console.ReadLine();
        }
    }
}
