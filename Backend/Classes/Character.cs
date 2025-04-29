namespace Backend
{
    public class Character
    {
        // Identity
        public int CharacterID { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int RaceID { get; set; }
        public int ClassID { get; set; }
        public int SubclassID { get; set; }
        public int AbilityID { get; set; }
        public string Background { get; set; }
        public string Alignment { get; set; }
        public int Level { get; set; }
        public int ExperiencePoints { get; set; } = 0;

        // Linked Objects
        public Race Race { get; set; }
        public Classes Classes { get; set; }
        public AbilityScores AbilityScores { get; set; }

        // Combat Stats
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int TempHP { get; set; } = 0;
        public int AC { get; set; }
        public int InitiativeBonus { get; set; }
        public int Speed { get; set; }
        public int HitDice { get; set; } = 0;
        public int DeathSavesSuccess { get; set; } = 0;
        public int DeathSavesFailure { get; set; } = 0;

        // Skills, Proficiencies, Languages
        public List<string> SavingThrows { get; set; } = new List<string>();
        public List<string> Skills { get; set; } = new List<string>();
        public List<string> ArmorProficiencies { get; set; } = new List<string>();
        public List<string> WeaponProficiencies { get; set; } = new List<string>();
        public List<string> ToolProficiencies { get; set; } = new List<string>();
        public List<string> Languages { get; set; } = new List<string>();

        // Features and Spells
        public List<string> FeaturesAndTraits { get; set; } = new List<string>();
        public List<string> Equipment { get; set; } = new List<string>();
        public List<string> SpellsKnown { get; set; } = new List<string>();

        // Passive Senses
        public int PassivePerception { get; set; } = 10;
        public int PassiveInsight { get; set; } = 10;
        public int PassiveInvestigation { get; set; } = 10;

        // Roleplay / Personality
        public string PersonalityTraits { get; set; }
        public string Ideals { get; set; }
        public string Bonds { get; set; }
        public string Flaws { get; set; }
        public string CharacterAppearance { get; set; }
        public string AlliesAndOrganizations { get; set; }
        public string CharacterBackstory { get; set; }
        public string AdditionalNotes { get; set; }
    }
}
