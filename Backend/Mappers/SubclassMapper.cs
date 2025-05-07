using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Backend
{
    public class SubclassMapper
    {
        public List<Subclass> MapToSubclassList(List<Dictionary<string, object>> rawData) 
        {
            return rawData.Select(row => new Subclass
            {
                SubclassID = Convert.ToInt32(row["SubclassID"]),
                ClassID = Convert.ToInt32(row["ClassID"]),
                SubclassName = row["SubclassName"].ToString(),
                EntryLevel = Convert.ToInt32(row["EntryLevel"]),
                SubclassFeatures = JsonSerializer.Deserialize<List<string>>(row["SubclassFeatures"].ToString()) ?? null
            }).ToList();
        }
    }
}
