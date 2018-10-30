using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public class Song
    {
        public String Name;
        public Artist Artist;
        public Genres Genre { get; set; }
        public Album Album { get; set; }

        public string Lyrics { get; set; }
        public string Title { get; set; }
        public double Duration { get; set; }

        public Song(string title = "Unknown", string lyrics = "Unknown", double duration = 0)
        {
            this.Title = title;
            this.Lyrics = lyrics;
            this.Duration = duration;

        }
    }
}
