﻿using Microsoft.Data.SqlClient;

namespace Backend
{
    public class Database
    {
        private static readonly string connectionString = "Server=MORTENSENS-MPC\\SQLEXPRESS;Database=DNDCharacterDB;Trusted_Connection=True;;TrustServerCertificate=True;";

        /************************************************************************/
        /*MAIN METHODS*/
        /************************************************************************/

        // Putting it all together to get the actual raw data
        public List<Dictionary<string, object>> GetRawDataFromDatabase(string query, Dictionary<string, object>? parameters = null)
        {
            using var connection = OpenConnection();
            using var command = CreateCommand(query, connection);

            // Add parameters if any
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                }
            }

            using var reader = ExecuteReader(command);
            return ReadRows(reader);
        }


        // Putting it all togther to insert/post actual raw data
        public int InsertRawDataIntoDatabase(string query, Dictionary<string, object> parameters)
        {
            using var connection = OpenConnection();
            using var command = CreateCommand(query, connection);

            AddParameter(command, parameters);

            // Execute the command and return the ID of the newly inserted row
            return Convert.ToInt32(command.ExecuteScalar());
        }

        // Updating Raw Data in the Database
        public void UpdateRawDataInDatabase(string query, Dictionary<string, object> parameters)
        {
            using var connection = OpenConnection();
            using var command = CreateCommand(query, connection);

            foreach (var param in parameters)
            {
                command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
            }

            command.ExecuteNonQuery();
        }


        /************************************************************************/
        /*HELPERS*/
        /************************************************************************/

        // Open a database connection
        private static SqlConnection OpenConnection()
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        // Create a SQL Command
        private static SqlCommand CreateCommand(string query, SqlConnection connection)
        {
            return new SqlCommand(query, connection);
        }

        // Adding Parameters to the SQL Command
        private static void AddParameter(SqlCommand command, Dictionary<string, object> parameters) 
        {
            foreach (var parm in parameters)
            {
                command.Parameters.AddWithValue(parm.Key, parm.Value ?? DBNull.Value);
            }
        }
        
        // Execute the command and get a data reader
        private static SqlDataReader ExecuteReader(SqlCommand command)
        {
            return command.ExecuteReader();
        }

        // Process the data reader into a list of dictionaries
        private static List<Dictionary<string, object>> ReadRows(SqlDataReader reader)
        {
            var results = new List<Dictionary<string, object>>();
            while (reader.Read())
            {
                var row = new Dictionary<string, object>();
                for (int i = 0; i < reader.FieldCount; i++) 
                {
                    row[reader.GetName(i)] = reader.GetValue(i);
                }
                results.Add(row);
            }
            return results;
        }

        public int ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            using var connection = OpenConnection();
            using var command = CreateCommand(query, connection);

            foreach (var param in parameters)
            {
                command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
            }

            return command.ExecuteNonQuery();
        }


    }
}
