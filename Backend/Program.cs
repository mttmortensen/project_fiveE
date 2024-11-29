using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Backend;

class Program
{
    static async Task Main(string[] args)
    {
        string url = "http://localhost:5000/"; // Base URL

        // Create and configure the HTTP listener
        HttpListener listener = new HttpListener();
        listener.Prefixes.Add(url);

        try
        {
            // Start the listener
            listener.Start();
            Console.WriteLine($"Server running at {url}");

            while (true)
            {
                // Wait for an incoming request
                HttpListenerContext context = await listener.GetContextAsync();
                _ = Task.Run(() => HandleRequest(context)); // Handle the request asynchronously
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            // Stop the listener on shutdown
            listener.Stop();
        }
    }


    static async Task HandleRequest(HttpListenerContext context)
    {
        try
        {
            // Get the request and response objects
            HttpListenerRequest request = context.Request;
            HttpListenerResponse response = context.Response;

            Console.WriteLine($"Received request: {request.HttpMethod} {request.Url}");

            // Delegate request handling to the Router
            string responseBody = Router.HandleRequest(request);

            // Set up the response
            byte[] buffer = Encoding.UTF8.GetBytes(responseBody);
            response.ContentType = "application/json";
            response.ContentLength64 = buffer.Length;
            response.StatusCode = (responseBody.Contains("404 not found") || responseBody.Contains("400")) ? 404 : 200;

            // Write the response
            await response.OutputStream.WriteAsync(buffer, 0, buffer.Length);
        }

    }

}
