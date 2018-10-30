using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> poem = new List<Song>();
            for (int i = 0; i < 5; i++)
            {
                var song = new Song();
                Console.WriteLine("Введите строку");
                song.Lyrics = Console.ReadLine();
                poem.Add(song);
            }
            //poem.Sort();
            poem.RemoveAt(poem.Count - 1);
            object[] poem2 = poem.ToArray();

            foreach (var item in poem2)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }
    }
    public class Song
    {
        public string Lyrics;

        public override string ToString()
        {
            return this.Lyrics;
        }
    }
    
}
