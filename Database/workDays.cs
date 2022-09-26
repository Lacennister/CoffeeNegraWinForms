using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using CoffeeNegraWinForms.Class;

namespace CoffeeNegraWinForms.Database
{
    public class workDays
    {
        public databasePath d = new databasePath();
        PasswordEncryption _encrypt = new PasswordEncryption();

        public void CreateWorkDaysTable(SQLiteConnection connection)
        {
            string sql = "CREATE TABLE `work_days` (" +
                    "'id' INTEGER," +
                    "'location_id' NUMERIC," +
                    "'user_id' NUMERIC," +
                    "'work_shift' NUMERIC," +
                    "'work_day' TEXT," +
                    "PRIMARY KEY('id' AUTOINCREMENT));";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void InsertWorkDays(string user_id, TimeAvailability morning, TimeAvailability afternoon)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + d.dbpath))
            {
                connection.Open();

                if (morning.ToString() != "N/A") 
                {
                    string sql = "INSERT INTO work_days (user_id,work_shift,work_day) VALUES (?,?,?)";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                    {
                        cmd.Parameters.Add(new SQLiteParameter("@user_id", user_id));
                        cmd.Parameters.Add(new SQLiteParameter("@work_shift", 1));
                        cmd.Parameters.Add(new SQLiteParameter("@work_day", morning.ToString()));
                        cmd.ExecuteNonQuery();
                    }
                }

                if (afternoon.ToString() != "N/A")
                {
                    string sql = "INSERT INTO work_days (user_id,work_shift,work_day) VALUES (?,?,?,?)";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                    {
                        cmd.Parameters.Add(new SQLiteParameter("@user_id", user_id));
                        cmd.Parameters.Add(new SQLiteParameter("@work_shift", 2));
                        cmd.Parameters.Add(new SQLiteParameter("@work_day", afternoon.ToString()));
                        cmd.ExecuteNonQuery();
                    }
                }


                connection.Close();
            }
        }

        public void GetWorkDays(int work_shift, int user_id)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + d.dbpath))
            {
                connection.Open();

                string sql = "SELECT * FROM work_days WHERE user_id=? AND work_shift=?";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@user_id", user_id));
                    cmd.Parameters.Add(new SQLiteParameter("@work_shift", work_shift));

                    SQLiteDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //_user.username = (string)reader.GetValue(0);
                            //_user.password = (string)reader.GetValue(1);
                        }
                        reader.Close();
                    }
                }

                connection.Close();
            }
        }

    }
}
