using System;

namespace Backend
{
    internal class Program
    {
        static void Main() 
        {
            Console.WriteLine("Let's fetch all Characters...");

            // Step 1: Query raw data from Database 
            var rawData = Database.GetRawDataFromDatabase("SELECT * FROM Characters");

            // Step 2: Map raw data to the Character objects 
            var characters = CharacterMapper.MapToCharacters(rawData);

            // Step 3: Display the Characters
            foreach (var character in characters) 
            {
                Console.WriteLine(character);
            }
        }
    }
}
