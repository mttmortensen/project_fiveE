-- Add missing new fields
ALTER TABLE Classes
ADD 
    ArmorProficiencies TEXT NULL,
    WeaponProficiencies TEXT NULL,
    ToolProficiencies TEXT NULL,
    SpellcastingAbilityModifier INT DEFAULT 0;