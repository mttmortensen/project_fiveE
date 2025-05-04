INSERT INTO [DNDCharacterDB].[dbo].[Classes] (
    ClassName, HitDie, PrimaryAbility, SavingThrows, ClassFeatures
)
VALUES
-- 1. Barbarian
('Barbarian', 'd12', 'Strength', '["Strength", "Constitution"]', '["Rage", "Unarmored Defense"]'),

-- 2. Bard
('Bard', 'd8', 'Charisma', '["Dexterity", "Charisma"]', '["Spellcasting", "Bardic Inspiration"]'),

-- 3. Cleric
('Cleric', 'd8', 'Wisdom', '["Wisdom", "Charisma"]', '["Spellcasting", "Divine Domain"]'),

-- 4. Druid
('Druid', 'd8', 'Wisdom', '["Intelligence", "Wisdom"]', '["Spellcasting", "Wild Shape"]'),

-- 5. Fighter
('Fighter', 'd10', 'Strength or Dexterity', '["Strength", "Constitution"]', '["Fighting Style", "Second Wind"]'),

-- 6. Monk
('Monk', 'd8', 'Dexterity and Wisdom', '["Strength", "Dexterity"]', '["Martial Arts", "Unarmored Defense"]'),

-- 7. Paladin
('Paladin', 'd10', 'Strength and Charisma', '["Wisdom", "Charisma"]', '["Divine Sense", "Lay on Hands"]'),

-- 8. Ranger
('Ranger', 'd10', 'Dexterity and Wisdom', '["Strength", "Dexterity"]', '["Favored Enemy", "Natural Explorer"]'),

-- 9. Rogue
('Rogue', 'd8', 'Dexterity', '["Dexterity", "Intelligence"]', '["Expertise", "Sneak Attack", "Thieves'' Cant"]'),

-- 10. Sorcerer
('Sorcerer', 'd6', 'Charisma', '["Constitution", "Charisma"]', '["Spellcasting", "Sorcerous Origin"]'),

-- 11. Warlock
('Warlock', 'd8', 'Charisma', '["Wisdom", "Charisma"]', '["Otherworldly Patron", "Pact Magic"]'),

-- 12. Wizard
('Wizard', 'd6', 'Intelligence', '["Intelligence", "Wisdom"]', '["Spellcasting", "Arcane Recovery"]');
