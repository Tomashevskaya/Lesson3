using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public class Album
    {
        public String NameOfAlbum;
        public List<Song> Songs { get; set; }
        public Artist Artist;
    }
}
