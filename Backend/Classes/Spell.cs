using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Spell
    {
        public int SpellID { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public string School { get; set; }
        public string CastingTime { get; set; }
        public string Range { get; set; }
        public List<string> Components { get; set; } = new();
        public string Duration { get; set; }
        public string Description { get; set; }

        public bool IsRitual { get; set; }
        public bool RequiresConcentration { get; set; }

        public List<string> Classes { get; set; } = new();
    }
}
