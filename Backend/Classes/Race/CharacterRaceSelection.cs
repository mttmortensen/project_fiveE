using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class CharacterRaceSelection
    {
        public int CharRaceSelectID { get; set; }
        public int CharacterID { get; set; }
        public int RaceID { get; set; }
        public int? SubRaceID { get; set; }

        public List<string> SelectedLanguages { get; set; } = new();
        public List<string> SelectedTraits { get; set; } = new();
        public List<string> SelectedProficiencies { get; set; } = new();
        public List<string> SelectedSpells { get; set; } = new();
        public Dictionary<string, int> SelectedAbilityScoreBonuses { get; set; } = new();
    }

}
