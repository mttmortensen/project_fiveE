USE DNDCharacterDB;
GO

CREATE TABLE CharacterSpells (
    CharacterID INT NOT NULL,
    SpellID INT NOT NULL,
    PRIMARY KEY (CharacterID, SpellID),

    FOREIGN KEY (CharacterID) REFERENCES Characters(CharacterID) ON DELETE CASCADE,
    FOREIGN KEY (SpellID) REFERENCES Spells(SpellID) ON DELETE CASCADE
);
