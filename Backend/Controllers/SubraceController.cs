using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class SubraceController
    {
        private readonly Database _database;
        private readonly SubraceQueries _queries;
        private readonly SubraceMapper _mapper;
        public SubraceController(Database database)
        {
            _database = database;
            _queries = new SubraceQueries();
            _mapper = new SubraceMapper();
        }

        public List<Subrace> GetSubclassesByClassId(int classId)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@ClassID", classId }
            };
            var rawData = _database.GetRawDataFromDatabase(_queries.GetSubracesByRaceId, parameters);
            return _mapper.MapToSubraceList(rawData);
        }

    }
}
