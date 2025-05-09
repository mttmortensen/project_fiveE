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
        // Used for GET /races
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
                RaceID = row.ContainsKey("RaceID") ? Convert.ToInt32(row["RaceID"]) : 0,
                RaceName = SafeString(row["RaceName"]),
                RaceCreatureType = SafeString(row["RaceCreatureType"]),
                RaceSize = SafeString(row["RaceSize"]),
                RaceSpeed = row.ContainsKey("RaceSpeed") ? SafeInt(row["RaceSpeed"]) : 0,
                Description = SafeString(row["Description"]),
            };
        }

        // For POST /characters -> insert into CharacterRace
        public Dictionary<string, object> MapCharacterRaceToDictionary(Character character)
        {
            return new Dictionary<string, object>
            {
                { "@CharacterID", character.CharacterID },
                { "@RaceID", character.RaceID },
                { "@Traits",
                    character.CharacterRace?.Traits != null
                        ? string.Join(",", character.CharacterRace.Traits)
                        : (object)DBNull.Value
                }
            };
        }

        // Helpers
        private int SafeInt(object value) => value == DBNull.Value ? 0 : Convert.ToInt32(value);
        private string SafeString(object value) => value == DBNull.Value ? null : value.ToString();
    }
}
