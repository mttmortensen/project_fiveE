using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class SubclassQueries
    {
        public string GetSubclassesByClassId => @"
            SELECT SubclassID, ClassID, SubclassName, EntryLevel, SubclassFeatures
            FROM Subclasses
            WHERE ClassID = @ClassID
            ORDER BY SubclassName;
        ";
    }
}
