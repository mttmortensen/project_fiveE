using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class RaceQueries
    {
        // GET: All static race data
        public string GetAllRaces => @"
            SELECT RaceID, RaceName, RaceCreatureType, RaceSize, RaceSpeed, Description
            FROM Races
            ORDER BY RaceName;
        ";

        // GET: Race + CharacterRace data for a single character
        public string GetCharacterRaceById => @"
            SELECT 
                cr.CharRaceID,
                cr.CharacterID,
                cr.RaceID,
                cr.Traits,
                r.RaceName,
                r.RaceCreatureType,
                r.RaceSize,
                r.RaceSpeed,
                r.Description
            FROM CharacterRace cr
            INNER JOIN Races r ON cr.RaceID = r.RaceID
            WHERE cr.CharacterID = @CharacterID;
        ";

        // GET: CharacterRaceSelection for a character
        public string GetCharacterRaceSelectionById => @"
            SELECT 
                CharRaceSelectID,
                CharacterID,
                RaceID,
                SubraceID,
                Languages,
                SelectedTraits,
                SelectedProficiencies,
                SelectedSpells,
                SelectedAbilityScoreBonuses
            FROM CharacterRaceSelection
            WHERE CharacterID = @CharacterID;
        ";

        // POST: Insert CharacterRace
        public string LinkCharacterRace => @"
            INSERT INTO CharacterRace (CharacterID, RaceID, Traits)
            VALUES (@CharacterID, @RaceID, @Traits);
        ";

        // POST: Insert CharacterRaceSelection
        public string LinkCharacterRaceSelection => @"
            INSERT INTO CharacterRaceSelection (
                CharacterID,
                RaceID,
                SubraceID,
                Languages,
                SelectedTraits,
                SelectedProficiencies,
                SelectedSpells,
                SelectedAbilityScoreBonuses
            ) VALUES (
                @CharacterID,
                @RaceID,
                @SubraceID,
                @Languages,
                @SelectedTraits,
                @SelectedProficiencies,
                @SelectedSpells,
                @SelectedAbilityScoreBonuses
            );
        ";
    }
}

