using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class RaceController
    {
        private readonly Database _database;
        private readonly RaceQueries _queries;
        private readonly RaceMapper _mapper;

        public RaceController(Database database) 
        {
            _database = database;
            _queries = new RaceQueries();
            _mapper = new RaceMapper();
        }

        public List<Race> GetAllRaces()
        {
            var rawData = _database.GetRawDataFromDatabase(_queries.GetAllRaces);
            return _mapper.MapToRaceList(rawData);
        }

        public Race GetCharacterRaceByCharacterID(int characterId)
        {
            var param = new Dictionary<string, object> { { "@CharacterID", characterId } };
            var data = _database.GetRawDataFromDatabase(_queries.GetCharacterRaceById, param);
            return data.Count > 0 ? _mapper.MapRaceData(data.First()) : null;
        }

        public void InsertCharacterRace(Character character)
        {
            var data = _mapper.MapCharacterRaceToDictionary(character);
            _database.ExecuteNonQuery(_queries.LinkCharacterRace, data);
        }

        public void InsertCharacterRaceSelection(Character character)
        {
            var data = _mapper.MapCharacterRaceSelectionToDictionary(character);
            _database.ExecuteNonQuery(_queries.LinkCharacterRaceSelection, data);
        }

    }
}
