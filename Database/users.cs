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
                    "'birthday' DATETIME," +
                    "PRIMARY KEY('id' AUTOINCREMENT));";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void InsertUser(string username, string password, string firstname, string lastname, DateTime birthday)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + d.dbpath))
            {
                connection.Open();

                string sql = "INSERT INTO users (username, password, first_name, last_name, birthday) VALUES (?,?,?,?,?)";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@username", username));
                    cmd.Parameters.Add(new SQLiteParameter("@password", _encrypt.EncryptPassword(password)));
                    cmd.Parameters.Add(new SQLiteParameter("@firstname", firstname));
                    cmd.Parameters.Add(new SQLiteParameter("@lastname", lastname));
                    cmd.Parameters.Add(new SQLiteParameter("@birthday", birthday.ToString("yyyy-MM-dd")));
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

                string sql = "SELECT username,password,first_name,last_name FROM users WHERE username=? AND password=?";
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

                            if (reader.GetValue(2) == DBNull.Value)
                            {
                                _user.firstname = "";
                            }
                            else
                            {
                                _user.firstname = (string)reader.GetValue(2);
                            }

                            if (reader.GetValue(3) == DBNull.Value)
                            {
                                _user.lastname = "";
                            }
                            else
                            {
                                _user.lastname = (string)reader.GetValue(3);
                            }
                        }
                        reader.Close();
                    }
                }

                connection.Close();
            }

            return _user;
        }

        public bool VerifyAccount(string username, DateTime birthday)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + d.dbpath))
            {
                connection.Open();

                string sql = "SELECT * FROM users WHERE username=? AND birthday=?";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@username", username));
                    cmd.Parameters.Add(new SQLiteParameter("@birthday", birthday.ToString("yyyy-MM-dd")));
                    var result = cmd.ExecuteScalar();
                    if (result == null)
                    {
                        return false;
                    }
                }

                connection.Close();
            }

            return true;
        }

        public bool ChangePassword(string password, string username, DateTime birthday)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + d.dbpath))
            {
                connection.Open();

                string sql = "UPDATE users SET password=? WHERE username=? AND birthday=?";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@password", _encrypt.EncryptPassword(password)));
                    cmd.Parameters.Add(new SQLiteParameter("@username", username));
                    cmd.Parameters.Add(new SQLiteParameter("@birthday", birthday.ToString("yyyy-MM-dd")));
                    cmd.ExecuteNonQuery();
                }

                connection.Close();
            }

            return true;
        }

    }
}
