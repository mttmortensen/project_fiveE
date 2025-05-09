namespace Backend
{
    public class Race 
    {
        public int RaceID { get; set; }
        public string RaceName { get; set; }
        // e.g., Humanoid, Fey, etc.
        public string RaceCreatureType { get; set; }  
        // Small, Medium, etc.
        public string RaceSize { get; set; }          
        // Base walking speed
        public int RaceSpeed { get; set; }            

        public string Description { get; set; }
    }
}
