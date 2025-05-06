using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend
{
    public class Step3ClassModel
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public string HitDie { get; set; }
        public string PrimaryAbility { get; set; }
        public List<string> SavingThrows { get; set; }
        public List<string> ClassFeatures { get; set; }

        public override string ToString()
        {
            return ClassName;
        }
    }
}
