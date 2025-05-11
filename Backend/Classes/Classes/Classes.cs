namespace Backend
{
    public class Classes
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public string HitDie { get; set; }
        public int MaxHitPoints { get; set; }
        public int Level { get; set; }

        public string PrimaryAbility { get; set; }
        public List<string> Saves { get; set; } = new();

        // Will evolve into ClassTrait object
        public List<string> ClassTraits { get; set; } = new(); 
        public bool SpellsAvailable { get; set; } = false;
    }

}
