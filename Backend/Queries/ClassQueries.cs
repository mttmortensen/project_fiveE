using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Queries
{
    public class ClassQueries
    {
        public string GetAllClasses => @"
            SELECT ClassID, ClassName, HitDie, PrimaryAbility, SavingThrows, ClassFeatures
            FROM Classes
            ORDER BY ClassName;
        ";
    }
}
