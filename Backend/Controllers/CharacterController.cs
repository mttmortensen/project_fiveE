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
            // Step 1A: Insert Ability Scores and get the AbilityID
            var abilityScoresData = _mapper.MapAbilityScoresToDictionary(newCharacter.AbilityScores);
            string abilityScoreQuery = _queries.AddingNewAbilityScoresForCharacter;
            int abilityId = _database.InsertRawDataIntoDatabase(abilityScoreQuery, abilityScoresData);
        }
    }
}
