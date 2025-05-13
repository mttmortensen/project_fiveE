INSERT INTO Classes (ClassName, HitDie, PrimaryAbility, SavingThrows, ClassTraits, Description, MaxHitPoints, Level, SpellsAvailable)
VALUES 
-- Barbarian
('Barbarian', 'd12', 'Strength', 'Strength, Constitution', 'Rage; Unarmored Defense', 'A fierce warrior of primitive background who can enter a battle rage', 12, 1, 0),

-- Bard
('Bard', 'd8', 'Charisma', 'Dexterity, Charisma', 'Bardic Inspiration; Spellcasting', 'An inspiring magician whose power echoes the music of creation', 8, 1, 1),

-- Cleric
('Cleric', 'd8', 'Wisdom', 'Wisdom, Charisma', 'Spellcasting; Channel Divinity', 'A priestly champion who wields divine magic in service of a higher power', 8, 1, 1),

-- Druid
('Druid', 'd8', 'Wisdom', 'Intelligence, Wisdom', 'Druidic; Wild Shape', 'A priest of the Old Faith, wielding the powers of nature', 8, 1, 1),

-- Fighter
('Fighter', 'd10', 'Strength or Dexterity', 'Strength, Constitution', 'Second Wind; Fighting Style', 'A master of martial combat, skilled with a variety of weapons and armor', 10, 1, 0),

-- Monk
('Monk', 'd8', 'Dexterity & Wisdom', 'Strength, Dexterity', 'Martial Arts; Ki', 'A master of martial arts, harnessing the power of the body in pursuit of physical and spiritual perfection', 8, 1, 0),

-- Paladin
('Paladin', 'd10', 'Strength & Charisma', 'Wisdom, Charisma', 'Divine Sense; Lay on Hands', 'A holy warrior bound to a sacred oath', 10, 1, 1),

-- Ranger
('Ranger', 'd10', 'Dexterity & Wisdom', 'Strength, Dexterity', 'Favored Enemy; Natural Explorer', 'A warrior who uses martial prowess and nature magic to combat threats on the edges of civilization', 10, 1, 1),

-- Rogue
('Rogue', 'd8', 'Dexterity', 'Dexterity, Intelligence', 'Sneak Attack; Thieves Cant', 'A scoundrel who uses stealth and trickery to overcome obstacles and enemies', 8, 1, 0),

-- Sorcerer
('Sorcerer', 'd6', 'Charisma', 'Constitution, Charisma', 'Sorcery Points; Spellcasting', 'A spellcaster who draws on inherent magic from a gift or bloodline', 6, 1, 1),

-- Warlock
('Warlock', 'd8', 'Charisma', 'Wisdom, Charisma', 'Eldritch Invocations; Pact Magic', 'A wielder of magic that is derived from a bargain with an extraplanar entity', 8, 1, 1),

-- Wizard
('Wizard', 'd6', 'Intelligence', 'Intelligence, Wisdom', 'Spellbook; Arcane Recovery', 'A scholarly magic-user capable of manipulating the structures of reality', 6, 1, 1);
