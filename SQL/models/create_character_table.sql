CREATE TABLE Characters (
	CharacterID INT IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(100) NOT NULL,
	Sex VARCHAR(10),
    RaceID INT NOT NULL, -- Foreign Key to Race Table
    ClassID INT NOT NULL, -- Foreign Key to Class Table
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
	Speed INT,
    CONSTRAINT FK_Race FOREIGN KEY (RaceID) REFERENCES Races(RaceID),
    CONSTRAINT FK_Class FOREIGN KEY (ClassID) REFERENCES Classes(ClassID)
);