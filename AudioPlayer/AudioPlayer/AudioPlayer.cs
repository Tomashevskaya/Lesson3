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

        public Song[] AllSongs;

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
        public void Add(string Artist, string Song)
        {

        }
        public void Add(string Album, string PlayList)
        {

        }
        public bool Play()
        {
            return true;
        }
        public bool Stop()
        {
            return true;
        }

        Console.WriteLine(AudioPlayer.Play);     

        }
    }
}
