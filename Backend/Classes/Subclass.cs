using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Classes
{
    internal class Subclass
    {
        public int SubclassID { get; set; }
        public int ClassID { get; set; } // FK to Classes
        public string SubclassName { get; set; }
        public int EntryLevel { get; set; } = 3; // Most subclasses kick in at level 3

    }
}
