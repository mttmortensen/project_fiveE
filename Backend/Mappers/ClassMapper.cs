using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Backend
{
    public class ClassMapper
    {
        /************************************************************************/
        /*                          GET METHODS                                 */
        /************************************************************************/

        // GET /classes → Returns all base class data
        public List<Classes> MapToClassList(List<Dictionary<string, object>> rawData)
        {
            return rawData.Select(row => new Classes
            {
                ClassID = Convert.ToInt32(row["ClassID"]),
                ClassName = row["ClassName"].ToString(),
                HitDie = row["HitDie"].ToString(),
                MaxHitPoints = row.ContainsKey("MaxHitPoints") ? SafeInt(row["MaxHitPoints"]) : 0,
                Level = row.ContainsKey("Level") ? SafeInt(row["Level"]) : 0,
                PrimaryAbility = row["PrimaryAbility"].ToString(),
                SavingThrows = SafeList(row["SavingThrows"]),
                ClassTraits = SafeList(row["ClassTraits"]),
                SpellsAvailable = row.ContainsKey("SpellsAvailable") && row["SpellsAvailable"] != DBNull.Value
                    ? Convert.ToBoolean(row["SpellsAvailable"])
                    : false,
                Description = row.ContainsKey("Description") ? row["Description"].ToString() : null
            }).ToList();
        }

        // Internal use for CharacterMapper → Maps row from joined character/class data to full class object
        public Classes MapClassData(Dictionary<string, object> row)
        {
            return new Classes
            {
                ClassID = row.ContainsKey("ClassID") ? SafeInt(row["ClassID"]) : 0,
                ClassName = SafeString(row["ClassName"]),
                HitDie = SafeString(row["HitDie"]),
                MaxHitPoints = row.ContainsKey("MaxHitPoints") ? SafeInt(row["MaxHitPoints"]) : 0,
                Level = row.ContainsKey("Level") ? SafeInt(row["Level"]) : 0,
                PrimaryAbility = SafeString(row["PrimaryAbility"]),
                SavingThrows = row.ContainsKey("SavingThrows") ? SafeList(row["SavingThrows"]) : new List<string>(),
                ClassTraits = row.ContainsKey("ClassTraits") ? SafeList(row["ClassTraits"]) : new List<string>(),
                SpellsAvailable = row.ContainsKey("SpellsAvailable") && row["SpellsAvailable"] != DBNull.Value
                    ? Convert.ToBoolean(row["SpellsAvailable"])
                    : false,
                Description = SafeString(row["Description"])
            };
        }

        // GET /character-class-options/:characterId
        public List<CharacterClassOptions> MapToCharacterClassOptionsList(List<Dictionary<string, object>> rawData)
        {
            return rawData.Select(row => new CharacterClassOptions
            {
                CharClassOpID = SafeInt(row["CharClassOpID"]),
                CharacterID = SafeInt(row["CharacterID"]),
                ClassID = SafeInt(row["ClassID"]),
                AvailableWeaponProficiencies = row.ContainsKey("AvailableWeaponProficiencies") ? SafeList(row["AvailableWeaponProficiencies"]) : new List<string>(),
                AvailableClassPaths = row.ContainsKey("AvailableClassPaths") ? SafeList(row["AvailableClassPaths"]) : new List<string>()
            }).ToList();
        }

        // GET /character-class-selection/:characterId
        public CharacterClassSelection MapCharacterClassSelection(Dictionary<string, object> row)
        {
            return new CharacterClassSelection
            {
                CharClassSelectID = row.ContainsKey("CharClassSelectID") ? SafeInt(row["CharClassSelectID"]) : 0,
                CharacterID = SafeInt(row["CharacterID"]),
                ClassID = SafeInt(row["ClassID"]),
                SelectedWeaponProficiencies = row.ContainsKey("SelectedWeaponProficiencies") ? SafeList(row["SelectedWeaponProficiencies"]) : new List<string>(),
                SelectedClassPaths = row.ContainsKey("SelectedClassPaths") ? SafeList(row["SelectedClassPaths"]) : new List<string>()
            };
        }

        /************************************************************************/
        /*                          POST METHODS                                */
        /************************************************************************/

        // POST: Insert selected class data for a character
        public Dictionary<string, object> MapCharacterClassSelectionToDictionary(Character character)
        {
            return new Dictionary<string, object>
            {
                { "@CharacterID", character.CharacterID },
                { "@ClassID", character.ClassID },

                { "@SelectedWeaponProficiencies", character.CharacterClassSelection?.SelectedWeaponProficiencies != null
                    ? string.Join(",", character.CharacterClassSelection.SelectedWeaponProficiencies)
                    : (object)DBNull.Value },

                { "@SelectedClassPaths", character.CharacterClassSelection?.SelectedClassPaths != null
                    ? string.Join(",", character.CharacterClassSelection.SelectedClassPaths)
                    : (object)DBNull.Value }
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
