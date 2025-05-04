CREATE TABLE [DNDCharacterDB].[dbo].[CharacterRace] (
    CharacterID INT NOT NULL,
    RaceID INT NOT NULL,
    RacialProficiencies NVARCHAR(MAX) NULL,
    Darkvision BIT NULL,

    CONSTRAINT PK_CharacterRace PRIMARY KEY (CharacterID),
    CONSTRAINT FK_CharacterRace_Character FOREIGN KEY (CharacterID) REFERENCES Characters(CharacterID),
    CONSTRAINT FK_CharacterRace_Race FOREIGN KEY (RaceID) REFERENCES Races(RaceID)
);
