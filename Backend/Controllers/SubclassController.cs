using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class SubclassController
    {
        private readonly Database _database;
        private readonly SubclassQueries _queries;
        private readonly SubclassMapper _mapper;
        public SubclassController(Database database)
        {
            _database = database;
            _queries = new SubclassQueries();
            _mapper = new SubclassMapper();
        }

        public List<Subclass> GetSubclassesByClassId(int classId)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@ClassID", classId }
            };
            var rawData = _database.GetRawDataFromDatabase(_queries.GetSubclassesByClassId, parameters);
            return _mapper.MapToSubclassList(rawData);
        }

    }
}
