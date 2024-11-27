using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Text.Json;

namespace Backend
{
    public class Database
    {
        private static readonly string connectionString = "Server=your_server_name;Database=your_database_name;Trusted_Connection=True;";

        // Public method to get all characters
        public static List<Character> GetAllCharacters()
        {
            try 
            {
                // Step 1: Fetch the RAW Data from the databae 
                var dataRows = FetchRawDataFromDatabase("SELECT * FROM Characters");

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

        private static List<Dictionary<string, object>> FetchRawDataFromDatabase(string query)
        {
            using var connection = OpenConnection();
            using var command = CreateCommand(query, connection);
            using var reader = ExecuteReader(command);

            return ReadRows(reader);

        }

        private static SqlConnection OpenConnection()
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }        

        private static SqlCommand CreateCommand(string query, SqlConnection connection)
        {
            throw new NotImplementedException();
        }

    }
}
