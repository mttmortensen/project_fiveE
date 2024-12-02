INSERT INTO dbo.Races (RaceName, RaceSize, Speed, AbilityScoreBonuses, Languages, RacialFeatures)
VALUES 
    ('Dwarf', 'Medium', 25, '{"Strength": 2, "Constitution": 2}', '["Common", "Dwarvish"]', '["Darkvision", "Dwarven Resilience"]'),
    ('Halfling', 'Small', 25, '{"Dexterity": 2}', '["Common", "Halfling"]', '["Lucky", "Brave", "Halfling Nimbleness"]'),
    ('Dragonborn', 'Medium', 30, '{"Strength": 2, "Charisma": 1}', '["Common", "Draconic"]', '["Draconic Ancestry", "Breath Weapon", "Damage Resistance"]'),
    ('Gnome', 'Small', 25, '{"Intelligence": 2}', '["Common", "Gnomish"]', '["Darkvision", "Gnome Cunning"]'),
    ('Half-Orc', 'Medium', 30, '{"Strength": 2, "Constitution": 1}', '["Common", "Orc"]', '["Darkvision", "Relentless Endurance", "Savage Attacks"]'),
    ('Tiefling', 'Medium', 30, '{"Charisma": 2, "Intelligence": 1}', '["Common", "Infernal"]', '["Darkvision", "Hellish Resistance", "Infernal Legacy"]'),
    ('Half-Elf', 'Medium', 30, '{"Charisma": 2, "AnyTwo": 1}', '["Common", "Elvish"]', '["Darkvision", "Fey Ancestry", "Skill Versatility"]');
