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
                SpellsKnown,
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
                @SpellsKnown,
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
        // Returns the ID of the new row

        public string AddingNewAbilityScoresForCharacter => @"
            INSERT INTO Abilities (CharacterID, Strength, Dexterity, Constitution, Intelligence, Wisdom, Charisma)
            VALUES (@CharacterID, @Strength, @Dexterity, @Constitution, @Intelligence, @Wisdom, @Charisma);
            SELECT SCOPE_IDENTITY();
        "; // Returns the ID of the new AbilityScores row

        // Now that the AbilityID has been created, update it back to the Character table
        public string UpdateCharacterWithAbilityId => @"
            UPDATE Characters
            SET AbilityID = @AbilityID
            WHERE CharacterID = @CharacterID;
        ";
    }
}
