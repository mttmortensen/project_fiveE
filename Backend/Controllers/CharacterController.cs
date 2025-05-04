using System.Text.Json;

namespace Backend
{
    public class CharacterController
    {
        private readonly Database _database;
        private readonly CharacterMapper _mapper;
        private readonly CharacterQueries _queries;

        public CharacterController(Database database, CharacterMapper mapper)
        {
            _database = database;
            _mapper = mapper;
            _queries = new CharacterQueries();
        }

        public List<Character> GetAllCharacters()
        {
            // Step 1: Get all character base data
            var query = _queries.GetAllCharacterAndItsRelatedData;
            var rawData = _database.GetRawDataFromDatabase(query);

            // Step 2: Map raw data into Character objects
            var characters = _mapper.MapToCharacterClass(rawData);

            // Step 3: For each character, fetch their spells
            foreach (var character in characters)
            {
                var spellParams = new Dictionary<string, object>
                {
                    { "@CharacterID", character.CharacterID }
                };

                var spellData = _database.GetRawDataFromDatabase(_queries.GetSpellsByCharacterId, spellParams);
                character.Spells = _mapper.MapSpellsData(spellData);
            }

            return characters;
        }


        public Character GetCharacterById(int characterId)
        {
            // Step 1A: Bring in the query for _database to use
            var query = _queries.GetSingleCharacterAndRelatedData;
            var parameters = new Dictionary<string, object>
            {
                { "@CharacterID", characterId }
            };

            // Step 1B: Grab base character data
            var rawData = _database.GetRawDataFromDatabase(query, parameters);
            var character = rawData.Count > 0 ? _mapper.MapToCharacterClass(rawData).FirstOrDefault() : null;

            // Step 2: Grab spell data for that character and attach it
            if (character != null)
            {
                var spellData = _database.GetRawDataFromDatabase(_queries.GetSpellsByCharacterId, parameters);
                character.Spells = _mapper.MapSpellsData(spellData);
            }

            return character;
        }


        public int AddCharacter(Character newCharacter)
        {
            // Step 1: Insert the Character (without AbilityId) and get the CharacterId
            var characterData = _mapper.MapCharacterToDictionary(newCharacter);
            string characterQuery = _queries.AddingNewCharacterWithoutAbilityId;
            int characterId = _database.InsertRawDataIntoDatabase(characterQuery, characterData);

            // Step 2A: Insert Ability Scores with the CharacterId and get the AbilityId
            // Assign CharacterID to the Character object
            newCharacter.CharacterID = characterId; 
            var abilityScoresData = _mapper.MapAbilityScoresToDictionary(newCharacter.AbilityScores);

            // Include CharacterID in the AbilityScores data
            abilityScoresData["@CharacterID"] = characterId;

            string abilityScoreQuery = _queries.AddingNewAbilityScoresForCharacter;
            int abilityId = _database.InsertRawDataIntoDatabase(abilityScoreQuery, abilityScoresData);

            // Step 2B: Update the Character with the new AbilityId 
            newCharacter.AbilityID = abilityId;
            var updateCharacterData = new Dictionary<string, object>
            {
                {"@AbilityID", abilityId },
                {"@CharacterID", characterId},
            };

            string updatedCharacterQuery = _queries.UpdateCharacterWithAbilityId;
            _database.InsertRawDataIntoDatabase(updatedCharacterQuery, updateCharacterData);

            // Step 3: Insert the SpellIds with the CharacterId to CharacterSpells table



            return characterId;
        }

        public void PartiallyUpdateCharacter(int id, Dictionary<string, object> patchData)
        {
            // Convert JsonElements to their raw values
            var convertedData = new Dictionary<string, object>();

            foreach (var kvp in patchData)
            {
                var key = kvp.Key;
                var value = kvp.Value;

                if (value is JsonElement jsonElement)
                {
                    switch (jsonElement.ValueKind)
                    {
                        case JsonValueKind.String:
                            convertedData[key] = jsonElement.GetString();
                            break;
                        case JsonValueKind.Number:
                            if (jsonElement.TryGetInt32(out int intVal))
                                convertedData[key] = intVal;
                            else if (jsonElement.TryGetDouble(out double doubleVal))
                                convertedData[key] = doubleVal;
                            break;
                        case JsonValueKind.True:
                        case JsonValueKind.False:
                            convertedData[key] = jsonElement.GetBoolean();
                            break;
                        default:
                            // Null, Undefined, or Object/Array: ignore or handle differently
                            convertedData[key] = null;
                            break;
                    }
                }
                else
                {
                    convertedData[key] = value;
                }
            }

            // Include the CharacterID so the query can find the row
            convertedData["@CharacterID"] = id;

            // Build dynamic update query from keys
            var updateQuery = _queries.GeneratePartialUpdateQuery(convertedData.Keys.Where(k => k != "@CharacterID"));

            // Run the update
            _database.UpdateRawDataInDatabase(updateQuery, convertedData);
        }


        public bool DeleteCharacterById(int characterId)
        {
            var query = _queries.DeleteCharacterAndLinkedData;
            var parameters = new Dictionary<string, object>
            {
                { "@CharacterID", characterId }
            };

            int rowsAffected = _database.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

    }
}
