-- Rename XP to ExperiencePoints
EXEC sp_rename 'Characters.XP', 'ExperiencePoints', 'COLUMN';

-- Drop old Proficiencies column (we split it into Armor/Weapon/Tool)
ALTER TABLE Characters
DROP COLUMN Proficiencies;

-- Add missing new fields
ALTER TABLE Characters
ADD 
    SubclassID INT NULL,
    TempHP INT DEFAULT 0,
    InitiativeBonus INT DEFAULT 0,
    PassivePerception INT DEFAULT 10,
    PassiveInsight INT DEFAULT 10,
    PassiveInvestigation INT DEFAULT 10,
    HitDice INT DEFAULT 0,
    DeathSavesSuccess INT DEFAULT 0,
    DeathSavesFailure INT DEFAULT 0,
    ArmorProficiencies TEXT NULL,
    WeaponProficiencies TEXT NULL,
    ToolProficiencies TEXT NULL,
    SpellsKnown TEXT NULL,
    FeaturesAndTraits TEXT NULL,
    PersonalityTraits TEXT NULL,
    Ideals TEXT NULL,
    Bonds TEXT NULL,
    Flaws TEXT NULL,
    CharacterAppearance TEXT NULL,
    AlliesAndOrganizations TEXT NULL,
    CharacterBackstory TEXT NULL,
    AdditionalNotes TEXT NULL;
