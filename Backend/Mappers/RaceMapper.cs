using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
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
                RaceName = row["RaceName"].ToString(),
                RaceCreatureType = row["RaceCreatureType"].ToString(),
                RaceSize = row["RaceSize"].ToString(),
                RaceSpeed = Convert.ToInt32(row["RaceSpeed"]),
                Description = row.ContainsKey("Description") ? row["Description"].ToString() : null,
            }).ToList();
        }

        // For GET /characters/:id - builds full Race object from JOIN
        public Race MapRaceData(Dictionary<string, object> row) 
        {
            return new Race
            {

            }
        }
    }
}
