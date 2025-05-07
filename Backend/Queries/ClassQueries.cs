using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class ClassQueries
    {
        public string GetAllClasses => @"
            SELECT ClassID, ClassName, HitDie, PrimaryAbility, SavingThrows, ClassFeatures, Description
            FROM Classes
            ORDER BY ClassName;
        ";
    }
}
