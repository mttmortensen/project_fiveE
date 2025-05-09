CREATE TABLE CharacterRaceSelection (
    CharRaceSelectID INT IDENTITY(1,1) PRIMARY KEY,
    CharacterID INT NOT NULL,
    RaceID INT NOT NULL,
    SubraceID INT NULL,

    Languages NVARCHAR(MAX) NULL,
    SelectedTraits NVARCHAR(MAX) NULL,
    SelectedProficiencies NVARCHAR(MAX) NULL,
    SelectedSpells NVARCHAR(MAX) NULL,
    SelectedAbilityScoreBonuses NVARCHAR(MAX) NULL,

    -- Foreign key references
    CONSTRAINT FK_CharacterRaceSelection_Characters FOREIGN KEY (CharacterID) REFERENCES Characters(CharacterID),
    CONSTRAINT FK_CharacterRaceSelection_Races FOREIGN KEY (RaceID) REFERENCES Races(RaceID),
    CONSTRAINT FK_CharacterRaceSelection_Subraces FOREIGN KEY (SubraceID) REFERENCES Subraces(SubraceID)
);
