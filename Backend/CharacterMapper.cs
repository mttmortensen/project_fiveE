namespace Backend
{
    public class CharacterMapper
    {
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
                    Classes = row["Class"].ToString(),
                    HP = Convert.ToInt32(row["HP"]),
                    AbilityScores = row["AbilityScores"].ToString()
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
                    // Any function that starts with "Map" is to create a new object
                    // or List that has been defined in the Character class. 
                    Classes = MapClassData(row),
                    Race = MapRaceData(row),
                    AbilityScores = MapAbilityScores(row["AbilityScores"].ToString()),
                    Skills = MapSkills(row["Skills"].ToString()),
                    Proficiencies = MapProficiencies(row["Proficiencies"].ToString()),
                    Equipment = MapEquipment(row["Equipment"].ToString())
                };

                characters.Add(character);
            }

            return characters;
        }

        // Creates a new and returns the AbilityScore object 
        private List<AbilityScores> MapAbilityScores(string abilityScores)
        {
            var scores = abilityScores.Split(',');
            var abilityList = new List<AbilityScores>();

            for (int i = 0; i < scores.Length; i++) 
            {
                abilityList.Add(new AbilityScores 
                {
                    Name = GetAbilityName(i),
                    Value = int.Parse(scores[i])
                });
            }

            return abilityList;
        }

        // A helper function for MapAbilityScores 
        // Just easier to trace on what the abilities are
        private string GetAbilityName(int index)
        {
            var abilities = new[] { "Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma" };
            return abilities[index];
        }

        // Creates a new and returns the Classes object 
        private Classes MapClassData(Dictionary<string, object> row)
        {
            return new Classes
            {
                Name = row["Class"].ToString(),
                Description = row.ContainsKey("ClassDescription") ? row["ClassDescription"].ToString() : null
            };
        }

        // Creates a new and returns the Race object 
        private Race MapRaceData(Dictionary<string, object> row)
        {
            return new Race
            {
                Name = row["Race"].ToString(),
                Traits = row.ContainsKey("RaceTraits") ? row["RaceTraits"].ToString() : null
            };
        }

        // Creates a new and returns the string Skills List 
        private List<string> MapSkills(string skills)
        {
            return skills.Split(';').ToList();
        }

        // Creates a new and returns the string Proficiencies List
        private List<string> MapProficiencies(string proficiencies)
        {
            return proficiencies.Split(';').ToList();
        }

        // Creates a new and returns the string Equipment List
        private List<string> MapEquipment(string equipment)
        {
            return equipment.Split(';').ToList();
        }

        
    }
}
