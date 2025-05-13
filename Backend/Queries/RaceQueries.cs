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
            SELECT RaceID, RaceName, RaceCreatureType, RaceSize, RaceSpeed, Description, Darkvision
            FROM Races
            ORDER BY RaceName;
        ";

        // GET: Race + CharacterRaceSelection data for a single character
        public string GetCharacterRaceById => @"
            SELECT 
                crs.CharRaceID,
                crs.CharacterID,
                crs.RaceID,
                crs.SelectedTraits,
                crs.SelectedLanguages,
                crs.SelectedProficiencies,
                crs.SelectedRaceSpells,
                crs.SelectedAbilityScoreBonuses,
                r.RaceName,
                r.RaceCreatureType,
                r.RaceSize,
                r.RaceSpeed,
                r.Description,
                r.Darkvision
            FROM CharacterRaceSelection crs
            INNER JOIN Races r ON crs.RaceID = r.RaceID
            WHERE crs.CharacterID = @CharacterID;
        ";

        public string GetRaceByCharacterId => @"
            SELECT r.RaceID, r.RaceName, r.RaceCreatureType, r.RaceSize, r.RaceSpeed, r.Description, r.Darkvision
            FROM Races r
            INNER JOIN CharacterRaceSelection crs ON r.RaceID = crs.RaceID
            WHERE crs.CharacterID = @CharacterID;
        ";

        // GET: ChacterRaceOptions data for a single character during creation
        public string GetCharacterRaceOptionsByRaceId => @"
            SELECT 
                CharRaceID,
                RaceID,
                AvailableTraits,
                AvailableLanguages,
                AvailableProficiencies,
                AvailableRaceSpells,
                AvailableAbilityScoreBonuses
            FROM CharacterRaceOptions
            WHERE RaceID = @RaceID;
        ";

        // GET: CharacterRaceSelection for a character
        public string GetCharacterRaceSelectionById => @"
            SELECT 
                CharRaceSelectID,
                CharacterID,
                RaceID,
                SubraceID,
                SelectedLanguages,
                SelectedTraits,
                SelectedProficiencies,
                SelectedSpells,
                SelectedAbilityScoreBonuses
            FROM CharacterRaceSelection
            WHERE CharacterID = @CharacterID;
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

