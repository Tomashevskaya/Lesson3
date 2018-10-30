using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public class Program
    {
        public static void Main(string[] args)
        {
           var player = new AudioPlayer();
          /* Console.WriteLine(player.Volume);
            player.Volume = 300;
            Console.WriteLine(player.Volume);

            player.VolumePlus();
            player.VolumePlus();
            player.VolumePlus();
            Console.WriteLine(player.Volume);  */
            
            Console.WriteLine(player.Play(out Song song));
            Console.ReadLine();
        }

        private static void CreatePlayerItems(out Song[] songs, out Artist artist, out Album album)
        {
            artist = new Artist() { Name = "Sia", Songs = new List<Song>(), Albums = new Album[1] };
            album = new Album() { Artist = artist, Title = "Still loving you", Songs = new List<Song>() };
            songs = CreateSongs(artist, album);

            artist.Albums[0] = album;

            artist.Songs = new List<Song>() { songs[0], songs[1], songs[2] };
            album.Songs = new List<Song>() { songs[3], songs[4], songs[1] };
        }

        private static Song[] CreateSongs(Artist artist, Album album)
        {
            return new Song[] {
            new Song()
            {
                    Title = "Elastic heart(1)",
                    Duration = 4.01,
                    Lyrics = @"And another one bites the dust...",
                    Album = album,
                    Artist = artist,
                    Genre = Genres.Pop  
                },
            new Song()
            {       Title = "The greatest(2)",
                    Duration = 3.59,
                    Lyrics = @"Uh-oh, running out of breath, but I...",
                    Album = album,
                    Artist = artist,
                    Genre = Genres.Dance   },
            new Song()
            {
                    Title = "Cheap Thrills(3)",
                    Duration = 3.20,
                    Lyrics = @"Come on, come on, turn the radio on. It's Friday night...",
                    Album = album,
                    Artist = artist,
                    Genre = Genres.Pop  | Genres.Dance},
            new Song()
            {       Title = "Chandelier(4)",
                    Duration = 3.35,
                    Lyrics = @"And I'm holding on for dear life, won't look down...",
                    Album = album,
                    Artist = artist,
                    Genre = Genres.Pop  | Genres.Alternative },
            new Song()
            {       Title = "Flames(5)",
                    Duration = 3.50,
                    Lyrics = @"So my love, keep on running ...",
                    Album = album,
                    Artist = artist,
                    Genre = Genres.Dance  },

            };
        }
    }
}
