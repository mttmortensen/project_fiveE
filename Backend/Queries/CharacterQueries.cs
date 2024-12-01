using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    // This class is write out the complex queries when dealing with the Character tables
    // AND any other related table data associated with it.
    public class CharacterQueries
    {
        // Using a lambda getter expersion here
        public static string GetAllCharacterAndItsRelatedData => @"
            SELECT c.*, 
                   r.RaceName, r.RaceSize, r.Speed AS RaceSpeed, r.AbilityScoreBonuses, r.Languages, r.RacialFeatures,
                   cl.ClassName, cl.HitDie, cl.PrimaryAbility, cl.SavingThrows, cl.SkillChoices, cl.ClassFeatures,
                   a.Strength, a.Dexterity, a.Constitution, a.Intelligence, a.Wisdom, a.Charisma
            FROM Characters c
            LEFT JOIN Races r ON c.RaceID = r.RaceID
            LEFT JOIN Classes cl ON c.ClassID = cl.ClassID
            LEFT JOIN AbilityScores a ON c.AbilityID = a.AbilityID;
        "; 
    }
}
