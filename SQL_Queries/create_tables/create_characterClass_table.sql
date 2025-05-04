CREATE TABLE [DNDCharacterDB].[dbo].[CharacterClass] (
    CharacterID INT NOT NULL,
    ClassID INT NOT NULL,
    ArmorProficiencies NVARCHAR(MAX) NULL,
    WeaponProficiencies NVARCHAR(MAX) NULL,
    ToolProficiencies NVARCHAR(MAX) NULL,
    SpellcastingAbilityModifier NVARCHAR(20) NULL,

    CONSTRAINT PK_CharacterClass PRIMARY KEY (CharacterID),
    CONSTRAINT FK_CharacterClass_Character FOREIGN KEY (CharacterID) REFERENCES Characters(CharacterID),
    CONSTRAINT FK_CharacterClass_Class FOREIGN KEY (ClassID) REFERENCES Classes(ClassID)
);
