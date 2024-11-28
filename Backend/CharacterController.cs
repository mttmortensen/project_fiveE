using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    }
}
