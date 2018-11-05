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
            //ArrayListPoem();
            //NeighborList();
            Dictionary();
            Console.ReadLine();
        }


            public static void ArrayListPoem()
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
    
        public class Song
        {
            public string Lyrics;

            public override string ToString()
            {
                return this.Lyrics;
            }
        }
             public class Neighbor
             {
                public string FullName { get; set; }
                public string FlatNumber { get; set; }
                public int PhoneNumber { get; set; }

                public override string ToString()
                {
                return "Имя: " + FullName + "\n" + "Номер телефона: " + PhoneNumber;
                }
             }

            public static void NeighborList()
            {
            Neighbor person = new Neighbor();
             List<Neighbor> floorNeighbors = new List<Neighbor>();

            floorNeighbors.Add(new Neighbor() { FullName = "Александр", FlatNumber = "34", PhoneNumber = 8949855 });
            floorNeighbors.Add(new Neighbor() { FullName = "Анастасия", FlatNumber = "35", PhoneNumber = 8894729 });
            floorNeighbors.Add(new Neighbor() { FullName = "Ирина", FlatNumber = "37", PhoneNumber = 7164656 }); 

            Console.WriteLine("Введите номер квартиры: ");
            string numb = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Данные о соседе: \n{0}", floorNeighbors.Find(x => x.FlatNumber.Contains(numb)));

            }
        public static void Dictionary()
        {
            Dictionary<int, Neighbor> dict = new Dictionary<int, Neighbor>(3);

            dict.Add(34, new Neighbor() { FullName = "Александр", PhoneNumber = 8949855 });
            dict.Add(35, new Neighbor() { FullName = "Анастасия", PhoneNumber = 8894729 });
            dict.Add(37, new Neighbor() { FullName = "Ирина", PhoneNumber = 7164656 });


            Console.WriteLine("Введите номер квартиры: ");
            int numb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Данные о соседе: \n{0}", dict[numb]);
        }
    }
    
}
