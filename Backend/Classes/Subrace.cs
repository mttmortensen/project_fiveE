using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Subrace
    {
        // PK
        public int SubraceID { get; set; }
        // FK to Race
        public int RaceID { get; set; }

        // e.g., "Wood Elf"
        public string SubraceName { get; set; }
        // Lore & flavor text
        public string Description { get; set; }

        // Racial traits (e.g., "Fey Ancestry")
        public List<string> Traits { get; set; } = new();
        // e.g., ["Dexterity: 2", "Wisdom: 1"]
        public List<string> AbilityScoreIncreases { get; set; } = new(); 
    }
}
