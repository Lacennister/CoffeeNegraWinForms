using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeNegraWinForms.Database;
using System.Data.SQLite;

namespace CoffeeNegraWinForms.Database
{
    public class databaseSeeder
    {
        public databasePath d = new databasePath();

        public void CreateDatabase()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + d.dbpath + ";New=True"))
            {
                connection.Open();

                users users_tbl = new users();
                users_tbl.CreateUsersTable(connection);
                users_tbl.InsertUser("admin", "admin");

                locations locations_tbl = new locations();
                locations_tbl.CreateLocationsTable(connection);
                locations_tbl.InsertLocation("Sta. Maria");
                locations_tbl.InsertLocation("Pulilan");

                employees employees_tbl = new employees();
                employees_tbl.CreateEmployeesTable(connection);

                connection.Close();
            }
        }
    }
}
