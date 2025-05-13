INSERT INTO CharacterRaceOptions (RaceID, AvailableTraits, AvailableLanguages, AvailableProficiencies, AvailableAbilityScoreBonuses, AvailableRaceSpells) VALUES
-- Dwarf
(1, 
 'Dwarven Resilience,Stonecunning', 
 'Common,Dwarvish', 
 'Battleaxe,Handaxe,Light Hammer,Warhammer',
 '{"Constitution": 2}', 
 NULL),

-- Elf
(2, 
 'Fey Ancestry,Trance', 
 'Common,Elvish', 
 'Longsword,Shortsword,Shortbow,Longbow',
 '{"Dexterity": 2}', 
 NULL),

-- Halfling
(3, 
 'Brave,Halfling Nimbleness', 
 'Common,Halfling', 
 '', 
 '{"Dexterity": 2}', 
 NULL),

-- Human
(4, 
 'Versatile', 
 'Common', 
 '', 
 '{"Strength": 1, "Dexterity": 1, "Constitution": 1, "Intelligence": 1, "Wisdom": 1, "Charisma": 1}', 
 NULL),

-- Dragonborn
(5, 
 'Draconic Ancestry,Breath Weapon,Damage Resistance', 
 'Common,Draconic', 
 '', 
 '{"Strength": 2, "Charisma": 1}', 
 NULL),

-- Gnome
(6, 
 'Gnome Cunning', 
 'Common,Gnomish', 
 '', 
 '{"Intelligence": 2}', 
 NULL),

-- Half-Elf
(7, 
 'Fey Ancestry,Versatile', 
 'Common,Elvish', 
 '', 
 '{"Charisma": 2, "ChooseAnyTwo": 1}', 
 NULL),

-- Half-Orc
(8, 
 'Relentless Endurance,Savage Attacks', 
 'Common,Orc', 
 '', 
 '{"Strength": 2, "Constitution": 1}', 
 NULL),

-- Tiefling
(9, 
 'Hellish Resistance,Infernal Legacy', 
 'Common,Infernal', 
 '', 
 '{"Charisma": 2, "Intelligence": 1}', 
 'Thaumaturgy,Hellish Rebuke,Darkness');
