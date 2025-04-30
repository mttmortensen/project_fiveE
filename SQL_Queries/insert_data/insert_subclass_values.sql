-- 🐉 Subclass: Wyrmcaller (Sorcerer type)
INSERT INTO dbo.Subclasses (
    ClassID,
    SubclassName,
    EntryLevel,
    SubclassFeatures,
    BonusProficiencies,
    BonusSpells
)
VALUES (
    1, -- ClassID for Sorcerer (or whatever ID you gave Sorcerer)
    'Wyrmcaller',
    3,
    'Summon Dragon;Dragon Tongue',
    'Draconic Lore;Draconic Speech',
    'Breath of Flame;Wyrm''s Gaze'
);

-- 🥋 Subclass: Way of the Sky (Monk type)
INSERT INTO dbo.Subclasses (
    ClassID,
    SubclassName,
    EntryLevel,
    SubclassFeatures,
    BonusProficiencies,
    BonusSpells
)
VALUES (
    2, -- ClassID for Monk
    'Way of the Sky',
    3,
    'Wind Step;Thunder Palm',
    'Skyward Focus',
    'Featherfall;Call Lightning'
);

-- 🌙 Subclass: Circle of Stars (Druid type)
INSERT INTO dbo.Subclasses (
    ClassID,
    SubclassName,
    EntryLevel,
    SubclassFeatures,
    BonusProficiencies,
    BonusSpells
)
VALUES (
    3, -- ClassID for Druid
    'Circle of Stars',
    2,
    'Star Map;Cosmic Guidance',
    'Celestial Navigation',
    'Moonbeam;Guiding Bolt'
);
