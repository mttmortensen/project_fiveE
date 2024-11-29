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
                    Class = row["Class"].ToString(),
                    HP = Convert.ToInt32(row["HP"]),
                    AbilityScores = row["AbilityScores"].ToString()
                });
            }
            return characters;
        }
    }
}
