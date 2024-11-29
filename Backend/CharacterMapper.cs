namespace Backend
{
    public class CharacterMapper
    {
        /************************************************************************/
                                    /*MAIN METHODS*/
        /************************************************************************/

        // Getting RAW DB Data and "mapping" it to the Character class as a new Character Object
        public List<Character> MapToCharacterClass(List<Dictionary<string, object>> dataDictionaryRows)
        {
            var characters = new List<Character>();

            foreach (var row in dataDictionaryRows)
            {
                characters.Add(new Character
                {
                    Id = Convert.ToInt32(row["id"]),
                    Name = row["Name"].ToString(),
                    Level = Convert.ToInt32(row["Level"]),
                    Classes = MapClassData(row),
                    HP = Convert.ToInt32(row["HP"]),
                    AbilityScores = MapAbilityScores(row)
                });
            }
            return characters;
        }

        // Taking a Character object and prepping it to be RAW DB data
        public List<Character> MapFromCharacterClass(List<Dictionary<string, object>> dataDictionaryRows)
        {
            var characters = new List<Character>();

            foreach (var row in dataDictionaryRows)
            {
                var character = new Character
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString(),
                    Sex = row["Sex"].ToString(),
                    Level = Convert.ToInt32(row["Level"]),
                    HP = Convert.ToInt32(row["HP"]),
                    XP = Convert.ToInt32(row["XP"]),
                    MaxHP = Convert.ToInt32(row["MaxHP"]),
                    Speed = Convert.ToInt32(row["Speed"]),
                    AC = Convert.ToInt32(row["AC"]),
                    Background = row["Background"].ToString(),
                    Alignment = row["Alignment"].ToString(),
                    // Mapping complex objects
                    Classes = MapClassData(row),
                    Race = MapRaceData(row),
                    AbilityScores = MapAbilityScores(row),
                    Skills = MapList(row["Skills"].ToString(), ';'),
                    Proficiencies = MapList(row["Proficiencies"].ToString(), ';'),
                    Equipment = MapList(row["Equipment"].ToString(), ';')
                };

                characters.Add(character);
            }

            return characters;
        }

        /************************************************************************/
                                       /*HELPERS*/
        /************************************************************************/

        // Creates a new and returns the AbilityScores object
        private AbilityScores MapAbilityScores(Dictionary<string, object> row)
        {
            return new AbilityScores
            {
                Id = Convert.ToInt32(row["AbilityScoresId"]),
                CharacterID = Convert.ToInt32(row["CharacterID"]),
                Strength = Convert.ToInt32(row["Strength"]),
                Dexterity = Convert.ToInt32(row["Dexterity"]),
                Constitution = Convert.ToInt32(row["Constitution"]),
                Intelligence = Convert.ToInt32(row["Intelligence"]),
                Wisdom = Convert.ToInt32(row["Wisdom"]),
                Charisma = Convert.ToInt32(row["Charisma"])
            };
        }

        // Creates a new and returns the Classes object
        private Classes MapClassData(Dictionary<string, object> row)
        {
            return new Classes
            {
                Id = Convert.ToInt32(row["ClassId"]),
                ClassName = row["ClassName"].ToString(),
                HitDie = row["HitDie"].ToString(),
                PrimaryAbility = row["PrimaryAbility"].ToString(),
                SavingThrows = MapList(row["SavingThrows"].ToString(), ','),
                SkillChoices = MapList(row["SkillChoices"].ToString(), ';'),
                ClassFeatures = MapList(row["ClassFeatures"].ToString(), ';')
            };
        }

        // Creates a new and returns the Race object
        private Race MapRaceData(Dictionary<string, object> row)
        {
            return new Race
            {
                Id = Convert.ToInt32(row["RaceId"]),
                RaceName = row["RaceName"].ToString(),
                RaceSize = row["RaceSize"].ToString(),
                Speed = row["Speed"].ToString(),
                AbilityScoreBonuses = MapList(row["AbilityScoreBonuses"].ToString(), ','),
                Languages = MapList(row["Languages"].ToString(), ';'),
                RacialFeatures = MapList(row["RacialFeatures"].ToString(), ';')
            };
        }

        // Helper function to map delimited strings to a List<string>
        private List<string> MapList(string rawData, char delimiter)
        {
            if (string.IsNullOrWhiteSpace(rawData))
                return new List<string>();

            return rawData.Split(delimiter).Select(item => item.Trim()).ToList();
        }
    }
}
