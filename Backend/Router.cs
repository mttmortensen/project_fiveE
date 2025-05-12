using System.Net;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Backend
{
    public static class Router
    {
        public static string HandleRequest(HttpListenerRequest request) 
        {
            var charController = new CharacterController(new Database(), new CharacterMapper());
            var raceController = new RaceController(new Database());
            var classController = new ClassController(new Database());
            var subclassController = new SubclassController(new Database());
            var subraceController = new SubraceController(new Database());

            // Check the request's path
            // Handle GET request to get all characters
            if (request.HttpMethod == "GET" && request.Url.AbsolutePath == "/characters") 
            {
                // 1. Get controller ready to get all the characters 
                var characters = charController.GetAllCharacters();

                // 2. Wrap the response in a JSON string 
                return JsonSerializer.Serialize(characters);
            }

            // Handle GET request to get a specific character by ID
            if (request.HttpMethod == "GET" && request.Url.AbsolutePath.StartsWith("/characters/"))
            {
                try
                {
                    // Extract ID from URL
                    string[] segments = request.Url.AbsolutePath.Split('/');
                    if (segments.Length == 3 && int.TryParse(segments[2], out int characterId))
                    {
                        var character = charController.GetCharacterById(characterId);

                        if (character != null)
                        {
                            return JsonSerializer.Serialize(character);
                        }
                        else
                        {
                            return "404 Not Found: Character not found.";
                        }
                    }
                    else
                    {
                        return "400 Bad Request: Invalid character ID.";
                    }
                }
                catch (Exception ex)
                {
                    return $"500 Internal Server Error: {ex.Message}";
                }
            }


            // Handle POST request to add a new character
            if (request.HttpMethod == "POST" && request.Url.AbsolutePath == "/characters")
            {
                try
                {
                    // 1. Parse the request body into a Character object
                    using var reader = new StreamReader(request.InputStream);
                    var requestBody = reader.ReadToEnd();
                    var newCharacter = JsonSerializer.Deserialize<Character>(requestBody);

                    if (newCharacter == null)
                    {
                        return "400 Bad Request: Invalid character data.";
                    }

                    // 2. Add the character to the database
                    var newCharacterId = charController.AddCharacter(newCharacter);

                    // 3. Return the ID of the newly created character
                    var response = new { Message = "Character created successfully", Id = newCharacterId };
                    return JsonSerializer.Serialize(response);
                }
                catch (Exception ex)
                {
                    // Log or handle the error and return a 500 response
                    return $"500 Internal Server Error: {ex.Message}";
                }
            }

            // Handle PATCH request to update an existing character
            if (request.HttpMethod == "PATCH" && request.Url.AbsolutePath.StartsWith("/characters/"))
            {
                int id = int.Parse(request.Url.AbsolutePath.Split('/')[2]);
                using var reader = new StreamReader(request.InputStream);
                var requestBody = reader.ReadToEnd();
                var patchData = JsonSerializer.Deserialize<Dictionary<string, object>>(requestBody);

                charController.PartiallyUpdateCharacter(id, patchData);
                return $"Character {id} updated successfully!";

            }



            // Handle DELETE request to remove a character
            if (request.HttpMethod == "DELETE" && request.Url.AbsolutePath.StartsWith("/characters/"))
            {
                var idString = request.Url.AbsolutePath.Replace("/characters/", "");
                if (int.TryParse(idString, out int characterId))
                {
                    var success = charController.DeleteCharacterById(characterId);
                    return JsonSerializer.Serialize(new { Message = success ? "Character deleted" : "Character not found" });
                }

                return "400 Bad Request: Invalid ID format.";
            }

            // Handle GET request to get all race data
            if (request.HttpMethod == "GET" && request.Url.AbsolutePath == "/races")
            {
                // 1. Get controller ready to get all the races 
                var races = raceController.GetAllRaces();

                // 2. Wrap the response in a JSON string 
                return JsonSerializer.Serialize(races);
            }
            else if (request.HttpMethod == "GET" && request.Url.AbsolutePath == "/subraces")
            {
                var query = System.Web.HttpUtility.ParseQueryString(request.Url.Query);
                if (int.TryParse(query["raceId"], out int raceId))
                {
                    var subraces = subraceController.GetSubracesByRaceId(raceId);
                    return JsonSerializer.Serialize(subraces);
                }
                else
                {
                    return JsonSerializer.Serialize(new { error = "Missing or invalid raceId parameter." });
                }
            }

            // Handle GET request to get all classes data
            if (request.HttpMethod == "GET" && request.Url.AbsolutePath == "/classes")
            {
                // 1. Get controller ready to get all the classes 
                var classes = classController.GetAllClasses();

                // 2. Wrap the response in a JSON string 
                return JsonSerializer.Serialize(classes);
            }
            else if (request.HttpMethod == "GET" && request.Url.AbsolutePath == "/subclasses")
            {
                var query = System.Web.HttpUtility.ParseQueryString(request.Url.Query);
                if (int.TryParse(query["classId"], out int classId))
                {
                    var subclasses = subclassController.GetSubclassesByClassId(classId);
                    return JsonSerializer.Serialize(subclasses);
                }
                else
                {
                    return JsonSerializer.Serialize(new { error = "Missing or invalid classId parameter." });
                }
            }
            
            if (request.HttpMethod == "GET" && request.Url.AbsolutePath == "/character-class-options")
            {
                var query = System.Web.HttpUtility.ParseQueryString(request.Url.Query);
                if (int.TryParse(query["characterId"], out int characterId))
                {
                    var options = classController.GetClassOptionsByCharacterId(characterId);
                    return JsonSerializer.Serialize(options);
                }
                else
                {
                    return JsonSerializer.Serialize(new { error = "Missing or invalid characterId parameter." });
                }
            }
            else if (request.HttpMethod == "GET" && request.Url.AbsolutePath == "/character-class-selection")
            {
                var query = System.Web.HttpUtility.ParseQueryString(request.Url.Query);
                if (int.TryParse(query["characterId"], out int characterId))
                {
                    var selection = classController.GetCharacterClassSelectionByCharacterId(characterId);
                    return JsonSerializer.Serialize(selection);
                }
                else
                {
                    return JsonSerializer.Serialize(new { error = "Missing or invalid characterId parameter." });
                }
            }

            if (request.HttpMethod == "POST" && request.Url.AbsolutePath == "/character-class-selection")
            {
                using var reader = new StreamReader(request.InputStream);
                var requestBody = reader.ReadToEnd();
                var character = JsonSerializer.Deserialize<Character>(requestBody);

                if (character == null)
                {
                    return "400 Bad Request: Invalid character data.";
                }

                classController.InsertCharacterClassSelection(character);
                return JsonSerializer.Serialize(new { Message = "Character class selection saved." });
            }




            return "404 not found";
        }
    }
}
