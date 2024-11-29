namespace Backend
{
    public class CharacterController
    {
        private readonly Database _database;
        private readonly CharacterMapper _mapper;

        public CharacterController(Database database, CharacterMapper mapper)
        {
            _database = database;
            _mapper = mapper;
        }

        public List<Character> GetAllCharacters() 
        {
            // Step 1: Query raw data from Database 
            var rawData = _database.GetRawDataFromDatabase("SELECT * FROM Characters");

            // Step 2: Map raw data to the Character objects 
            return _mapper.MapToCharacterClass(rawData);
        }


    }
}
