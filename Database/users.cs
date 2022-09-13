using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using CoffeeNegraWinForms.Class;

namespace CoffeeNegraWinForms.Database
{
    public class users
    {
        public databasePath d = new databasePath();
        PasswordEncryption _encrypt = new PasswordEncryption();

        public void CreateUsersTable(SQLiteConnection connection)
        {
            string sql = "CREATE TABLE `users` (" +
                    "'id' INTEGER," +
                    "'username' TEXT," +
                    "'password' TEXT," +
                    "'first_name' TEXT," +
                    "'last_name' TEXT," +
                    "'birthday' TEXT," +
                    "PRIMARY KEY('id' AUTOINCREMENT));";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void InsertUser(string username, string password)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + d.dbpath))
            {
                connection.Open();

                string sql = "INSERT INTO users (username, password) VALUES (?,?)";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@username", username));
                    cmd.Parameters.Add(new SQLiteParameter("@password", _encrypt.EncryptPassword(password)));
                    cmd.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public User GetUser(string username, string password)
        {
            User _user = new User();

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + d.dbpath))
            {
                connection.Open();

                string sql = "SELECT username,password FROM users WHERE username=? AND password=?";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@username", username));
                    cmd.Parameters.Add(new SQLiteParameter("@password", _encrypt.EncryptPassword(password)));

                    SQLiteDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            _user.username = (string)reader.GetValue(0);
                            _user.password = (string)reader.GetValue(1);
                        }
                        reader.Close();
                    }
                }

                connection.Close();
            }

            return _user;
        }

    }
}
