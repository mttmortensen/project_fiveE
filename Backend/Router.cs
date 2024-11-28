using System.Net;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Backend
{
    public static class Router
    {
        public static string HandleRequest(HttpListenerRequest request) 
        {
            // Check the request's path 
            if (request.HttpMethod == "GET" && request.Url.AbsolutePath == "/characters") 
            {
                // 1. Get controller ready to get all the characters 
                var controller = new CharacterController(new Database(), new CharacterMapper());
                var characters = controller.GetAllCharacters();

                // 2. Wrap the response in a JSON string 
                return JsonSerializer.Serialize(characters);
            }

            return "404 not found";
        }
    }
}
