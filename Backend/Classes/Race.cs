﻿namespace Backend
{
    public class Race 
    { 
        public int RaceID { get; set; }
        public string RaceName { get; set; }
        public string RaceSize { get; set; }
        public int Speed { get; set; }
        public List<string> AbilityScoreBonuses { get; set; }
        public List<string> Languages { get; set; }
        public List<string> RacialFeatures { get; set; }

    }
}
