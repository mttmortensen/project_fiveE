﻿namespace Backend
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

            // Step 1A: Bring in the query for _database to use
            var query = _queries.GetAllCharacterAndItsRelatedData;

            // Step 1B: Query raw data from Database 
            var rawData = _database.GetRawDataFromDatabase(query);

            // Step 2: Map raw data to the Character objects 
            return _mapper.MapToCharacterClass(rawData);
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

            return characterId;
        }
    }
}
