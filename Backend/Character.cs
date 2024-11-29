namespace Backend
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public Classes Classes { get; set; }
        public Race Race { get; set; }
        public List<AbilityScores> AbilityScores { get; set; } = new List<AbilityScores>();
        public List<string> Skills { get; set; } = new List<string>();
        public List<string> Proficiencies { get; set; } = new List<string>();
        public List<string> Equipment { get; set; } = new List<string>();
        public string Background { get; set; }
        public string Alignment { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public int XP { get; set; }
        public int MaxHP { get; set; }
        public int Speed { get; set; }
        public int AC { get; set; }
    }

    public class Classes
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public string HitDie { get; set; }
        public string PrimaryAbility { get; set; }
        public List<string> SavingThrows { get; set; }
        public List<string> SkillChoices { get; set; }
        public List<string> ClassFeatures { get; set; }


    }

    public class Race 
    { 
        public int Id { get; set; }
        public string RaceName { get; set; }
        public string RaceSize { get; set; }
        public string Speed { get; set; }
        public List<string> AbilityScoreBonuses { get; set; }
        public List<string> Languages { get; set; }
        public List<string> RacialFeatures { get; set; }

    }

    public class AbilityScores 
    {

    } 
}
