INSERT INTO Spells (Name, Level, School, CastingTime, Range, Components, Duration, Description, IsRitual, RequiresConcentration, Classes)
VALUES
-- SpellID 1
('Mage Armor', 1, 'Abjuration', '1 action', 'Touch', 'V,S,M', '8 hours', 'You touch a willing creature... AC becomes 13 + Dex mod.', 0, 0, 'Sorcerer;Wizard'),

-- SpellID 2
('Shield', 1, 'Abjuration', '1 reaction', 'Self', 'V,S', '1 round', 'An invisible barrier of magical force appears... +5 AC until start of your next turn.', 0, 0, 'Sorcerer;Wizard'),

-- SpellID 3
('Magic Missile', 1, 'Evocation', '1 action', '120 feet', 'V,S', 'Instantaneous', 'Three glowing darts of magical force automatically hit.', 0, 0, 'Sorcerer;Wizard'),

-- SpellID 4
('Misty Step', 2, 'Conjuration', '1 bonus action', 'Self', 'V', 'Instantaneous', 'Teleport up to 30 feet to an unoccupied space.', 0, 0, 'Sorcerer;Wizard;Warlock'),

-- SpellID 5
('Fireball', 3, 'Evocation', '1 action', '150 feet', 'V,S,M', 'Instantaneous', 'Deals 8d6 fire damage in a 20-foot radius.', 0, 0, 'Sorcerer;Wizard'),

-- SpellID 6
('Detect Magic', 1, 'Divination', '1 action', 'Self', 'V,S', 'Concentration, up to 10 minutes', 'Sense the presence of magic within 30 feet.', 1, 1, 'Cleric;Druid;Wizard;Sorcerer'),

-- SpellID 7
('Invisibility', 2, 'Illusion', '1 action', 'Touch', 'V,S,M', 'Concentration, up to 1 hour', 'Turns a creature invisible until spell ends.', 0, 1, 'Sorcerer;Wizard;Bard'),

-- SpellID 8
('Counterspell', 3, 'Abjuration', '1 reaction', '60 feet', 'S', 'Instantaneous', 'Interrupt the casting of a spell.', 0, 0, 'Sorcerer;Wizard;Warlock'),

-- SpellID 9
('Mirror Image', 2, 'Illusion', '1 action', 'Self', 'V,S', '1 minute', 'Creates illusory duplicates to confuse attackers.', 0, 0, 'Sorcerer;Wizard'),

-- SpellID 10
('Fly', 3, 'Transmutation', '1 action', 'Touch', 'V,S,M', 'Concentration, up to 10 minutes', 'Target gains flying speed of 60 feet.', 0, 1, 'Sorcerer;Wizard')
;
