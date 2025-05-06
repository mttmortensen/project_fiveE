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
                RaceSize = row["RaceSize"].ToString(),
                Speed = Convert.ToInt32(row["Speed"]),
                Languages = JsonSerializer.Deserialize<List<string>>(row["Languages"].ToString()),
                RacialFeatures = JsonSerializer.Deserialize<List<string>>(row["RacialFeatures"].ToString()),
                Description = row.ContainsKey("Description") ? row["Description"].ToString() : null,
            }).ToList();
        }
    }
}
