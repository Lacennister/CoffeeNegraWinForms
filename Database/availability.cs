using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace CoffeeNegraWinForms.Database
{
    public class availability
    {
        public void CreateAvailabilityTable(SQLiteConnection connection)
        {
            string sql = "CREATE TABLE `availability` (" +
                    "'id' INTEGER," +
                    "'Monday' INTEGER," +
                    "'Tuesday' INTEGER," +
                    "'name' TEXT," +
                    "'age' INTEGER," +
                    "'birthday' DATE," +
                    "'contact' TEXT," +
                    "PRIMARY KEY('id' AUTOINCREMENT));";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}
