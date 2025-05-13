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

        // The ID's are used to get the actual subrace object from the database to send over to AvailableSubraces
        public List<int> AvailableSubRaceIDs { get; set; } = new();
        // This prop is needed to actually display back the subraces to the user over the FE
        public List<Subrace> AvaiableSubraces { get; set; } = new();
        public List<string> AvailableTraits { get; set; } = new();  
        public List<string> AvailableLanguages { get; set; } = new();
        public List<string> AvailableProficiencies { get; set; } = new();
        public List<string> AvailableRaceSpells { get; set; } = new();
        public Dictionary<string, int> AbilityScoreBonuses { get; set; } = new();
    }

}
