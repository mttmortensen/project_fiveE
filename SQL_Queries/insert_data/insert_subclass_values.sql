INSERT INTO [DNDCharacterDB].[dbo].[Subclasses] (
    ClassID, SubclassName, EntryLevel, SubclassFeatures
)
VALUES
-- Barbarian: Path of the Berserker
((SELECT ClassID FROM Classes WHERE ClassName = 'Barbarian'), 'Path of the Berserker', 3, '["Frenzy"]'),

-- Bard: College of Lore
((SELECT ClassID FROM Classes WHERE ClassName = 'Bard'), 'College of Lore', 3, '["Bonus Proficiencies", "Cutting Words"]'),

-- Cleric: Life Domain
((SELECT ClassID FROM Classes WHERE ClassName = 'Cleric'), 'Life Domain', 1, '["Disciple of Life"]'),

-- Druid: Circle of the Land
((SELECT ClassID FROM Classes WHERE ClassName = 'Druid'), 'Circle of the Land', 2, '["Bonus Cantrip", "Natural Recovery"]'),

-- Fighter: Champion
((SELECT ClassID FROM Classes WHERE ClassName = 'Fighter'), 'Champion', 3, '["Improved Critical"]'),

-- Monk: Way of the Open Hand
((SELECT ClassID FROM Classes WHERE ClassName = 'Monk'), 'Way of the Open Hand', 3, '["Open Hand Technique"]'),

-- Paladin: Oath of Devotion
((SELECT ClassID FROM Classes WHERE ClassName = 'Paladin'), 'Oath of Devotion', 3, '["Channel Divinity", "Sacred Weapon"]'),

-- Ranger: Hunter
((SELECT ClassID FROM Classes WHERE ClassName = 'Ranger'), 'Hunter', 3, '["Hunter''s Prey"]'),

-- Rogue: Thief
((SELECT ClassID FROM Classes WHERE ClassName = 'Rogue'), 'Thief', 3, '["Fast Hands", "Second-Story Work"]'),

-- Sorcerer: Draconic Bloodline
((SELECT ClassID FROM Classes WHERE ClassName = 'Sorcerer'), 'Draconic Bloodline', 1, '["Draconic Resilience", "Elemental Affinity"]'),

-- Warlock: The Fiend
((SELECT ClassID FROM Classes WHERE ClassName = 'Warlock'), 'The Fiend', 1, '["Dark One''s Blessing"]'),

-- Wizard: School of Evocation
((SELECT ClassID FROM Classes WHERE ClassName = 'Wizard'), 'School of Evocation', 2, '["Evocation Savant", "Sculpt Spells"]');
