using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Backend
{
    public class RaceMapper
    {
        /************************************************************************/
        /*                          GET METHODS                                 */
        /************************************************************************/

        // GET /races → Maps raw data from Races table into Race objects (no spells shown)
        public List<Race> MapToRaceList(List<Dictionary<string, object>> rawData)
        {
            return rawData.Select(row => new Race
            {
                RaceID = Convert.ToInt32(row["RaceID"]),
                RaceName = row["RaceName"].ToString(),
                RaceCreatureType = row["RaceCreatureType"].ToString(),
                RaceSize = row["RaceSize"].ToString(),
                RaceSpeed = Convert.ToInt32(row["RaceSpeed"]),
                Description = row.ContainsKey("Description") ? row["Description"].ToString() : null
                // Intentionally excluding SpellsAvailable here (used only in internal flow)
            }).ToList();
        }

        // GET (internal use in GET /characters/:id) → Maps a single joined row from Character to a Race object
        // To be used later when viewing all of the character data on the frontend
        public Race MapRaceData(Dictionary<string, object> row)
        {
            return new Race
            {
                RaceID = row.ContainsKey("RaceID") ? SafeInt(row["RaceID"]) : 0,
                RaceName = SafeString(row["RaceName"]),
                RaceCreatureType = SafeString(row["RaceCreatureType"]),
                RaceSize = SafeString(row["RaceSize"]),
                RaceSpeed = row.ContainsKey("RaceSpeed") ? SafeInt(row["RaceSpeed"]) : 0,
                Description = SafeString(row["Description"])
            };
        }

        // GET /character-race-options/:characterId → Maps CharacterRaceOptions from DB rows into objects for the Frontend to use
        public List<CharacterRaceOptions> MapToCharacterRaceOptionsList(List<Dictionary<string, object>> rawData)
        {
            return rawData.Select(row => new CharacterRaceOptions
            {
                CharRaceID = SafeInt(row["CharRaceID"]),
                CharacterID = SafeInt(row["CharacterID"]),
                RaceID = SafeInt(row["RaceID"]),
                AvailableTraits = row.ContainsKey("AvailableTraits") ? SafeList(row["AvailableTraits"]) : new List<string>(),
                AvailableLanguages = row.ContainsKey("AvailableLanguages") ? SafeList(row["AvailableLanguages"]) : new List<string>(),
                AvailableProficiencies = row.ContainsKey("AvailableProficiencies") ? SafeList(row["AvailableProficiencies"]) : new List<string>(),
                AvailableRaceSpells = row.ContainsKey("AvailableRaceSpells") ? SafeList(row["AvailableRaceSpells"]) : new List<string>(),
                AbilityScoreBonuses = row.ContainsKey("AvailableAbilityScoreBonuses") && row["AvailableAbilityScoreBonuses"] != DBNull.Value
                    ? JsonConvert.DeserializeObject<Dictionary<string, int>>(row["AvailableAbilityScoreBonuses"].ToString())
                    : new Dictionary<string, int>()
            }).ToList();
        }

        // GET /character-race-selection/:characterId → Maps selected Race data for this character
        // To be used later when viewing all of the character data on the frontend
        public CharacterRaceSelection MapCharacterRaceSelection(Dictionary<string, object> row)
        {
            return new CharacterRaceSelection
            {
                CharRaceSelectID = row.ContainsKey("CharRaceSelectID") ? SafeInt(row["CharRaceSelectID"]) : 0,
                CharacterID = SafeInt(row["CharacterID"]),
                RaceID = SafeInt(row["RaceID"]),
                SubRaceID = row.ContainsKey("SubRaceID") ? SafeInt(row["SubRaceID"]) : null,
                SelectedLanguages = row.ContainsKey("SelectedLanguages") ? SafeList(row["SelectedLanguages"]) : new List<string>(),
                SelectedTraits = row.ContainsKey("SelectedTraits") ? SafeList(row["SelectedTraits"]) : new List<string>(),
                SelectedProficiencies = row.ContainsKey("SelectedProficiencies") ? SafeList(row["SelectedProficiencies"]) : new List<string>(),
                SelectedSpells = row.ContainsKey("SelectedRaceSpells") ? SafeList(row["SelectedRaceSpells"]) : new List<string>(),
                SelectedAbilityScoreBonuses = row.ContainsKey("SelectedAbilityScoreBonuses") && row["SelectedAbilityScoreBonuses"] != DBNull.Value
                    ? JsonConvert.DeserializeObject<Dictionary<string, int>>(row["SelectedAbilityScoreBonuses"].ToString())
                    : new Dictionary<string, int>()
            };
        }

        /************************************************************************/
        /*                          HELPERS                                     */
        /************************************************************************/

        private int SafeInt(object value) => value == DBNull.Value ? 0 : Convert.ToInt32(value);
        private string SafeString(object value) => value == DBNull.Value ? null : value.ToString();
        private List<string> SafeList(object value) =>
            value != DBNull.Value ? value.ToString().Split(',').Select(s => s.Trim()).ToList() : new List<string>();
    }
}
