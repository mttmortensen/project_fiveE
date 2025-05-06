using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class RaceMapper
    {
        public List<Race> MapToRaceList(List<Dictionary<string, object>> rawData) 
        {
            return rawData.Select(row => new Race
            {
                RaceID = Convert.ToInt32(row["RaceID"]),
                RaceName = row["RaceName"].ToString()
            }).ToList();
        }
    }
}
