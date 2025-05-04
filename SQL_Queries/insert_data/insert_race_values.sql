INSERT INTO [DNDCharacterDB].[dbo].[Races] (
    RaceName, RaceSize, Speed, Languages, RacialFeatures
)
VALUES
-- 1. Human
('Human', 'Medium', 30, '["Common"]', '["Versatility"]'),

-- 2. Elf
('Elf', 'Medium', 30, '["Common", "Elvish"]', '["Darkvision", "Fey Ancestry", "Keen Senses", "Trance"]'),

-- 3. Dwarf
('Dwarf', 'Medium', 25, '["Common", "Dwarvish"]', '["Darkvision", "Dwarven Resilience", "Stonecunning"]'),

-- 4. Halfling
('Halfling', 'Small', 25, '["Common", "Halfling"]', '["Lucky", "Brave", "Halfling Nimbleness"]'),

-- 5. Dragonborn
('Dragonborn', 'Medium', 30, '["Common", "Draconic"]', '["Draconic Ancestry", "Breath Weapon", "Damage Resistance"]'),

-- 6. Gnome
('Gnome', 'Small', 25, '["Common", "Gnomish"]', '["Darkvision", "Gnome Cunning"]'),

-- 7. Half-Elf
('Half-Elf', 'Medium', 30, '["Common", "Elvish"]', '["Darkvision", "Fey Ancestry", "Skill Versatility"]'),

-- 8. Half-Orc
('Half-Orc', 'Medium', 30, '["Common", "Orc"]', '["Darkvision", "Relentless Endurance", "Savage Attacks"]'),

-- 9. Tiefling
('Tiefling', 'Medium', 30, '["Common", "Infernal"]', '["Darkvision", "Hellish Resistance", "Infernal Legacy"]');
