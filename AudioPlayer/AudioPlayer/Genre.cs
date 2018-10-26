using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    
        [Flags]
    public enum Genres
        {
            None = 0,
            Pop = 1,
            Rock = 2,
            Dance = 4,
            Alternative = 8

        
    }
}
