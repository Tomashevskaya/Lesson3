using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public class Artist
    {
        
        public string Name { get; set; }
        public List<Song> Songs { get; set; }
        public Album[] Albums { get; set; }

        public Artist()
        {
            Console.WriteLine();
        }
        public Artist(int number)
        {
            int x1 = number;
            Console.WriteLine("Проигрывается песня № "+ x1);
        }
        public Artist(int number, string nameOfAlbum)
        {
            int x1 = number;
            string x2 = nameOfAlbum;
            Console.WriteLine("Проигрывается песня № " + x1 + " из альбома " + x2);
        }
    }
}
