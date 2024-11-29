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
}
