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
            // Step 1: Map the Character object to raw data format
            var characterData = _mapper.MapCharacterToDictionary(newCharacter);

            // Step 2: Construct the SQL query
            string query = @"
            INSERT INTO Characters (Name, Level, HP, AbilityId, RaceId, ClassId, Sex, XP, MaxHP, Speed, AC, Background, Alignment)
            VALUES (@Name, @Level, @HP, @AbilityId, @RaceId, @ClassId, @Sex, @XP, @MaxHP, @Speed, @AC, @Background, @Alignment);
            SELECT SCOPE_IDENTITY();"; // Returns the ID of the new row

            // Step 3: Use the database layer to insert the data
            return _database.InsertRawDataIntoDatabase(query, characterData);
        }
    }
}
