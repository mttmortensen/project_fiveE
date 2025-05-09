CREATE TABLE Subraces (
    SubraceID INT IDENTITY(1,1) PRIMARY KEY,
    RaceID INT NOT NULL,
    SubraceName VARCHAR(100) NOT NULL,
    Description TEXT,
    AbilityScoreIncreases NVARCHAR(MAX), -- JSON like: {"Dexterity": 2, "Charisma": 1}
    Traits NVARCHAR(MAX),                -- JSON list like: ["Fey Ancestry", "Trance", "Keen Senses"],

    CONSTRAINT FK_Subraces_Race FOREIGN KEY (RaceID) REFERENCES Races(RaceID)
);
