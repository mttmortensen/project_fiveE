CREATE TABLE Races (
	RaceID INT IDENTITY(1,1) PRIMARY KEY,
	RaceName VARCHAR(50),
	RaceSize VARCHAR(10),
	Speed INT,
	AbilityScoreBonuses TEXT,
	Languages TEXT,
	RacialFeatures TEXT
);