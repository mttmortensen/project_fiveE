SET IDENTITY_INSERT Races ON;

INSERT INTO Races (RaceID, RaceName, RaceCreatureType, RaceSize, RaceSpeed, Description, Darkvision) VALUES
(1, 'Dwarf', 'Humanoid', 'Medium', 25, 'Bold and hardy, dwarves are known for their resilience and craftsmanship.', 60),
(2, 'Elf', 'Humanoid', 'Medium', 30, 'Elves are known for their grace, longevity, and connection to nature and magic.', 60),
(3, 'Halfling', 'Humanoid', 'Small', 25, 'Halflings are cheerful, nimble, and brave, often underestimated by larger folk.', 0),
(4, 'Human', 'Humanoid', 'Medium', 30, 'Humans are the most adaptable and ambitious people among the common races.', 0),
(5, 'Dragonborn', 'Humanoid', 'Medium', 30, 'Dragonborn are proud, honorable warriors with draconic ancestry.', 0),
(6, 'Gnome', 'Humanoid', 'Small', 25, 'Gnomes are inventive and energetic, drawn to knowledge and technology.', 60),
(7, 'Half-Elf', 'Humanoid', 'Medium', 30, 'Half-elves combine human versatility with elven grace and charm.', 60),
(8, 'Half-Orc', 'Humanoid', 'Medium', 30, 'Half-orcs are fierce and powerful, often facing prejudice for their orcish heritage.', 60),
(9, 'Tiefling', 'Humanoid', 'Medium', 30, 'Tieflings are touched by infernal heritage, marked by their appearance and inner strength.', 60);

SET IDENTITY_INSERT Races OFF;
