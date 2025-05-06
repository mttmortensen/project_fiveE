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
    }
}
