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
                SavingThrows = SafeList(row["Saves"]),
                ClassTraits = SafeList(row["ClassTraits"]),
                SpellsAvailable = row.ContainsKey("SpellsAvailable") && row["SpellsAvailable"] != DBNull.Value
                    ? Convert.ToBoolean(row["SpellsAvailable"])
                    : false,
                Description = row.ContainsKey("Description") ? row["Description"].ToString() : null
            }).ToList();
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
