using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend
{
    public class Step2RaceModel
    {
        public int RaceID { get; set; }
        public string RaceName { get; set; }
        public string RaceSize { get; set; }
        public int Speed { get; set; }
        public List<string> Languages { get; set; }
        public List<string> RacialFeatures { get; set; }
        public string Description { get; set; }

        // Just for the dropdown, for conenience. 
        public override string ToString()
        {
            return RaceName; 
        }
    }
}
