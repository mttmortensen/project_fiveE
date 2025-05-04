namespace Backend
{
    // This class is write out the complex queries when dealing with the Character tables
    // AND any other related table data associated with it.
    public class CharacterQueries
    {
        // Using a lambda getter expersion here
        public string GetAllCharacterAndItsRelatedData => @"
            SELECT 
                c.*, 
                r.RaceName, 
                r.RaceSize, 
                r.Speed AS RaceSpeed, 
                r.AbilityScoreBonuses, 
                r.Languages, 
                r.RacialFeatures,
                r.RacialProficiencies,
                r.Darkvision,
                cl.ClassName, 
                cl.HitDie, 
                cl.PrimaryAbility, 
                cl.SavingThrows, 
                cl.SkillChoices, 
                cl.ClassFeatures,
                cl.ArmorProficiencies,
                cl.WeaponProficiencies,
                cl.ToolProficiencies,
                cl.SpellcastingAbilityModifier,
                sc.SubclassName,
                sc.EntryLevel,
                sc.SubclassFeatures,
                sc.BonusProficiencies,
                sc.BonusSpells,
                a.Strength, 
                a.Dexterity, 
                a.Constitution, 
                a.Intelligence, 
                a.Wisdom, 
                a.Charisma
            FROM Characters c
            LEFT JOIN Races r ON c.RaceID = r.RaceID
            LEFT JOIN Classes cl ON c.ClassID = cl.ClassID
            LEFT JOIN Subclasses sc ON c.SubclassID = sc.SubclassID
            LEFT JOIN Abilities a ON c.AbilityID = a.AbilityID;
        ";

        public string GetSingleCharacterAndRelatedData => @"
            SELECT 
                c.*, 
                r.RaceName, r.RaceSize, r.Speed AS RaceSpeed, 
                r.AbilityScoreBonuses, r.Languages, r.RacialFeatures, r.RacialProficiencies, r.Darkvision,
                cl.ClassName, cl.HitDie, cl.PrimaryAbility, cl.SavingThrows, cl.SkillChoices, cl.ClassFeatures, 
                cl.ArmorProficiencies, cl.WeaponProficiencies, cl.ToolProficiencies, cl.SpellcastingAbilityModifier,
                sc.SubclassName, sc.EntryLevel, sc.SubclassFeatures, sc.BonusProficiencies, sc.BonusSpells,
                a.Strength, a.Dexterity, a.Constitution, a.Intelligence, a.Wisdom, a.Charisma
            FROM Characters c
            LEFT JOIN Races r ON c.RaceID = r.RaceID
            LEFT JOIN Classes cl ON c.ClassID = cl.ClassID
            LEFT JOIN Subclasses sc ON c.SubclassID = sc.SubclassID
            LEFT JOIN Abilities a ON c.AbilityID = a.AbilityID
            WHERE c.CharacterID = @CharacterID;
        ";

        // Needing to get the CharacterID first before creating the Ability query 
        public string AddingNewCharacterWithoutAbilityId => @"
            INSERT INTO Characters 
            (
                Name,
                Sex,
                Level,
                RaceID,
                ClassID,
                SubclassID,
                Background,
                Alignment,
                ExperiencePoints,
                HP,
                MaxHP,
                TempHP,
                AC,
                Speed,
                InitiativeBonus,
                PassivePerception,
                PassiveInsight,
                PassiveInvestigation,
                HitDice,
                DeathSavesSuccess,
                DeathSavesFailure,
                FeaturesAndTraits,
                Equipment,
                PersonalityTraits,
                Ideals,
                Bonds,
                Flaws,
                CharacterAppearance,
                AlliesAndOrganizations,
                CharacterBackstory,
                AdditionalNotes
            )
            VALUES 
            (
                @Name,
                @Sex,
                @Level,
                @RaceID,
                @ClassID,
                @SubclassID,
                @Background,
                @Alignment,
                @ExperiencePoints,
                @HP,
                @MaxHP,
                @TempHP,
                @AC,
                @Speed,
                @InitiativeBonus,
                @PassivePerception,
                @PassiveInsight,
                @PassiveInvestigation,
                @HitDice,
                @DeathSavesSuccess,
                @DeathSavesFailure,
                @FeaturesAndTraits,
                @Equipment,
                @PersonalityTraits,
                @Ideals,
                @Bonds,
                @Flaws,
                @CharacterAppearance,
                @AlliesAndOrganizations,
                @CharacterBackstory,
                @AdditionalNotes
            );
            SELECT SCOPE_IDENTITY();
        ";

        // Returns the ID of the new AbilityScores row
        public string AddingNewAbilityScoresForCharacter => @"
            INSERT INTO Abilities (CharacterID, Strength, Dexterity, Constitution, Intelligence, Wisdom, Charisma)
            VALUES (@CharacterID, @Strength, @Dexterity, @Constitution, @Intelligence, @Wisdom, @Charisma);
            SELECT SCOPE_IDENTITY();
        "; 

        // Now that the AbilityID has been created, update it back to the Character table
        public string UpdateCharacterWithAbilityId => @"
            UPDATE Characters
            SET AbilityID = @AbilityID
            WHERE CharacterID = @CharacterID;
        ";

        // This is the query to update a character's data
        public string GeneratePartialUpdateQuery(IEnumerable<string> fields)
        {
            var setClauses = fields.Select(f => $"{f} = @{f}");
            string setStatement = string.Join(", ", setClauses);
            return $"UPDATE Characters SET {setStatement} WHERE CharacterID = @CharacterID;";
        }

        // This is the query to delete a character from the Character table and any linked data
        public string DeleteCharacterAndLinkedData => @"
            DELETE FROM Characters WHERE CharacterID = @CharacterID;
            DELETE FROM Abilities WHERE CharacterID = @CharacterID;
        ";

        // Getting spells from a Character ID
        public string GetSpellsByCharacterId => @"
            SELECT s.*
            FROM CharacterSpells cs
            INNER JOIN Spells s ON cs.SpellID = s.SpellID
            WHERE cs.CharacterID = @CharacterID;
        ";

        // Linking Spells to a Character
        public string LinkSpellToCharacter => @"
            INSERT INTO CharacterSpells (CharacterID, SpellID)
            VALUES (@CharacterID, @SpellID);
        ";

        // Getting CharacterRace info from a Character ID
        // This includes also the columns from Race table (helpful for GET)
        public string GetCharacterRaceById => @"
            SELECT 
                cr.*, 
                r.RaceName, 
                r.RaceSize, 
                r.Speed, 
                r.Languages, 
                r.RacialFeatures
            FROM CharacterRace cr
            INNER JOIN Races r ON cr.RaceID = r.RaceID
            WHERE cr.CharacterID = @CharacterID;
        ";

        // Link race-specific data to a specific character via the CharacterRace relation table
        public string LinkCharacterRace => @"
            INSERT INTO CharacterRace (
                CharacterID, RaceID, RacialProficiencies, Darkvision, AbilityScoreBonuses
            ) VALUES (
                @CharacterID, @RaceID, @RacialProficiencies, @Darkvision, @AbilityScoreBonuses
            );
        ";

        // Getting CharacterClass info from a Character ID
        // Includes static data from Classes table
        public string GetCharacterClassById => @"
            SELECT 
                cc.*, 
                cl.ClassName, 
                cl.HitDie, 
                cl.PrimaryAbility, 
                cl.SavingThrows, 
                cl.ClassFeatures
            FROM CharacterClass cc
            INNER JOIN Classes cl ON cc.ClassID = cl.ClassID
            WHERE cc.CharacterID = @CharacterID;
        ";

        // Linking class-specific data to a character
        public string LinkCharacterClass => @"
            INSERT INTO CharacterClass (
                CharacterID,
                ClassID,
                ArmorProficiencies,
                WeaponProficiencies,
                ToolProficiencies,
                SpellcastingAbilityModifier,
                SkillChoices
            ) VALUES (
                @CharacterID,
                @ClassID,
                @ArmorProficiencies,
                @WeaponProficiencies,
                @ToolProficiencies,
                @SpellcastingAbilityModifier,
                @SkillChoices
            );
        ";

        // Getting CharacterSubclass info from a Character ID
        // Includes static data from Subclasses table
        public string GetCharacterSubclassById => @"
            SELECT 
                csc.*, 
                sc.SubclassName, 
                sc.EntryLevel, 
                sc.SubclassFeatures
            FROM CharacterSubclass csc
            INNER JOIN Subclasses sc ON csc.SubclassID = sc.SubclassID
            WHERE csc.CharacterID = @CharacterID;
        ";

        // Linking subclass-specific data to a character
        public string LinkCharacterSubclass => @"
            INSERT INTO CharacterSubclass (
                CharacterID,
                SubclassID,
                BonusProficiencies,
                BonusSpells
            ) VALUES (
                @CharacterID,
                @SubclassID,
                @BonusProficiencies,
                @BonusSpells
            );
        ";
    }
}
