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
    }
}
