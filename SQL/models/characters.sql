CREATE TABLE Characters (
	CharacterID INT IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(100) NOT NULL,
	Sex VARCHAR(10),
	Race VARCHAR(50),
	Class VARCHAR(50),
	Level INT DEFAULT 1,
	AbilityScores TEXT,
	Skills TEXT,
	Proficiencies TEXT,
	Equipment TEXT,
	Background VARCHAR(100),
	Alignment VARCHAR(20),
	XP INT DEFAULT 0,
	HP INT,
	MaxHP INT,
	AC INT,
	Speed INT
);