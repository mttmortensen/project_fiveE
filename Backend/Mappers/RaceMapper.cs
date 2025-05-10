using Newtonsoft.Json;
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

        // Maps static, always-granted racial traits assigned to the character
        public CharacterRace MapCharacterRace(Dictionary<string, object> row)
        {
            return new CharacterRace
            {
                CharRaceID = row.ContainsKey("CharRaceID") ? SafeInt(row["CharRaceID"]) : 0,
                CharacterID = SafeInt(row["CharacterID"]),
                RaceID = SafeInt(row["RaceID"]),
                Traits = row.ContainsKey("Traits") ? SafeList(row["Traits"]) : new List<string>()
            };
        }

        // Maps player-selected racial options (languages, ASIs, proficiencies, etc.)
        public CharacterRaceSelection MapCharacterRaceSelection(Dictionary<string, object> row)
        {
            return new CharacterRaceSelection
            {
                CharRaceSelectID = row.ContainsKey("CharRaceSelectID") ? SafeInt(row["CharRaceSelectID"]) : 0,
                CharacterID = SafeInt(row["CharacterID"]),
                RaceID = SafeInt(row["RaceID"]),
                SubRaceID = row.ContainsKey("SubRaceID") ? SafeInt(row["SubRaceID"]) : null,
                SelectedLanguages = row.ContainsKey("Languages") ? SafeList(row["Languages"]) : new List<string>(),
                SelectedTraits = row.ContainsKey("SelectedTraits") ? SafeList(row["SelectedTraits"]) : new List<string>(),
                SelectedProficiencies = row.ContainsKey("SelectedProficiencies") ? SafeList(row["SelectedProficiencies"]) : new List<string>(),
                SelectedSpells = row.ContainsKey("SelectedSpells") ? SafeList(row["SelectedSpells"]) : new List<string>(),
                SelectedAbilityScoreBonuses = row.ContainsKey("SelectedAbilityScoreBonuses") && row["SelectedAbilityScoreBonuses"] != DBNull.Value
                    ? JsonConvert.DeserializeObject<Dictionary<string, int>>(row["SelectedAbilityScoreBonuses"].ToString())
                    : new Dictionary<string, int>()
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

        // For POST /characters → insert into CharacterRaceSelection
        public Dictionary<string, object> MapCharacterRaceSelectionToDictionary(Character character)
        {
            return new Dictionary<string, object>
            {
                { "@CharacterID", character.CharacterID },
                { "@RaceID", character.RaceID },
                { "@SubraceID", character.Race?.SubraceID ?? (object)DBNull.Value },
                { "@Languages", character.CharacterRaceSelection?.SelectedLanguages != null ? string.Join(",", character.CharacterRaceSelection.SelectedLanguages) : (object)DBNull.Value },
                { "@SelectedTraits", character.CharacterRaceSelection?.SelectedTraits != null ? string.Join(",", character.CharacterRaceSelection.SelectedTraits) : (object)DBNull.Value },
                { "@SelectedProficiencies", character.CharacterRaceSelection?.SelectedProficiencies != null ? string.Join(",", character.CharacterRaceSelection.SelectedProficiencies) : (object)DBNull.Value },
                { "@SelectedSpells", character.CharacterRaceSelection?.SelectedSpells != null ? string.Join(",", character.CharacterRaceSelection.SelectedSpells) : (object)DBNull.Value },
                { "@SelectedAbilityScoreBonuses", character.CharacterRaceSelection?.SelectedAbilityScoreBonuses != null
                    ? JsonConvert.SerializeObject(character.CharacterRaceSelection.SelectedAbilityScoreBonuses)
                    : (object)DBNull.Value }
            };
        }

        // Helpers
        private int SafeInt(object value) => value == DBNull.Value ? 0 : Convert.ToInt32(value);
        private string SafeString(object value) => value == DBNull.Value ? null : value.ToString();
        private List<string> SafeList(object value) =>
            value != DBNull.Value ? value.ToString().Split(',').Select(s => s.Trim()).ToList() : new List<string>();
        }
}
