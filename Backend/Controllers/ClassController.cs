using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class ClassController
    {
        private readonly Database _database;
        private readonly ClassQueries _queries;
        private readonly ClassMapper _mapper;

        public ClassController(Database database)
        {
            _database = database;
            _queries = new ClassQueries();
            _mapper = new ClassMapper();
        }

        public List<Classes> GetAllClasses()
        {
            var rawData = _database.GetRawDataFromDatabase(_queries.GetAllClasses);
            return _mapper.MapToClassList(rawData);
        }
    }
}
