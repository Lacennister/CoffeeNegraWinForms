using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace CoffeeNegraWinForms.Database
{
    public class users
    {
        public void CreateUsersTable(SQLiteConnection connection)
        {
            string sql = "CREATE TABLE `users` (" +
                    "'id' INTEGER," +
                    "'username' TEXT," +
                    "'password' TEXT," +
                    "'first_name' TEXT," +
                    "'last_name' TEXT," +
                    "PRIMARY KEY('id' AUTOINCREMENT));";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}
