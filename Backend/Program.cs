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

}
