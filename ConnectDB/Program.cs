using Microsoft.Data.Sqlite;
using System;

class Person
{
    public int? id { get; set; }
    public string? name { get; set; }
    public string? last_name { get; set; }
}
class Program
{
    static async Task Main(string[] args)
    {
        string databasePath = @"proof.db";
        bool databaseExist = File.Exists(databasePath);
        if (!databaseExist)
        {
            using var connection = new SqliteConnection($"Data Source={databasePath}");
            await connection.OpenAsync();

            using var createTableSql = new SqliteCommand("CREATE TABLE IF NOT EXISTS Person (Id INTEGER PRIMARY KEY, Name TEXT)", connection);
            await createTableSql.ExecuteNonQueryAsync();

            using var insertSql = new SqliteCommand("INSERT INTO Person (Name) VALUES ('John Doe')", connection);
            await insertSql.ExecuteNonQueryAsync();

            using var command = new SqliteCommand("SELECT * FROM Person", connection);
            using var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                Console.WriteLine(reader["Name"].ToString());
            }
        }

    }
}