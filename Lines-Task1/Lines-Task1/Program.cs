using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lines_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввведите предложение: ");
            string sent = Console.ReadLine();
            if (sent.Length > 13) sent = sent.Remove(13);
            Console.WriteLine(sent + "...");
            Console.ReadLine();
        }
    }
}
