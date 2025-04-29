namespace Backend
{
    public class Classes
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public string HitDie { get; set; }
        public string PrimaryAbility { get; set; }
        public List<string> SavingThrows { get; set; }
        public List<string> SkillChoices { get; set; }
        public List<string> ClassFeatures { get; set; }
        public List<string> ArmorProficiencies { get; set; } = new List<string>();
        public List<string> WeaponProficiencies { get; set; } = new List<string>();
        public List<string> ToolProficiencies { get; set; } = new List<string>();
        public int SpellcastingAbilityModifier { get; set; } = 0;

    }
}
