using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
   public class AudioPlayer
    {
        private int _volume;

       

        Artist objectArtist = new Artist();
        Album objectAlbum = new Album();

        public bool Locked { get; set; }
        public bool IsPlaying { get; set; }
        public Song PlayingSong { get; set; }
        public List<Song> Songs { get; set; }
        public bool Playing { get; set; }



        public int Volume
        {
            get { return _volume; }
            set
            {
                if (value < 0)
                {
                    _volume = 0;
                }
                else if (value > 100)
                {
                    _volume = 100;
                }
                else
                {
                    _volume = value;
                }

                
            }
           
        }

        

        public void VolumePlus()
        {
            this.Volume++;
           // _volume++;
        }
        public void VolumeMinus()
        {
            this.Volume--;
            //_volume--;
        }
        public void Add( Artist artist)
        {
           Songs = artist.Songs;
        }
        public void Add(params Song[] songs)
        {
            Songs = songs.ToList();
        }
        public void Add(Album album)
        {
            Songs = album.Songs;
        }
        public void Add(PlayList playList)
        {
            Songs = playList.Songs;
        }
        


        public bool Play(out Song playingSong, bool loop = false)
        {
            playingSong = PlayingSong = PlayingSong ?? Songs[0];
            if (Locked == false)
            {
                IsPlaying = true;
            }
            if (IsPlaying)
            {
                int times = loop ? 5 : 1;
                for (int i = 0; i < times; i++)
                {
                    foreach (var song in Songs)
                    {
                        PlayingSong = song;
                        Console.Clear();
                        Console.WriteLine(PlayingSong.Title + ": " + PlayingSong.Lyrics);
                        System.Threading.Thread.Sleep(2000);
                    }
                }
            }
            return IsPlaying;
            
        }
        public bool Stop(out Song playingSong)
        {
            playingSong = PlayingSong;
            if (Locked==false)
            {
                Playing = false;
            }
            return Playing;
        }

        public bool Lock()
        {
            return Locked = true;
        }
        public bool Unlock()
        {
            return Locked = false;
        }


        public void Shuffle()
        {
            List<Song> suffledSongs = new List<Song>();
            int step = 3;
            for (int i = 0; i < step; i++)
            {
                int songNumber = i;

                while (songNumber < Songs.Count)
                {
                    suffledSongs.Add(Songs[songNumber]);
                    songNumber += step;
                }
            }

            Songs = suffledSongs;
        }


        public void SortByTitle()
        {
            List<string> names = new List<string>();
            List<Song> sorted = new List<Song>();

            foreach (var song in Songs)
            {
                names.Add(song.Title);
            }

            names.Sort();

            foreach (var name in names)
            {
                foreach (var song in Songs)
                {
                    if (song.Title == name)
                    {
                        sorted.Add(song);
                        continue;
                    }
                }
            }

            Songs = sorted;
        }
    }
}

 
