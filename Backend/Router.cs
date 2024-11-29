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
            if (request.HttpMethod == "GET" && request.Url.AbsolutePath == "/characters") 
            {
                // 1. Get controller ready to get all the characters 
                var characters = controller.GetAllCharacters();

                // 2. Wrap the response in a JSON string 
                return JsonSerializer.Serialize(characters);
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
                    // Log or handle the error (if needed) and return a 500 response
                    return $"500 Internal Server Error: {ex.Message}";
                }
            }


            return "404 not found";
        }
    }
}
