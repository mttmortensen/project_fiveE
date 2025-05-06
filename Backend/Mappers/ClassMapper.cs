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
        public List<Classes> MapToClassList(List<Dictionary<string, object>> rawData) 
        {
            return rawData.Select(row => new Classes
            {
                ClassID = Convert.ToInt32(row["ClassID"]),
                ClassName = row["ClassName"].ToString(),
                HitDie = row["HitDie"].ToString(),
                PrimaryAbility = row["PrimaryAbility"].ToString(),
                SavingThrows = JsonSerializer.Deserialize<List<string>>(row["SavingThrows"].ToString()),
                ClassFeatures = JsonSerializer.Deserialize<List<string>>(row["ClassFeatures"].ToString()),
            }).ToList();
        }
    }
}
