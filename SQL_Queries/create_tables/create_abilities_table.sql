CREATE TABLE Abilities (
	AbilityID INT IDENTITY(1,1) PRIMARY KEY,
	CharacterID INT NOT NULL,
	Strength INT NOT NULL,
    Dexterity INT NOT NULL,
    Constitution INT NOT NULL,
    Intelligence INT NOT NULL,
    Wisdom INT NOT NULL,
    Charisma INT NOT NULL,
	CONSTRAINT FK_Character_Abilities FOREIGN KEY (CharacterID) REFERENCES Characters(CharacterID)
);