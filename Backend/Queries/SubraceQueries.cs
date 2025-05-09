using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class SubraceQueries
    {
        public string GetSubracesByRaceId => @"
            SELECT SubraceID, RaceID, SubraceName, Description, AbilityScoreIncreases, Traits
            FROM Subraces
            WHERE RaceID = @RaceID
            ORDER BY SubraceName;
        ";
    }
}
