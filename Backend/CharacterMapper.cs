namespace Backend
{
    public class CharacterMapper
    {
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
                    CharacterClass = MapClassData(row),
                    CharacterRace = MapRaceData(row),
                    AbilityScores = MapAbilityScores(row["AbilityScores"].ToString()),
                    Skills = MapSkills(row["Skills"].ToString()),
                    Proficiencies = MapProficiencies(row["Proficiencies"].ToString()),
                    Equipment = MapEquipment(row["Equipment"].ToString())
                };

                characters.Add(character);
            }

            return characters;
        }
    }
}
