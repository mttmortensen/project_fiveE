using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class CharacterRaceOptions
    {
        public int CharRaceID { get; set; }
        public int CharacterID { get; set; }
        public int RaceID { get; set; }

        // These are avaiable options for the character to select from during character creation
        public List<string> AvailableTraits { get; set; } = new();  
        public List<string> AvailableLanguages { get; set; } = new();
        public List<string> AvailableProficiencies { get; set; } = new();
        public List<string> AvailableRaceSpells { get; set; } = new();
        public Dictionary<string, int> AbilityScoreBonuses { get; set; } = new();
    }

}
