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

        // GET: Class + CharacterClassSelection data for a single character
        public string GetCharacterClassByCharacterId => @"
            SELECT 
                ccs.CharClassSelectID,
                ccs.CharacterID,
                ccs.ClassID,
                ccs.SelectedWeaponProficiencies,
                ccs.SelectedClassPaths,
                ccs.SelectedArmorProficiencies,
                c.ClassName,
                c.RaceCreatureType,
                c.RaceSize,
                c.RaceSpeed,
                c.Description
            FROM CharacterClassSelection ccs
            INNER JOIN Classes c ON ccs.ClassID = c.ClassID
            WHERE ccs.CharacterID = @CharacterID;
        ";
    }
}
