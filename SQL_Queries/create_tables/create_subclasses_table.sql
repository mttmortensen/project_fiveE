CREATE TABLE Subclasses (
    SubclassID INT IDENTITY(1,1) PRIMARY KEY,
    ClassID INT NOT NULL,  -- FK to Classes
    SubclassName NVARCHAR(100) NOT NULL,
    EntryLevel INT DEFAULT 3,  -- Usually level 3 unless specified

    SubclassFeatures TEXT NULL,         -- Semicolon-delimited or JSON
    BonusProficiencies TEXT NULL,       -- List of any extras (e.g., heavy armor)
    BonusSpells TEXT NULL,              -- Only applies if caster (optional)

    CONSTRAINT FK_Subclass_Class FOREIGN KEY (ClassID) REFERENCES Classes(ClassID)
);
