using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium_2.Models
{
    public class Artist
    {
        public int IdArtist { get; set; }
        public String Nickname { get; set; }

        public ICollection<Artist_Event> Artist_Events { get; set; }
    }
}
