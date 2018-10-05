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
           Console.WriteLine(player.Volume);
            player.Volume = 300;
            Console.WriteLine(player.Volume);

            player.VolumePlus();
            player.VolumePlus();
            player.VolumePlus();
            Console.WriteLine(player.Volume);
            Console.ReadLine();
        }
    }
}
