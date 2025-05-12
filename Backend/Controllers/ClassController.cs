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


        /************************************************************************/
        /*                            STATIC CLASSES                            */
        /************************************************************************/

        public List<Classes> GetAllClasses()
        {
            var rawData = _database.GetRawDataFromDatabase(_queries.GetAllClasses);
            return _mapper.MapToClassList(rawData);
        }

        public Classes GetClassByCharacterId(int characterId)
        {
            var param = new Dictionary<string, object> { { "@CharacterID", characterId } };
            var rawData = _database.GetRawDataFromDatabase(_queries.GetCharacterClassByCharacterId, param);

            return rawData.Count > 0 ? _mapper.MapClassData(rawData.First()) : null;
        }

        /************************************************************************/
        /*                          CLASS OPTIONS (MENU)                        */
        /************************************************************************/

        public List<CharacterClassOptions> GetClassOptionsByCharacterId(int characterId)
        {
            var param = new Dictionary<string, object> { { "@CharacterID", characterId } };
            var rawData = _database.GetRawDataFromDatabase(_queries.GetCharacterClassOptionsById, param);
            return _mapper.MapToCharacterClassOptionsList(rawData);
        }

        /************************************************************************/
        /*                          CLASS SELECTION (FINAL)                    */
        /************************************************************************/

        public CharacterClassSelection GetCharacterClassSelectionByCharacterId(int characterId)
        {
            var param = new Dictionary<string, object> { { "@CharacterID", characterId } };
            var rawData = _database.GetRawDataFromDatabase(_queries.GetCharacterClassSelectionById, param);
            return rawData.Count > 0 ? _mapper.MapCharacterClassSelection(rawData.First()) : null;
        }

        public void InsertCharacterClassSelection(Character character)
        {
            var data = _mapper.MapCharacterClassSelectionToDictionary(character);
            _database.ExecuteNonQuery(_queries.LinkCharacterClassSelection, data);
        }
    }


}
