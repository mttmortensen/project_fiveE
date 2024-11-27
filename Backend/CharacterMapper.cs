using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class CharacterMapper
    {

        // Public method to get all characters
        public static List<Character> GetAllCharacters()
        {
            try
            {
                // Step 1: Fetch the RAW Data from the databae 
                var dataRows = Database.FetchRawDataFromDatabase("SELECT * FROM Characters");

                // Step 2: Map the RAW Data to Character objects 
                return MapCharacters(dataRows);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: fetch characters: {ex.Message}");
                return new List<Character>();
            }

        }

        private static List<Character> MapCharacters(object dataRows)
        {
            throw new NotImplementedException();
        }
    }
}
