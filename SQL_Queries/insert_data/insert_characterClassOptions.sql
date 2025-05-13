INSERT INTO CharacterClassOptions (ClassID, AvailableArmorProficiencies, AvailableWeaponProficiencies, AvailableClassPath)
VALUES
-- Barbarian (ClassID = 1)
(1, 'Light Armor, Medium Armor, Shields', 'Simple Weapons, Martial Weapons', 'Berserker, Totem Warrior'),

-- Bard (ClassID = 2)
(2, 'Light Armor', 'Simple Weapons, Hand Crossbows, Longswords, Rapiers, Shortswords', 'College of Lore, College of Valor'),

-- Cleric (ClassID = 3)
(3, 'Light Armor, Medium Armor, Shields', 'Simple Weapons', 'Life Domain, Light Domain'),

-- Druid (ClassID = 4)
(4, 'Light Armor, Medium Armor, Shields (non-metal)', 'Clubs, Daggers, Darts, Javelins, Maces, Quarterstaffs, Scimitars, Sickles, Slings, Spears', 'Circle of the Land, Circle of the Moon'),

-- Fighter (ClassID = 5)
(5, 'All Armor, Shields', 'Simple Weapons, Martial Weapons', 'Champion, Battle Master'),

-- Monk (ClassID = 6)
(6, 'None', 'Simple Weapons, Shortswords', 'Way of the Open Hand, Way of Shadow'),

-- Paladin (ClassID = 7)
(7, 'All Armor, Shields', 'Simple Weapons, Martial Weapons', 'Oath of Devotion, Oath of the Ancients'),

-- Ranger (ClassID = 8)
(8, 'Light Armor, Medium Armor, Shields', 'Simple Weapons, Martial Weapons', 'Hunter, Beast Master'),

-- Rogue (ClassID = 9)
(9, 'Light Armor', 'Simple Weapons, Hand Crossbows, Longswords, Rapiers, Shortswords', 'Thief, Assassin'),

-- Sorcerer (ClassID = 10)
(10, 'None', 'Daggers, Darts, Slings, Quarterstaffs, Light Crossbows', 'Draconic Bloodline, Wild Magic'),

-- Warlock (ClassID = 11)
(11, 'Light Armor', 'Simple Weapons', 'The Fiend, The Archfey'),

-- Wizard (ClassID = 12)
(12, 'None', 'Daggers, Darts, Slings, Quarterstaffs, Light Crossbows', 'School of Evocation, School of Illusion');
