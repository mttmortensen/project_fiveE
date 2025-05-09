using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class CharacterRace
    {
        public int CharRaceID { get; set; }
        public int CharacterID { get; set; }
        public int RaceID { get; set; }

        // Passive racial features (Trance, Lucky, etc.)
        public List<string> Traits { get; set; } = new();  
    }

}
