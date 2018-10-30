using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList poem = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите строку");
                string s = Console.ReadLine();
                poem.Add(s);
            }
            poem.Sort();
            poem.RemoveAt(poem.Count - 1);
            object[] poem2 = poem.ToArray();

            foreach (var item in poem2)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
