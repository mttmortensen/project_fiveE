using System.Net;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Backend
{
    public static class Router
    {
        public static string HandleRequest(HttpListenerRequest request) 
        {
            var controller = new CharacterController(new Database(), new CharacterMapper());

            // Check the request's path
            // Handle GET request to get all characters
            if (request.HttpMethod == "GET" && request.Url.AbsolutePath == "/characters") 
            {
                // 1. Get controller ready to get all the characters 
                var characters = controller.GetAllCharacters();

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
                        var character = controller.GetCharacterById(characterId);

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
                    var newCharacterId = controller.AddCharacter(newCharacter);

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

            // Handle PUT request to update an existing character
            if (request.HttpMethod == "PUT" && request.Url.AbsolutePath.StartsWith("/characters/"))
            {
                int id = int.Parse(request.Url.AbsolutePath.Split('/')[2]);
                using var reader = new StreamReader(request.InputStream);
                var requestBody = reader.ReadToEnd();
                var updatedCharacter = JsonSerializer.Deserialize<Character>(requestBody);

                var response = controller.UpdateCharacter(id, updatedCharacter);
                return JsonSerializer.Serialize(response);
            }


            // Handle DELETE request to remove a character
            if (request.HttpMethod == "DELETE" && request.Url.AbsolutePath.StartsWith("/characters/"))
            {
                var idString = request.Url.AbsolutePath.Replace("/characters/", "");
                if (int.TryParse(idString, out int characterId))
                {
                    var success = controller.DeleteCharacterById(characterId);
                    return JsonSerializer.Serialize(new { Message = success ? "Character deleted" : "Character not found" });
                }

                return "400 Bad Request: Invalid ID format.";
            }

            return "404 not found";
        }
    }
}
