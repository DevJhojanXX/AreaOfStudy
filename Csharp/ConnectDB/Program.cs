using System;
using System.IO;
using Microsoft.Data.Sqlite;

class Program
{
    static void Main()
    {
        // Crear la ruta de la base de datos si no existe
        string? dbPath = "DB/hello.db";
        if (!Directory.Exists(Path.GetDirectoryName(dbPath)))
        {
            Directory.CreateDirectory(Path.GetDirectoryName(dbPath));
        }

        // Crear la conexión a la base de datos
        using (var connection = new SqliteConnection($"Data Source={dbPath}"))
        {
            connection.Open();
            // Crear la tabla si no existe
            //string sql = @"
            //    CREATE TABLE IF NOT EXISTS users (
            //        id INTEGER PRIMARY KEY,
            //        name TEXT NOT NULL,
            //        email TEXT NOT NULL UNIQUE,
            //        password TEXT NOT NULL
            //    );
            //";
            //string sql = @"
            //    CREATE TABLE IF NOT EXISTS Animal (
            //        Id INTEGER PRIMARY KEY,
            //        Name TEXT NOT NULL,
            //        Description TEXT NOT NULL UNIQUE,
            //        SpeciesType INTEGER NOT NULL,
            //        SpeciesName TEXT NOT NULL,
            //        Img TEXT NOT NULL
            //    );
            //";
            //string sql = @"
            //    INSERT INTO users (id, name, email, password)
            //    VALUES 
            //        (1, 'John Doe', '123 Main St', '555-1234'),
            //        (2, 'Jane Doe', '456 Elm St', '555-5678'),
            //        (3, 'Mike Smith', '789 Oak St', '555-9012');
            //";
            int id = 3;
            string sql = $"SELECT name FROM Animal WHERE id = {id}";
            //List<string> sqlInserts = new List<string>
            //{
            //    $"INSERT INTO Animal (Id, Name, Description, SpeciesType, SpeciesName, Img) VALUES (1, 'Lion', 'The king of the jungle', 1, 'Mammal', 'lion.jpg')",
            //    $"INSERT INTO Animal (Id, Name, Description, SpeciesType, SpeciesName, Img) VALUES (2, 'Octopus', 'A highly intelligent sea creature', 2, 'Mollusk', 'octopus.jpg')",
            //    $"INSERT INTO Animal (Id, Name, Description, SpeciesType, SpeciesName, Img) VALUES (3, 'Parrot', 'A colorful and talkative bird', 3, 'Bird', 'parrot.jpg')"
            //};
            //foreach (var sql in sqlInserts)
            //{
            //}
            using (var command = new SqliteCommand(sql, connection))
            {
                command.ExecuteNonQuery();
                Console.WriteLine($"se creo: {command.CommandText}");
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var name = reader.GetString(0);
                        Console.WriteLine($"Hello, {name}!");
                    }
                }
            }
            
        }
    }
}