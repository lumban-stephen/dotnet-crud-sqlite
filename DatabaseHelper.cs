using System.Collections.Generic;
using System.Data.SQLite;
public class DatabaseHelper
{
    private const string ConnectionString = "Data Source=users.db;Version=3;";

    public DatabaseHelper()
    {
        CreateTable();
    }

    private void CreateTable()
    {
        using (var connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();
            string sql = "CREATE TABLE IF NOT EXISTS Users (Id INTEGER PRIMARY KEY AUTOINCREMENT, Username TEXT NOT NULL, Email TEXT NOT NULL)";
            using (var command = new SQLiteCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }

    public void AddUser(User user)
    {
        using (var connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();
            string sql = "INSERT INTO Users (Username, Email) VALUES (@Username, @Email)";
            using (var command = new SQLiteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.ExecuteNonQuery();
            }
        }
    }

    public List<User> GetAllUsers()
    {
        var users = new List<User>();
        using (var connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();
            string sql = "SELECT * FROM Users";
            using (var command = new SQLiteCommand(sql, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User
                        {
                            Id = reader.GetInt32(0),
                            Username = reader.GetString(1),
                            Email = reader.GetString(2)
                        });
                    }
                }
            }
        }
        return users;
    }
}