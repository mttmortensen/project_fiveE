CREATE TABLE Spells (
    SpellID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Level INT NOT NULL,
    School NVARCHAR(50),
    CastingTime NVARCHAR(50),
    Range NVARCHAR(50),
    Components NVARCHAR(100), -- semicolon-separated e.g. "V;S;M"
    Duration NVARCHAR(100),
    Description NVARCHAR(MAX),
    IsRitual BIT DEFAULT 0,
    RequiresConcentration BIT DEFAULT 0,
    Classes NVARCHAR(200) -- semicolon-separated e.g. "Wizard;Sorcerer"
);
