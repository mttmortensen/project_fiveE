CREATE TABLE [DNDCharacterDB].[dbo].[CharacterSubclass] (
    CharacterID INT NOT NULL,
    SubclassID INT NOT NULL,
    BonusProficiencies NVARCHAR(MAX) NULL,
    BonusSpells NVARCHAR(MAX) NULL,

    CONSTRAINT PK_CharacterSubclass PRIMARY KEY (CharacterID),
    CONSTRAINT FK_CharacterSubclass_Character FOREIGN KEY (CharacterID) REFERENCES Characters(CharacterID),
    CONSTRAINT FK_CharacterSubclass_Subclass FOREIGN KEY (SubclassID) REFERENCES Subclasses(SubclassID)
);
