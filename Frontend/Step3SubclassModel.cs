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
        public int EntryLevel { get; set; }
        public List<string> SubclassFeatures { get; set; }
        public string Descriptions { get; set; }

        public override string ToString()
        {
            return SubclassName;
        }
    }
}
