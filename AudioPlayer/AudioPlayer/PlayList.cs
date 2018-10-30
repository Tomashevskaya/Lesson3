using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public class PlayList
    {
        public String NameOfPlayList;
        public List<Song> Songs { get; set; }
        public PlayList(string name, double duration)
        {
            Console.WriteLine("Название песни: {0}, продолжительность: {1} минут", name, duration);
        }
        public void Add(params Song[] songs)
        {
            Songs = songs.ToList<Song>();
        }
    }
}
