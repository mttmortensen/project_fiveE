-- Add missing new fields
ALTER TABLE Races
ADD 
    RacialProficiencies TEXT NULL,
    Darkvision INT DEFAULT 0;
