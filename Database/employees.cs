using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using CoffeeNegraWinForms.Class;
using System.Globalization;

namespace CoffeeNegraWinForms.Database
{
    public class employees
    {
        public databasePath d = new databasePath();

        public void CreateEmployeesTable(SQLiteConnection connection)
        {
            string sql = "CREATE TABLE `employees` (" +
                    "'id' INTEGER," +
                    "'location_id' INTEGER NULL," +
                    "'name' TEXT," +
                    "'age' INTEGER," +
                    "'birthday' TEXT," +
                    "'contact' TEXT," +
                    "'address' TEXT," +
                    "'time_availability' TEXT," +
                    "PRIMARY KEY('id' AUTOINCREMENT));";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> _employees = new List<Employee>();

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + d.dbpath))
            {
                connection.Open();

                string sql = "SELECT id,name,age,birthday,contact,address,time_availability FROM employees";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Employee _employee = new Employee();
                            _employee.id = reader.GetInt32(0);
                            _employee.name = (string)reader.GetValue(1);
                            _employee.age = reader.GetInt32(2);
                            _employee.birthday = (string)reader.GetValue(3);
                            _employee.contact = (string)reader.GetValue(4);
                            _employee.address = (string)reader.GetValue(5);

                            TimeAvailability _timeAvailability = new TimeAvailability();
                            _timeAvailability.ParseFromString((string)reader.GetValue(6));
                            _employee.timeAvailability = _timeAvailability;

                            _employees.Add(_employee);
                        }

                        reader.Close();
                    }

                }

                connection.Close();
            }

            return _employees;
        }

        public void InsertEmployee(Employee _employee)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + d.dbpath))
            {
                connection.Open();

                string sql = "INSERT INTO employees (location_id, name, age, birthday, contact, address, time_availability) VALUES (?,?,?,?,?,?,?)";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@location_id", 1));
                    cmd.Parameters.Add(new SQLiteParameter("@name", _employee.name));
                    cmd.Parameters.Add(new SQLiteParameter("@age", _employee.age));
                    cmd.Parameters.Add(new SQLiteParameter("@birthday", _employee.birthday));
                    cmd.Parameters.Add(new SQLiteParameter("@contact", _employee.contact));
                    cmd.Parameters.Add(new SQLiteParameter("@address", _employee.address));
                    cmd.Parameters.Add(new SQLiteParameter("@time_availability", _employee.timeAvailability.ToString()));
                    cmd.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
