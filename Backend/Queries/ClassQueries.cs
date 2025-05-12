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

        // GET: ChacterClassOptions data for a single character during creation
        public string GetCharacterClassOptionsById => @"
            SELECT 
                CharClassOpID,
                CharacterID,
                ClassID,
                AvailableWeaponProficiencies,
                AvailableClassPaths
            FROM CharacterClassOptions
            WHERE CharacterID = @CharacterID;
        ";

        // GET: CharacterClassSelection data for a single character
        public string GetCharacterClassSelectionById => @"
            SELECT 
                CharClassSelectID,
                CharacterID,
                ClassID,
                SelectedWeaponProficiencies,
                SelectedClassPaths
            FROM CharacterClassSelection
            WHERE CharacterID = @CharacterID;
        ";

        // POST: Inserts a new row into CharacterClassSelection with user's picks
        public string LinkCharacterClassSelection => @"
            INSERT INTO CharacterClassSelection (
                CharacterID,
                ClassID,
                SelectedWeaponProficiencies,
                SelectedClassPaths
            ) VALUES (
                @CharacterID,
                @ClassID,
                @SelectedWeaponProficiencies,
                @SelectedClassPaths
            );
        ";

    }
}
