CREATE TABLE CharacterRace (
    CharRaceID INT IDENTITY(1,1) PRIMARY KEY,
    CharacterID INT NOT NULL,
    RaceID INT NOT NULL,
    Traits NVARCHAR(MAX) NULL,

    -- Optional but recommended if you want DB-level referential integrity
    CONSTRAINT FK_CharacterRace_Characters FOREIGN KEY (CharacterID) REFERENCES Characters(CharacterID),
    CONSTRAINT FK_CharacterRace_Races FOREIGN KEY (RaceID) REFERENCES Races(RaceID)
);
