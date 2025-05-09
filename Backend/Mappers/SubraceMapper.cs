using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Backend
{
    public class SubraceMapper
    {
        public List<Subrace> MapToSubraceList(List<Dictionary<string, object>> rawData)
        {
            return rawData.Select(row => new Subrace
            {
                SubraceID = Convert.ToInt32(row["SubraceID"]),
                RaceID = Convert.ToInt32(row["RaceID"]),
                SubraceName = row["SubraceName"].ToString(),
                Description = row["Description"].ToString(),
                Traits = JsonSerializer.Deserialize<List<string>>(row["Traits"].ToString()) ?? new List<string>(),
                AbilityScoreIncreases = JsonSerializer.Deserialize<List<string>>(row["AbilityScoreIncreases"].ToString()) ?? new List<string>(),
            }).ToList();
        }
    }
}