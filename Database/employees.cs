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
                    "'work_day_id' NUMERIC," +
                    "'location_id' NUMERIC," +
                    "'name' TEXT," +
                    "'age' NUMERIC," +
                    "'birthday' TEXT," +
                    "'contact' TEXT," +
                    "'address' TEXT," +
                    "'work_shift' TEXT," +
                    "'time_availability' TEXT," +
                    "'morning' TEXT," +
                    "'afternoon' TEXT," +
                    "'archive' NUMERIC," +
                    "PRIMARY KEY('id' AUTOINCREMENT));";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public List<Employee> GetEmployees(int location_id)
        {
            List<Employee> _employees = new List<Employee>();

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + d.dbpath))
            {
                connection.Open();

                string sql = "SELECT id,name,age,birthday,contact,address,time_availability,morning,afternoon FROM employees WHERE archive=0 AND location_id=?";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@location_id", location_id));
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Employee _employee = new Employee();
                            _employee.id = reader.GetInt32(0);
                            _employee.name = (string)reader.GetValue(1);
                            _employee.age = reader.GetInt32(2);
                            _employee.birthday = ConvertFromDBVal<string>(reader.GetValue(3));
                            _employee.contact = ConvertFromDBVal<string>(reader.GetValue(4));
                            _employee.address = ConvertFromDBVal<string>(reader.GetValue(5));

                            TimeAvailability _timeAvailability = new TimeAvailability();
                            _timeAvailability.ParseFromString((string)reader.GetValue(6));
                            _employee.timeAvailability = _timeAvailability;

                            _timeAvailability = new TimeAvailability();
                            _timeAvailability.ParseFromString((string)reader.GetValue(7));
                            _employee.morning = _timeAvailability;

                            _timeAvailability = new TimeAvailability();
                            _timeAvailability.ParseFromString((string)reader.GetValue(8));
                            _employee.afternoon = _timeAvailability;

                            _employees.Add(_employee);
                        }

                        reader.Close();
                    }

                }

                connection.Close();
            }

            return _employees;
        }

        public List<Employee> GetEmployees(int location_id, string searchPattern)
        {
            List<Employee> _employees = new List<Employee>();

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + d.dbpath))
            {
                connection.Open();

                string sql = "SELECT id,name,age,birthday,contact,address,time_availability,morning,afternoon FROM employees WHERE archive=0 AND location_id=? AND (name LIKE ? OR birthday LIKE ? OR address LIKE ?)";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@location_id", location_id));
                    cmd.Parameters.Add(new SQLiteParameter("@name", "%" + searchPattern + "%"));
                    cmd.Parameters.Add(new SQLiteParameter("@birthday", "%" + searchPattern + "%"));
                    cmd.Parameters.Add(new SQLiteParameter("@address", "%" + searchPattern + "%"));
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Employee _employee = new Employee();
                            _employee.id = reader.GetInt32(0);
                            _employee.name = (string)reader.GetValue(1);
                            _employee.age = reader.GetInt32(2);
                            _employee.birthday = ConvertFromDBVal<string>(reader.GetValue(3));
                            _employee.contact = ConvertFromDBVal<string>(reader.GetValue(4));
                            _employee.address = ConvertFromDBVal<string>(reader.GetValue(5));

                            TimeAvailability _timeAvailability = new TimeAvailability();
                            _timeAvailability.ParseFromString((string)reader.GetValue(6));
                            _employee.timeAvailability = _timeAvailability;

                            _timeAvailability = new TimeAvailability();
                            _timeAvailability.ParseFromString((string)reader.GetValue(7));
                            _employee.morning = _timeAvailability;

                            _timeAvailability = new TimeAvailability();
                            _timeAvailability.ParseFromString((string)reader.GetValue(8));
                            _employee.afternoon = _timeAvailability;

                            _employees.Add(_employee);
                        }

                        reader.Close();
                    }

                }

                connection.Close();
            }

            return _employees;
        }

        public static T ConvertFromDBVal<T>(object obj)
        {
            if (obj == null || obj == DBNull.Value)
            {
                return default(T); // returns the default value for the type
            }
            else
            {
                return (T)obj;
            }
        }

        public object InsertEmployee(Employee _employee, int location_id, bool return_id = false)
        {
            object employee_id = -1;

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + d.dbpath))
            {
                connection.Open();

                string sql = "";
                bool isEmployeeAlreadyExist = false;

                sql = "SELECT * FROM employees WHERE id=?";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@id", _employee.id));
                    var employee = cmd.ExecuteScalar();

                    if (employee != null)
                    {
                        if (Convert.ToInt32(employee) == _employee.id)
                        {
                            isEmployeeAlreadyExist = true;
                        }
                    }

                }

                if (isEmployeeAlreadyExist == false)
                {
                    // ADD NEW EMPLOYEE
                    sql = "INSERT INTO employees (location_id, name, age, birthday, contact, address, time_availability, morning, afternoon, archive) VALUES (?,?,?,?,?,?,?,?,?,0); SELECT LAST_INSERT_ROWID();";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                    {
                        cmd.Parameters.Add(new SQLiteParameter("@location_id", location_id));
                        cmd.Parameters.Add(new SQLiteParameter("@name", _employee.name));
                        cmd.Parameters.Add(new SQLiteParameter("@age", _employee.age));
                        cmd.Parameters.Add(new SQLiteParameter("@birthday", _employee.birthday));
                        cmd.Parameters.Add(new SQLiteParameter("@contact", _employee.contact));
                        cmd.Parameters.Add(new SQLiteParameter("@address", _employee.address));
                        cmd.Parameters.Add(new SQLiteParameter("@time_availability", _employee.timeAvailability.ToString()));

                        cmd.Parameters.Add(new SQLiteParameter("@morning", _employee.morning.ToString()));
                        cmd.Parameters.Add(new SQLiteParameter("@afternoon", _employee.afternoon.ToString()));

                        if (return_id)
                        {
                            employee_id = cmd.ExecuteScalar();
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                else
                {
                    // UPDATE EXISTING EMPLOYEE
                    sql = "UPDATE employees SET location_id=?, name=?, age=?, birthday=?, contact=?, address=?, time_availability=?, morning=?, afternoon=? WHERE id=?";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                    {
                        cmd.Parameters.Add(new SQLiteParameter("@location_id", location_id));
                        cmd.Parameters.Add(new SQLiteParameter("@name", _employee.name));
                        cmd.Parameters.Add(new SQLiteParameter("@age", _employee.age));
                        cmd.Parameters.Add(new SQLiteParameter("@birthday", _employee.birthday));
                        cmd.Parameters.Add(new SQLiteParameter("@contact", _employee.contact));
                        cmd.Parameters.Add(new SQLiteParameter("@address", _employee.address));
                        cmd.Parameters.Add(new SQLiteParameter("@time_availability", _employee.timeAvailability.ToString()));

                        cmd.Parameters.Add(new SQLiteParameter("@morning", _employee.morning.ToString()));
                        cmd.Parameters.Add(new SQLiteParameter("@afternoon", _employee.afternoon.ToString()));

                        cmd.Parameters.Add(new SQLiteParameter("@id", _employee.id));
                        cmd.ExecuteNonQuery();
                    }
                }
                

                connection.Close();
            }

            return employee_id;
        }

        public void ArchiveEmployee(int employee_id)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + d.dbpath))
            {
                connection.Open();

                string sql = "UPDATE employees SET archive=1 WHERE id=?";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.Add(new SQLiteParameter("@id", employee_id));
                    cmd.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
