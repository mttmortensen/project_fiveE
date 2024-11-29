INSERT INTO Characters (Name, Sex, RaceID, ClassID, Level, XP, Background, Alignment, HP, MaxHP, AC, Speed)
VALUES
('Arthas', 'Male', 1, 1, 1, 0, 'Soldier', 'Lawful Good', 12, 12, 18, 30),
('Jaina', 'Female', 2, 2, 3, 500, 'Sage', 'Neutral Good', 8, 8, 12, 30);

INSERT INTO Abilities (CharacterID, Strength, Dexterity, Constitution, Intelligence, Wisdom, Charisma)
VALUES
(1, 15, 12, 14, 10, 13, 8),  -- Arthas
(2, 8, 14, 12, 18, 10, 15);  -- Jaina
