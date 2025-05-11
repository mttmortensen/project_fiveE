CREATE TABLE CharacterClassSelection (
    CharClassSelectID INT IDENTITY(1,1) PRIMARY KEY,
    CharacterID INT NOT NULL,
    ClassID INT NOT NULL,
    SelectedWeaponProficiencies NVARCHAR(MAX) NULL,
    SelectedClassPaths NVARCHAR(MAX) NULL,

    FOREIGN KEY (CharacterID) REFERENCES Characters(CharacterID),
    FOREIGN KEY (ClassID) REFERENCES Classes(ClassID)
);