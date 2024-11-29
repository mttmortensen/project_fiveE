namespace Backend
{
    public class CharacterMapper
    {
        /************************************************************************/
                                    /*MAIN METHODS*/
        /************************************************************************/

        // Converts raw database rows into a list of Character objects
        public List<Character> MapToCharacterClass(List<Dictionary<string, object>> dataDictionaryRows)
        {
            var characters = new List<Character>();

            foreach (var row in dataDictionaryRows)
            {
                characters.Add(new Character
                {
                    CharacterID = Convert.ToInt32(row["CharacterID"]),
                    Name = row["Name"].ToString(),
                    Sex = row.ContainsKey("Sex") ? row["Sex"].ToString() : null,
                    Classes = MapClassData(row), 
                    Race = MapRaceData(row), 
                    AbilityScores = MapAbilityScores(row), 
                    Skills = row.ContainsKey("Skills") ? ParseList(row["Skills"].ToString()) : new List<string>(),
                    Proficiencies = row.ContainsKey("Proficiencies") ? ParseList(row["Proficiencies"].ToString()) : new List<string>(),
                    Equipment = row.ContainsKey("Equipment") ? ParseList(row["Equipment"].ToString()) : new List<string>(),
                    Background = row.ContainsKey("Background") ? row["Background"].ToString() : null,
                    Alignment = row.ContainsKey("Alignment") ? row["Alignment"].ToString() : null,
                    Level = Convert.ToInt32(row["Level"]),
                    HP = Convert.ToInt32(row["HP"]),
                    XP = row.ContainsKey("XP") ? Convert.ToInt32(row["XP"]) : 0,
                    MaxHP = row.ContainsKey("MaxHP") ? Convert.ToInt32(row["MaxHP"]) : 0,
                    Speed = row.ContainsKey("Speed") ? Convert.ToInt32(row["Speed"]) : 0,
                    AC = row.ContainsKey("AC") ? Convert.ToInt32(row["AC"]) : 0
                });
            }
            return characters;
        }

        // Converts a Character object into a dictionary of Characters for database insertion
        public Dictionary<string, object> MapCharacterToDictionary(Character character)
        {
            // Preparing the character object for database insertion by flattening it into key-value pairs
            return new Dictionary<string, object>
            {
                { "@Name", character.Name ?? (object)DBNull.Value },
                { "@Sex", character.Sex ?? (object)DBNull.Value },
                { "@Level", character.Level },
                { "@HP", character.HP },
                { "@XP", character.XP },
                { "@MaxHP", character.MaxHP },
                { "@Speed", character.Speed },
                { "@AC", character.AC },
                { "@Background", character.Background ?? (object)DBNull.Value },
                { "@Alignment", character.Alignment ?? (object)DBNull.Value },
                { "@ClassId", character.Classes?.ClassId ?? (object)DBNull.Value },
                { "@RaceId", character.Race?.RaceId ?? (object)DBNull.Value },
                { "@AbilityScoresId", character.AbilityScores?.AbilityId ?? (object)DBNull.Value },
                { "@Skills", string.Join(";", character.Skills) ?? (object)DBNull.Value },
                { "@Proficiencies", string.Join(";", character.Proficiencies) ?? (object)DBNull.Value },
                { "@Equipment", string.Join(";", character.Equipment) ?? (object)DBNull.Value }
            };
        }

        /************************************************************************/
                                     /*HELPERS*/
        /************************************************************************/

        // Maps raw database rows to an AbilityScores object
        private AbilityScores MapAbilityScores(Dictionary<string, object> row)
        {
            return new AbilityScores
            {
                AbilityId = Convert.ToInt32(row["AbilityId"]),
                CharacterID = Convert.ToInt32(row["CharacterID"]),
                Strength = Convert.ToInt32(row["Strength"]),
                Dexterity = Convert.ToInt32(row["Dexterity"]),
                Constitution = Convert.ToInt32(row["Constitution"]),
                Intelligence = Convert.ToInt32(row["Intelligence"]),
                Wisdom = Convert.ToInt32(row["Wisdom"]),
                Charisma = Convert.ToInt32(row["Charisma"])
            };
        }

        // Maps raw database rows to a Classes object
        private Classes MapClassData(Dictionary<string, object> row)
        {
            return new Classes
            {
                ClassId = Convert.ToInt32(row["ClassId"]),
                ClassName = row["ClassName"].ToString(),
                HitDie = row["HitDie"].ToString(),
                PrimaryAbility = row["PrimaryAbility"].ToString(),
                SavingThrows = MapList(row["SavingThrows"].ToString(), ','),
                SkillChoices = MapList(row["SkillChoices"].ToString(), ';'),
                ClassFeatures = MapList(row["ClassFeatures"].ToString(), ';')
            };
        }

        // Maps raw database rows to a Race object
        private Race MapRaceData(Dictionary<string, object> row)
        {
            return new Race
            {
                RaceId = Convert.ToInt32(row["RaceId"]),
                RaceName = row["RaceName"].ToString(),
                RaceSize = row["RaceSize"].ToString(),
                Speed = row["Speed"].ToString(),
                AbilityScoreBonuses = MapList(row["AbilityScoreBonuses"].ToString(), ','),
                Languages = MapList(row["Languages"].ToString(), ';'),
                RacialFeatures = MapList(row["RacialFeatures"].ToString(), ';')
            };
        }

        // Converts a delimited string into a list of strings
        private List<string> MapList(string rawData, char delimiter)
        {
            if (string.IsNullOrWhiteSpace(rawData))
                return new List<string>();

            return rawData.Split(delimiter).Select(item => item.Trim()).ToList();
        }

        // Parses a comma-separated string into a list of trimmed strings
        private List<string> ParseList(string listData)
        {
            // Assuming listData is a comma-separated string like "Skill1,Skill2,Skill3"
            return string.IsNullOrWhiteSpace(listData)
                ? new List<string>()
                : listData.Split(',').Select(item => item.Trim()).ToList();
        }
    }
}
