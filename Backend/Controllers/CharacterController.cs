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
            var query = _queries.GetAllCharacterAndItsRelatedData;
            var rawData = _database.GetRawDataFromDatabase(query);

            var characters = _mapper.MapToCharacterClass(rawData);

            foreach (var character in characters)
            {
                var param = new Dictionary<string, object> { { "@CharacterID", character.CharacterID } };

                // Load spells
                var spellData = _database.GetRawDataFromDatabase(_queries.GetSpellsByCharacterId, param);
                character.Spells = _mapper.MapSpellsData(spellData);

                // Load dynamic RACE info
                var raceData = _database.GetRawDataFromDatabase(_queries.GetCharacterRaceById, param);
                if (raceData.Count > 0)
                    character.Race = _mapper.MapRaceData(raceData.First());

                // Load dynamic CLASS info
                var classData = _database.GetRawDataFromDatabase(_queries.GetCharacterClassById, param);
                if (classData.Count > 0)
                    character.Classes = _mapper.MapClassData(classData.First());

                // Load dynamic SUBCLASS info
                var subclassData = _database.GetRawDataFromDatabase(_queries.GetCharacterSubclassById, param);
                if (subclassData.Count > 0)
                    character.Subclass = _mapper.MapSubclassData(subclassData.First());
            }

            return characters;
        }

        public Character GetCharacterById(int characterId)
        {
            var query = _queries.GetSingleCharacterAndRelatedData;
            var parameters = new Dictionary<string, object>
            {
                { "@CharacterID", characterId }
            };

            var rawData = _database.GetRawDataFromDatabase(query, parameters);
            var character = rawData.Count > 0 ? _mapper.MapToCharacterClass(rawData).FirstOrDefault() : null;

            if (character != null)
            {
                // Spells
                var spellData = _database.GetRawDataFromDatabase(_queries.GetSpellsByCharacterId, parameters);
                character.Spells = _mapper.MapSpellsData(spellData);

                // Race (dynamic + static)
                var raceData = _database.GetRawDataFromDatabase(_queries.GetCharacterRaceById, parameters);
                if (raceData.Count > 0)
                    character.Race = _mapper.MapRaceData(raceData.First());

                // Class (dynamic + static)
                var classData = _database.GetRawDataFromDatabase(_queries.GetCharacterClassById, parameters);
                if (classData.Count > 0)
                    character.Classes = _mapper.MapClassData(classData.First());

                // Subclass (dynamic + static)
                var subclassData = _database.GetRawDataFromDatabase(_queries.GetCharacterSubclassById, parameters);
                if (subclassData.Count > 0)
                    character.Subclass = _mapper.MapSubclassData(subclassData.First());
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
            var spellLinkData = _mapper.MapCharacterSpellsToDictionary(characterId, newCharacter.Spells);
            foreach(var paramSet in spellLinkData) 
            {
                _database.ExecuteNonQuery(_queries.LinkSpellToCharacter, paramSet);
            }

            // Step 4: Insert the Race character specific props to CharacterRace table
            var raceInsert = _mapper.MapCharacterRaceToDictionary(newCharacter);
            _database.ExecuteNonQuery(_queries.LinkCharacterRace, raceInsert);

            // Step 5: Insert dynamic class-specific data into CharacterClass table
            var classInsert = _mapper.MapCharacterClassToDictionary(newCharacter);
            _database.ExecuteNonQuery(_queries.LinkCharacterClass, classInsert);

            // Step 6: Insert dynamic subclass-specific data into CharacterSubclass table
            var subclassInsert = _mapper.MapCharacterSubclassToDictionary(newCharacter);
            _database.ExecuteNonQuery(_queries.LinkCharacterSubclass, subclassInsert);

            return characterId;
        }

        public void PartiallyUpdateCharacter(int id, Dictionary<string, object> patchData)
        {
            var convertedData = new Dictionary<string, object>();

            foreach (var kvp in patchData)
            {
                var key = kvp.Key;
                var value = kvp.Value;
                object parsedValue = null;

                if (value is JsonElement jsonElement)
                {
                    switch (jsonElement.ValueKind)
                    {
                        case JsonValueKind.String:
                            parsedValue = jsonElement.GetString();
                            break;
                        case JsonValueKind.Number:
                            if (jsonElement.TryGetInt32(out int intVal))
                                parsedValue = intVal;
                            else if (jsonElement.TryGetDouble(out double doubleVal))
                                parsedValue = doubleVal;
                            break;
                        case JsonValueKind.True:
                        case JsonValueKind.False:
                            parsedValue = jsonElement.GetBoolean();
                            break;
                        default:
                            parsedValue = null;
                            break;
                    }
                }
                else
                {
                    parsedValue = value;
                }

                // Add with @ prefix
                convertedData[$"@{key}"] = parsedValue ?? DBNull.Value;
            }

            // Include CharacterID for WHERE clause
            convertedData["@CharacterID"] = id;

            // Build SQL using un-prefixed names
            var updateQuery = _queries.GeneratePartialUpdateQuery(
                patchData.Keys.Where(k => !string.IsNullOrWhiteSpace(k))
            );

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
