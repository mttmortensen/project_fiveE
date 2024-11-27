CREATE TABLE Classes (
	ClassID INT IDENTITY(1,1) PRIMARY KEY,
	ClassName VARCHAR(50),
	HitDie VARCHAR(10),
	PrimaryAbility VARCHAR(50),
	SavingThrows TEXT,
	SKillChoices TEXT,
	ClassFeatures TEXT
);