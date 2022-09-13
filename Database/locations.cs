using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace CoffeeNegraWinForms.Database
{
    public class locations
    {
        public databasePath d = new databasePath();

        public void CreateLocationsTable(SQLiteConnection connection)
        {
            string sql = "CREATE TABLE `locations` (" +
                    "'id' INTEGER," +
                    "'name' TEXT," +
                    "PRIMARY KEY('id' AUTOINCREMENT));";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void InsertLocation(string location)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + d.dbpath))
            {
                connection.Open();

                string sql = "INSERT INTO locations (name) VALUES (?)";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@name", location));
                    cmd.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
