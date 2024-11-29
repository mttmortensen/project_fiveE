using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Class { get; set; }
        public string Race { get; set; }
        public string Skills { get; set; }
        public string Proficiencies { get; set; }
        public string Equipment { get; set; }
        public string Background { get; set; }
        public string Alignment { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public int XP { get; set; }
        public int MaxHP { get; set; }
        public int Speed { get; set; }
        public int AC { get; set; }
        public string AbilityScores { get; set; }


    }
}
