using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend
{
    public class Step3SubclassModel
    {
        public int SubclassID { get; set; }
        public int ClassID { get; set; }
        public string SubclassName { get; set; }
        public List<string> BonusSpells { get; set; }
        public List<string> BonusProficiencies { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return SubclassName;
        }
    }
}
