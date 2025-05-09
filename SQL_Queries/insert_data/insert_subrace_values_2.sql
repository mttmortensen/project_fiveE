-- Forest Gnome
INSERT INTO Subraces (RaceID, SubraceName, Description, AbilityScoreIncreases, Traits)
VALUES (
    15,
    'Forest Gnome',
    'Forest gnomes are shy and elusive, with a natural knack for illusion magic.',
    '["Dexterity: 1"]',
    '["Natural Illusionist", "Speak with Small Beasts"]'
);

-- Rock Gnome
INSERT INTO Subraces (RaceID, SubraceName, Description, AbilityScoreIncreases, Traits)
VALUES (
    15,
    'Rock Gnome',
    'Rock gnomes are known for their curiosity and inventiveness.',
    '["Constitution: 1"]',
    '["Artificers Lore", "Tinker"]'
);

-- Red Dragonborn
INSERT INTO Subraces (RaceID, SubraceName, Description, AbilityScoreIncreases, Traits)
VALUES (
    14,
    'Red Dragonborn',
    'Descended from red dragons, known for fire breath and fierce pride.',
    '[]',
    '["Fire Breath", "Damage Resistance: Fire"]'
);

-- Blue Dragonborn
INSERT INTO Subraces (RaceID, SubraceName, Description, AbilityScoreIncreases, Traits)
VALUES (
    14,
    'Blue Dragonborn',
    'Descended from blue dragons, wielding lightning breath and command.',
    '[]',
    '["Lightning Breath", "Damage Resistance: Lightning"]'
);

-- Asmodeus Tiefling (PHB default)
INSERT INTO Subraces (RaceID, SubraceName, Description, AbilityScoreIncreases, Traits)
VALUES (
    18,
    'Asmodeus Tiefling',
    'These tieflings gain infernal legacy magic and dark resilience.',
    '["Intelligence: 1"]',
    '["Hellish Resistance", "Infernal Legacy"]'
);

-- Variant Tiefling (Homebrew option)
INSERT INTO Subraces (RaceID, SubraceName, Description, AbilityScoreIncreases, Traits)
VALUES (
    18,
    'Variant Tiefling',
    'Some tieflings vary slightly based on their infernal ancestry.',
    '["Dexterity: 1"]',
    '["Winged", "Legacy of Maladomini"]'
);
